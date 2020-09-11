using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement aXElement = XElement.Load("http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=2623052000");
            //Console.WriteLine(aXElement);
            var XMLData = from Temp in aXElement.Descendants("data") select Temp;
            foreach (var Temp in XMLData)
            {
                Console.WriteLine(Temp.Element("hour").Value + "시\t");
                Console.WriteLine(Temp.Element("temp").Value + "°C\t");
                Console.WriteLine();
            }

        }
    }
}
