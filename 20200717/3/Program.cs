namespace PropertySample1
{
    using System;
    using System.Runtime.InteropServices;

    public class PropertyTest
    {
        private int _ReadOnly; //읽기전용 프로퍼티 - get만 만들고 set X
        private string _name;
        private int _WriteOnly;//쓰기 전용 프로퍼티
        private static int _Static; //스태틱인데 덮어씀

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int ReadOnly
        {
            get { return _ReadOnly; }
        }

        public int WriteOnly
        {
            set { _WriteOnly = value; }
        }

        static public int Static
        {
            get { return _Static; }
            set { _Static = value; }
        }
    }

    public class Test
    {
        public static void Main(string[] args)
        {
            PropertyTest pt = new PropertyTest();
            pt.Name = "헬로 키티";
            Console.WriteLine(pt.Name);
            Console.WriteLine(pt.ReadOnly);
            //pt.ReadOnly = 100;  읽기전용이라서 오류
            //Console.WriteLine(pt.WriteOnly);  쓰기 전용이라서 오류
            PropertyTest.Static = 200;
            Console.WriteLine(PropertyTest.Static);
    
        
        }
    }
}