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
            waitForConnection();
        }

        public void waitForConnection()
        {
            UdpClient udpServer = new UdpClient(11000);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 11000);

            while (true)
            {
                var receive = udpServer.Receive(ref endPoint);
                Console.WriteLine("Received value is: " + Encoding.ASCII.GetString(receive));

                string value = snmp.get(Encoding.ASCII.GetString(receive))[2];
                Console.WriteLine("Sending vlaue: " + value);

                var client = new UdpClient();
                endPoint = new IPEndPoint(IPAddress.Parse("172.25.247.137"), 11001); 
                client.Connect(endPoint);

                byte[] msg = Encoding.ASCII.GetBytes(value);
                int size = Encoding.ASCII.GetByteCount(value);
                client.Send(msg, size);
            }
        }
    }
}
