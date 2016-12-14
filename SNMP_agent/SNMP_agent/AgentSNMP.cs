using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using SnmpSharpNet;

namespace SNMP_agent
{
    public class AgentSNMP
    {
        private SimpleSnmp snmp;

        public AgentSNMP()
        {
            string host = "localhost";
            string community = "public";
            snmp = new SimpleSnmp(host, community);


            String receiverIP = host;
            int port = 162;
            //String community = "public";
            String oid = "1.3.6.1.2.1.1.1.0";
            String senderIP = receiverIP;
            int generic = SnmpConstants.LinkUp; //coldStart trap(0) warmStart trap(1) linkDown trap(2) linkUp trap(3) authenticationFailure trap(4) egpNeighborLoss trap(5)
            int specific = 0; //dla generic 0-5
            uint senderUpTime = 12345;

            TrapAgent agent = new TrapAgent();

            VbCollection col = VbCol("gowno", "1.3.6.1.9.1.1.0", 1234);

            Trap(agent, receiverIP, port, community, oid, senderIP, generic, specific, senderUpTime, col);
        }

        public Dictionary<Oid, AsnType> getNext(string oid)
        {
            Dictionary<Oid, AsnType> result = snmp.GetNext(SnmpVersion.Ver1, new string[] {"1.3.6.1.2.1.1"});
            if (result == null) {
                Console.WriteLine("Request failed.");
                return null;
            }
            else {
                return result;
            }
        }

        public Dictionary<Oid, AsnType> get(string oid)
        {
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
                return result;
            }
            /*foreach (KeyValuePair<Oid, AsnType> kvp in result) {
                Console.WriteLine("{0}: {1} {2}", kvp.Key.ToString(),
                    SnmpConstants.GetTypeName(kvp.Value.Type),
                    kvp.Value.ToString());
            }*/
        }

        private string[] readGetResult(Dictionary<Oid, AsnType> result)
        {
            string[] rsltStrings = new string[result.Count];
            int i = 0;
            foreach (KeyValuePair<Oid, AsnType> kvp in result) {
                Console.WriteLine("{0}: {1} {2}", kvp.Key.ToString(),
                    SnmpConstants.GetTypeName(kvp.Value.Type),
                    kvp.Value.ToString());
                rsltStrings[i] = kvp.Value.ToString();
                i++;
            }
            return rsltStrings;
        }

        private static VbCollection VbCol(String str, String oid, uint time)
        {
            VbCollection col = new VbCollection();
            col.Add(new Oid("1.3.6.1.2.1.1.1.0"), new OctetString(str));
            col.Add(new Oid("1.3.6.1.2.1.1.2.0"), new Oid(oid));
            col.Add(new Oid("1.3.6.1.2.1.1.3.0"), new TimeTicks(2324));
            return col;
        }

        public static void Trap(TrapAgent agent, String receiverIP, int port, String community, String oid, String senderIP,
            int generic, int specific, uint senderUpTime, VbCollection col)
        {
            agent.SendV1Trap(new IpAddress(receiverIP), port, community,
                             new Oid(oid), new IpAddress(senderIP),
                             generic, specific, senderUpTime, col);
        }
    }
}