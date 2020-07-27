using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        [DllImport("user32.dll")]
        static extern int MessageBeep(uint uType);

        static int TestMethod(uint type)
        {
            return 0;
        }

        static void Main(string[] args)
        {
            int iNum = 100;
            unsafe //안전하지 않다는 것을 알고있다고 알려주기 위함 //프로젝트-속성-안전하지않은 코드 속성 사용
            {
                Console.WriteLine("{0:X}", (int)&iNum);
            }
            MessageBeep(0);
        }
    }
    
}
