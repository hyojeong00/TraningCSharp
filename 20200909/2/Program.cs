using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement aXElement = XElement.Load("http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=2623052000");
            //Console.WriteLine(aXElement);
            var XMLData = from Temp in aXElement.Descendants("data") select new weather() 
            {
                Hour=Temp.Element("hour").Value,
                Temp=Temp.Element("temp").Value,
                WfKor= Temp.Element("wfKor").Value,
                WdKor=Temp.Element("wdKor").Value

            };
            foreach (var Temp in XMLData)
            {
                Console.WriteLine(Temp);
            }

        }
    }
}
