using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class weather
    {
        public string Hour { get; set; }
        public string Temp { get; set; }
        public string WfKor { get; set; }
        public string WdKor { get; set; }

        public override string ToString()
        {
            return string.Format($"{Hour}시\t{Temp}°C\t{WfKor}\t{WdKor}풍");
        }
    }
}
