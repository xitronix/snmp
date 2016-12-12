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
        private SimpleSnmp snmp;

        public AgentSNMP() {
            string host = "localhost";
            string community = "public";
            snmp = new SimpleSnmp(host, community);
        }

        public Dictionary<Oid, AsnType> getNext(string oid) {
            Dictionary<Oid, AsnType> result = snmp.GetNext(SnmpVersion.Ver1, new string[] {"1.3.6.1.2.1.1"});
            if (result == null) {
                Console.WriteLine("Request failed.");
                return null;
            }
            else {
                return result;
            }
        }

        public Dictionary<Oid, AsnType> get(string oid) {
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

        private string[] readGetResult(Dictionary<Oid, AsnType> result) {
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
    }
}