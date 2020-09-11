using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crypto
{
    class Program
    {
        static void Main(string[] args)
        {
            string PlainText = "할룽";
            char[] PlainTextArray = PlainText.ToCharArray();
            char[] CyperTextArray;
            char key = (char)0x0908;

            CyperTextArray = new char[PlainTextArray.Length];
            CyperTextArray[0] = (char)(PlainTextArray[0] ^ key);
            CyperTextArray[1] = (char)(PlainTextArray[1] ^ key);

            Console.WriteLine("PlainText : {0}", PlainText);
            Console.WriteLine("CyperText : {0}{1}", CyperTextArray[0],CyperTextArray[1]);

            char[] PlainTextArray2 = new char[CyperTextArray.Length];
            PlainTextArray2[0] = (char)(CyperTextArray[0] ^ key);
            PlainTextArray2[1] = (char)(CyperTextArray[1] ^ key);

            Console.WriteLine("PlainText2 : {0}{1}", PlainTextArray2[0], PlainTextArray2[1]);
        }
    }
}
