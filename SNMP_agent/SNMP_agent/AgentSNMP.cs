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

namespace SNMP_agent {
    public class AgentSNMP {
         static private SimpleSnmp snmp;

        public AgentSNMP() {
            string host = "127.0.0.1";
            string community = "public";
            snmp = new SimpleSnmp(host, community);


            
        }

        public List<string[]> getNext(string oid) {
            Dictionary<Oid, AsnType> result = snmp.GetNext(SnmpVersion.Ver2, new string[] {oid});
            if (result == null) {
                Console.WriteLine("Request failed.");
                return null;
            }
            else {
                return readGetResult(result);
            }
        }

        public List<string[]> get(string oid) {
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
            /*foreach (KeyValuePair<Oid, AsnType> kvp in result) {
                Console.WriteLine("{0}: {1} {2}", kvp.Key.ToString(),
                    SnmpConstants.GetTypeName(kvp.Value.Type),
                    kvp.Value.ToString());
            }*/
        }

        private List<string[]> readGetResult(Dictionary<Oid, AsnType> result) {
            var rows = new List<string[]>();
            var rsltStrings= new string[3];
            foreach (KeyValuePair<Oid, AsnType> kvp in result) {
                Console.WriteLine("{0}: {1} {2}", kvp.Key.ToString(),
                    SnmpConstants.GetTypeName(kvp.Value.Type),
                    kvp.Value.ToString());
                rsltStrings[0] = kvp.Key.ToString();
                rsltStrings[1] = SnmpConstants.GetTypeName(kvp.Value.Type);
                rsltStrings[2] = kvp.Value.ToString();
                rows.Add(rsltStrings);
            }
            return rows;
        }

        public static VbCollection VbCol(String str, String oid, uint time) {
            VbCollection col = new VbCollection();
            col.Add(new Oid("1.3.6.1.2.1.1.1.0"), new OctetString(str));
            col.Add(new Oid("1.3.6.1.2.1.1.2.0"), new Oid(oid));
            col.Add(new Oid("1.3.6.1.2.1.1.3.0"), new TimeTicks(2324));
            return col;
        }

        public static void Trap(TrapAgent agent, String receiverIP, int port, String community, String oid,
            String senderIP,
            int generic, int specific, uint senderUpTime, VbCollection col) {
            agent.SendV1Trap(new IpAddress(receiverIP), port, community,
                new Oid(oid), new IpAddress(senderIP),
                generic, specific, senderUpTime, col);
        }

        static void ReceiveTrap()
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 162);
            EndPoint ep = (EndPoint)ipep;
            socket.Bind(ep);

            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 0);
            bool run = true;
            int inlen = -1;
            while (run)
            {
                byte[] indata = new byte[16 * 1024];

                IPEndPoint peer = new IPEndPoint(IPAddress.Any, 0);
                EndPoint inep = (EndPoint)peer;
                try
                {
                    inlen = socket.ReceiveFrom(indata, ref inep);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception {0}", ex.Message);
                    inlen = -1;
                }
                if (inlen > 0)
                {
                    int ver = SnmpPacket.GetProtocolVersion(indata, inlen);
                    if (ver == (int)SnmpVersion.Ver1)
                    {
                        SnmpV1TrapPacket pkt = new SnmpV1TrapPacket();
                        pkt.decode(indata, inlen);
                        Console.WriteLine("** SNMP Version 1 TRAP received from {0}:", inep.ToString());
                        Console.WriteLine("*** Trap generic: {0}", pkt.Pdu.Generic);
                        Console.WriteLine("*** Trap specific: {0}", pkt.Pdu.Specific);
                        Console.WriteLine("*** Agent address: {0}", pkt.Pdu.AgentAddress.ToString());
                        Console.WriteLine("*** Timestamp: {0}", pkt.Pdu.TimeStamp.ToString());
                        Console.WriteLine("*** VarBind count: {0}", pkt.Pdu.VbList.Count);
                        Console.WriteLine("*** VarBind content:");
                        foreach (Vb v in pkt.Pdu.VbList)
                        {
                            Console.WriteLine("**** {0} {1}: {2}", v.Oid.ToString(), SnmpConstants.GetTypeName(v.Value.Type), v.Value.ToString());
                        }
                        Console.WriteLine("** End of SNMP Version 1 TRAP data.");
                    }
                }
                else
                {
                    if (inlen == 0)
                        Console.WriteLine("Zero length packet received.");
                }
            }
        }
    }
}