using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerSNMP
{
    class Server
    {
        snmp snmp;
        public Server()
        {
            snmp = new snmp();
            UdpClient udpServer = new UdpClient(11000);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 11000);

            while (true)
            {
                var receive = udpServer.Receive(ref endPoint);

                //pod receive bedzie oid i ma przemielic na value, ktore zwroci getSnmp
                Console.WriteLine("Received value is: " + Encoding.ASCII.GetString(receive));
                string value;
                try
                {                    
                   value = snmp.get(Encoding.ASCII.GetString(receive))[2];
                }
                catch (Exception)
                {

                }

                Console.WriteLine("Sending vlaue: " + value);

                var client = new UdpClient();
                endPoint = new IPEndPoint(IPAddress.Parse("10.78.19.141"), 11001); // endpoint where server is listening (testing localy)
                client.Connect(endPoint);

                byte[] msg = Encoding.ASCII.GetBytes(value);
                int size = Encoding.ASCII.GetByteCount(value);
                client.Send(msg, size);
                // Thread.Sleep(10000);
            }
        }
    }
}
