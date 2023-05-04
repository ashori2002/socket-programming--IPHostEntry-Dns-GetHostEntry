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
            IPHostEntry HE = Dns.GetHostEntry("127.0.0.1");

        }
    }
}
