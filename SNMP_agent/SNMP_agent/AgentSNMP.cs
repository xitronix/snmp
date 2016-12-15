using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using SnmpSharpNet;

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
    }
}