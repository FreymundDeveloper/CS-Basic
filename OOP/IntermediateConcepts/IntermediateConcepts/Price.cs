using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateConcepts
{
    internal class Price
    {
        public static double Tax = 6.0;
        
        public static double ConversionProcess(double price, double value)
        {
            double conversion = price * value;
            return conversion + conversion * (Tax / 100);
        }
    }
}
