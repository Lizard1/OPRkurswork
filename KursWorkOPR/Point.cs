using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursWorkOPR
{
    [DebuggerDisplay("x={X1NodeNumber}, y={X2NodeNumber}, node={NodeNumber}")]
    class Point
    {
        public double X1 = 0;
        public double X2 = 0;
        public int X1NodeNumber = 0;
        public int X2NodeNumber = 0;
        public int NodeNumber = 0;
        public string X1X2Bin = "";
        public int Generation { get; set; }
    }
}
