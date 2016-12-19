using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using SnmpSharpNet;
using System.Net.Sockets;
using System.Threading;

namespace SNMP_agent {
    public class AgentSNMP {
        static private SimpleSnmp snmp;
        private Form1 gui;
        public bool activeWatching { get; private set; }
        public bool activeTrapReceiver { get; private set; }
        string OID_numer;
        string SNMP_operation;


        public AgentSNMP(Form1 gui) {
            this.gui = gui;
            activeWatching = false;
            string host = "127.0.0.1";
            string community = "public";
            snmp = new SimpleSnmp(host, community);
            //getTable(".1.3.6.1.2.1.2.2");
        }

        public void StartWatching(string OID_numer, string SNMP_operation)
        {
            this.OID_numer = OID_numer;
            this.SNMP_operation = SNMP_operation;
            new Thread(watch).Start();
        }

        private void watch()
        { 
            string[] result = null;
            string[] oldresult = null;

            activeWatching = true;
            while (activeWatching)
            {
                oldresult = result;

                if (SNMP_operation == "Get" )
                    result = readGetResult(snmp.Get(SnmpVersion.Ver1, new string[] { OID_numer }));
                else if (SNMP_operation == "GetNext")
                    result =readGetResult( snmp.GetNext(SnmpVersion.Ver1, new string[] { OID_numer }));

                if (result !=null && ((oldresult !=null && result[2] != oldresult[2]) || oldresult == null))
                {               
                    //var valuesTable = readGetResult(result);
                    gui.addRowToWatchedElementsTable(result[0], result[2], result[1]);
                }
                Thread.Sleep(1000);
            }
        }

        public void stopWatching()
        {
            activeWatching = false;
        } 

        public string[] getNext(string oid) {
            Dictionary<Oid, AsnType> result = snmp.GetNext(SnmpVersion.Ver2, new string[] {oid});
            if (result == null) {
                Console.WriteLine("Request failed.");
                return null;
            }
            else {
                return readGetResult(result);
            }
        }

        public string[] get(string oid) {
            if (!snmp.Valid) {
                Console.WriteLine("SNMP agent host name/ip address is invalid.");
                return null;
            }
            Dictionary<Oid, AsnType> result = snmp.Get(SnmpVersion.Ver2,
                new string[] {oid});
            if (result == null) {
                Console.WriteLine("No results received.");
                return null;
            }
            else {
                return readGetResult(result);
            }      
        }
   
        private string[] readGetResult(Dictionary<Oid, AsnType> result) {

            if (result == null)
                return null;
            var rsltStrings= new string[3];
            foreach (KeyValuePair<Oid, AsnType> kvp in result) {
             
                rsltStrings[0] = kvp.Key.ToString();
                rsltStrings[1] = SnmpConstants.GetTypeName(kvp.Value.Type);
                rsltStrings[2] = kvp.Value.ToString();
                
            }
            return rsltStrings;
        }

        public static VbCollection CreateVbCol(String value, String name, String type) {
            VbCollection col = new VbCollection();
            col.Add(new Oid(name), new OctetString(value));
            
            return col;
        }

        public static bool SendTrap(TrapAgent agent, String receiverIP, int port, String community, String oid,
                                    String senderIP, int generic, int specific, uint senderUpTime, VbCollection col)
        {
            try {
                agent.SendV1Trap(new IpAddress(receiverIP), port, community,
                    new Oid(oid), new IpAddress(senderIP),
                    generic, specific, senderUpTime, col);
                return true;
            }
            catch (Exception e)
            { return false; }
        }

        public void startTrap()
        {
            new Thread(ReceiveTrap).Start();
        }

        public void stopTrap()
        {
            activeTrapReceiver = false;
        }

        public void ReceiveTrap()
        {
            activeTrapReceiver = true;
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 162);
            EndPoint ep = (EndPoint)ipep;
            socket.Bind(ep);

            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 0);
            //bool run = true;
            int inlen = -1;
            while (activeTrapReceiver)
            {
                DateTime time = DateTime.Now;
                byte[] indata = new byte[16 * 1024];

                IPEndPoint peer = new IPEndPoint(IPAddress.Any, 0);
                EndPoint inep = (EndPoint)peer;
                try
                {
                    inlen = socket.ReceiveFrom(indata, ref inep);
                    time = DateTime.Now;
                }
                catch (Exception ex)
                {
                    inlen = -1;
                }
                if (inlen > 0)
                {
                    int ver = SnmpPacket.GetProtocolVersion(indata, inlen);
                    if (ver == (int)SnmpVersion.Ver1)
                    {                       
                        SnmpV1TrapPacket pkt = new SnmpV1TrapPacket();
                        pkt.decode(indata, inlen);

                        foreach (Vb v in pkt.Pdu.VbList)
                        {                         
                            gui.addRowToTrapTable(pkt.Pdu.AgentAddress.ToString(), v.Oid.ToString(), v.Value.ToString(), time, pkt.Pdu.Generic);                        
                        }              
                    }
                }
            }
        }

        public List<List<string>> getTable(string oid) {
            var listOfRows = new List<List<string>>();
            var row= new List<string>();


            Dictionary<String, Dictionary<uint, AsnType>> result = new Dictionary<String, Dictionary<uint, AsnType>>();
            // Not every row has a value for every column so keep track of all columns available in the table
            List<uint> tableColumns = new List<uint>();
            // Prepare agent information
            AgentParameters param = new AgentParameters(SnmpVersion.Ver2, new OctetString(snmp.Community));

            IpAddress peer = new IpAddress(snmp.PeerIP);
            if (!
                    peer.Valid
            ) {
                Console.WriteLine("Unable to resolve name or error in address for peer: {0}", snmp.PeerIP);
                return null;
            }

            //snmp.MaxRepetitions=100;
            //snmp.NonRepeaters = 0;
            //snmp.GetBulk( new string[] {oid});

            UdpTarget target = new UdpTarget((IPAddress)peer);
            // This is the table OID supplied on the command line
            Oid startOid = new Oid(oid);
            // Each table OID is followed by .1 for the entry OID. Add it to the table OID
            startOid.Add(1); // Add Entry OID to the end of the table OID
            // Prepare the request PDU
            Pdu bulkPdu = Pdu.GetBulkPdu();
            bulkPdu.VbList.Add(startOid);
            // We don't need any NonRepeaters
            bulkPdu.NonRepeaters = 0;
            // Tune MaxRepetitions to the number best suited to retrive the data
            bulkPdu.MaxRepetitions = 100;
            // Current OID will keep track of the last retrieved OID and be used as 
            //  indication that we have reached end of table
            Oid curOid = (Oid)startOid.Clone();
            // Keep looping through results until end of table
            while (
                startOid.IsRootOf(curOid)) {
                SnmpPacket res = null;
                try {
                    res = target.Request(bulkPdu, param);
                }
                catch (Exception ex) {
                    Console.WriteLine("Error: Request failed: {0}", ex.Message);
                    target.Close();
                    return null;
                }
                // For GetBulk request response has to be version 2
                if (res.Version != SnmpVersion.Ver2) {
                    Console.WriteLine("Received wrong SNMP version response packet.");
                    target.Close();
                    return null;
                }
                // Check if there is an agent error returned in the reply
                if (res.Pdu.ErrorStatus != 0) {
                    Console.WriteLine("SNMP agent returned error {0} for request Vb index {1}",
                        res.Pdu.ErrorStatus, res.Pdu.ErrorIndex);
                    target.Close();
                    return null;
                }
                // Go through the VbList and check all replies
                foreach (Vb v in res.Pdu.VbList) {
                    curOid = (Oid)v.Oid.Clone();
                    // VbList could contain items that are past the end of the requested table.
                    // Make sure we are dealing with an OID that is part of the table
                    if (startOid.IsRootOf(v.Oid)) {
                        // Get child Id's from the OID (past the table.entry sequence)
                        uint[] childOids = Oid.GetChildIdentifiers(startOid, v.Oid);
                        // Get the value instance and converted it to a dotted decimal
                        //  string to use as key in result dictionary
                        uint[] instance = new uint[childOids.Length - 1];
                        Array.Copy(childOids, 1, instance, 0, childOids.Length - 1);
                        String strInst = InstanceToString(instance);
                        // Column id is the first value past <table oid>.entry in the response OID
                        uint column = childOids[0];
                        if (!tableColumns.Contains(column))
                            tableColumns.Add(column);
                        if (result.ContainsKey(strInst)) {
                            result[strInst][column] = (AsnType)v.Value.Clone();
                        }
                        else {
                            result[strInst] = new Dictionary<uint, AsnType>();
                            result[strInst][column] = (AsnType)v.Value.Clone();
                        }
                    }
                    else {
                        // We've reached the end of the table. No point continuing the loop
                        break;
                    }
                }
                // If last received OID is within the table, build next request
                if (startOid.IsRootOf(curOid)) {
                    bulkPdu.VbList.Clear();
                    bulkPdu.VbList.Add(curOid);
                    bulkPdu.NonRepeaters = 0;
                    bulkPdu.MaxRepetitions = 10;
                }
            }
            target.Close();
            if (result.Count <= 0) {
                Console.WriteLine("No results returned.\n");
            }
            else {
                Console.Write("Instance");
                foreach (uint column in tableColumns) {
                    Console.Write("\tColumn id {0}", column);
                }
                Console.WriteLine("");
                foreach (KeyValuePair<string, Dictionary<uint, AsnType>> kvp in result) {
                    Console.Write("{0}", kvp.Key);
                    row= new List<string>();
                    foreach (uint column in tableColumns) {
                        if (kvp.Value.ContainsKey(column)) {
                            row.Add(kvp.Value[column].ToString());
                            //row[1] = SnmpConstants.GetTypeName(kvp.Value[column].Type);
                            //Console.Write("\t{0} + ({1}) ||", kvp.Value[column].ToString(),
                            //    SnmpConstants.GetTypeName(kvp.Value[column].Type));
                        }
                        else {
                            Console.Write("\t-");
                        }
                    }
                    listOfRows.Add(row);
                    Console.WriteLine("");
                }
            }
            return listOfRows;
        }


        public static string InstanceToString(uint[] instance) {
            StringBuilder str = new StringBuilder();
            foreach (uint v in instance) {
                if (str.Length == 0)
                    str.Append(v);
                else
                    str.AppendFormat(".{0}", v);
            }
            return str.ToString();
        }
    }
}