using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnmpSharpNet;
using SNMP_agent;


namespace SnmpUnitTest
{
    [TestClass]
    public class SnmpUnitTest
    {
        [TestMethod]
        public void testGetMethod()
        {
            AgentSNMP snmpAgent = new AgentSNMP();
            Dictionary<Oid, AsnType> result = snmpAgent.get("1.3.6.1.2.1.1.1.0");
            foreach (KeyValuePair<Oid, AsnType> kvp in result)
            {
                Debug.WriteLine("{0}: {1} : {2}", kvp.Key.ToString(),
                    SnmpConstants.GetTypeName(kvp.Value.Type),
                    kvp.Value.ToString());
            }
        }

        [TestMethod]
        public void testGetNextMethod()
        {
            AgentSNMP snmpAgent = new AgentSNMP();
            Dictionary<Oid, AsnType> result = snmpAgent.getNext("1.3.6.1.2.1.1.1.0");
            foreach (KeyValuePair<Oid, AsnType> kvp in result)
            {
                Debug.WriteLine("{0}: {1} : {2}", kvp.Key.ToString(),
                    SnmpConstants.GetTypeName(kvp.Value.Type),
                    kvp.Value.ToString());
            }
        }
    }
}