﻿using System;
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
            //AgentSNMP snmpAgent = new AgentSNMP();
            //Dictionary<Oid, AsnType> result = snmpAgent.get("1.3.6.1.2.1.1.1.0");
            //foreach (KeyValuePair<Oid, AsnType> kvp in result)
            //{
            //    Debug.WriteLine("{0}: {1} : {2}", kvp.Key.ToString(),
            //        SnmpConstants.GetTypeName(kvp.Value.Type),
            //        kvp.Value.ToString());
            //}
        }

        [TestMethod]
        public void testGetNextMethod()
        {
            //AgentSNMP snmpAgent = new AgentSNMP();
            //Dictionary<Oid, AsnType> result = snmpAgent.getNext("1.3.6.1.2.1.1.1.0");
            //foreach (KeyValuePair<Oid, AsnType> kvp in result)
            //{
            //    Debug.WriteLine("{0}: {1} : {2}", kvp.Key.ToString(),
            //        SnmpConstants.GetTypeName(kvp.Value.Type),
            //        kvp.Value.ToString());
            //}
        }

        [TestMethod]
        public void sendTrapTest() {
            String receiverIP = "127.0.0.1";
            int port = 162;
            String community = "public";
            String oid = "1.3.6.1.2.1.1.1.0";
            String senderIP = receiverIP;
            int generic = SnmpConstants.LinkUp;
            //coldStart trap(0) warmStart trap(1) linkDown trap(2) linkUp trap(3) authenticationFailure trap(4) egpNeighborLoss trap(5)
            int specific = 0; //dla generic 0-5
            uint senderUpTime = 12345;

            TrapAgent agent = new TrapAgent();

            VbCollection col = AgentSNMP.VbCol("gowno", "1.3.6.1.9.1.1.0", 1234);

            AgentSNMP.Trap(agent, receiverIP, port, community, oid, senderIP, generic, specific, senderUpTime, col);
        }
    }
}