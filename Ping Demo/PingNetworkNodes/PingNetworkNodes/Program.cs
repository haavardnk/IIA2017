using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.NetworkInformation;

namespace PingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string host, data;
            byte[] buffer;
            int timeout;

            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();
            // Setting ttl value to 128
            options.Ttl = 128;
            // Setting fragmentation behaviour
            options.DontFragment = true;

            // Create a buffer of 32 bytes of data to be transmitted.
            data = "PingPongFromBergenNorwayPingPong";
            buffer = Encoding.ASCII.GetBytes(data);
            timeout = 120;
            // List to add all responding nodes
            List<int> nodeList = new List<int>();

            for (int i = 0; i < 256; i++)
            {
                host = "192.168.1." + i.ToString();

                Console.Clear(); //Clears console
                Console.WriteLine(" Pinging: {0}", host);

                PingReply reply = pingSender.Send(host, timeout, buffer, options);

                if (reply.Status == IPStatus.Success)
                {
                    nodeList.Add(i);
                }
            }
            Console.Clear();
            Console.WriteLine(" Ping replies from:");
            for (int i = 0; i < nodeList.Count(); i++)
            {
                Console.WriteLine(" 192.168.1.{0}", nodeList[i]);
            }
            Console.WriteLine(" Number of nodes in network: {0}", nodeList.Count());
  
            Console.WriteLine(" Press CR or Enter to Quit the application");
            Console.ReadLine();
        }
    }
}