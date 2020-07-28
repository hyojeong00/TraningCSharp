using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {

       
        static void Main(string[] args)
        {
            IPAddress ipAddr1 = IPAddress.Parse("192.168.0.156");
            IPEndPoint endpoint = new IPEndPoint(ipAddr1, 9000);

            IPHostEntry entry = Dns.GetHostEntry("www.google.com");
            foreach(IPAddress ipAddress in entry.AddressList)
                {
                Console.WriteLine(ipAddress);
                }

            string myComputer = Dns.GetHostName();

            Console.WriteLine("컴퓨터 이름 : " + myComputer);

            IPHostEntry entry1 = Dns.GetHostEntry(myComputer);
            foreach(IPAddress ipAddress1 in entry1.AddressList)
            {
                Console.WriteLine(ipAddress1.AddressFamily + ": " + ipAddress1);
            }

        }
    }
}
