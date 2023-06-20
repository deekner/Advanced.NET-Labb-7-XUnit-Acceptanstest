using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.NET_Labb_7_XUnit_Acceptanstest
{
    public class CalculatorHistory
    {
        public string Operation { get; set; }
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int Result { get; set; }

        //Override the ToString() method to provide a custom string representation of the calculation
        public override string ToString()
        {
            return $"{num1} {Operation} {num2} = {Result}";
        }   
    }
}
