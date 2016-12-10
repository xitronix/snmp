using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnmpSharpNet;

namespace SNMP_agent
{
    class AgentSNMP
    {        
        //public void Metoda()
        //{
        //    string host = "localhost";
        //    string community = "public";
        //    SimpleSnmp snmp = new SimpleSnmp(host, community);

        //    if (!snmp.Valid)
        //    {
        //        Console.WriteLine("SNMP agent host name/ip address is invalid.");
        //        return;
        //    }
        //    Dictionary<Oid, AsnType> result = snmp.Get(SnmpVersion.Ver1,
        //                                              new string[] { ".1.3.6.1.2.1.1.1" });
        //    if (result == null)
        //    {
        //        Console.WriteLine("No results received.");
        //        return;
        //    }

        //    foreach (KeyValuePair kvp in result)
        //    {
        //        Console.WriteLine("{0}: {1} {2}", kvp.Key.ToString(),
        //                              SnmpConstants.GetTypeName(kvp.Value.Type),
        //                              kvp.Value.ToString());
        //    }
        //}
    }
}
