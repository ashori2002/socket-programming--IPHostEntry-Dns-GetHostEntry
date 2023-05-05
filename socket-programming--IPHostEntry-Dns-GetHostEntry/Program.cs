using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace socket_programming__IPHostEntry_Dns_GetHostEntry
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DoGetHostEntry("sanjesh.org");
            Console.ReadKey();

        }

        public static void DoGetHostEntry(string hostname)
        {


            IPHostEntry host = Dns.GetHostEntry(hostname);

            Console.WriteLine($"GetHostEntry({hostname}) returns:");

            foreach (IPAddress address in host.AddressList)
            {
                Console.WriteLine($"    {address}");
            }


        }
    }
}
