using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateConcepts
{
    internal class Student
    {
        public string? Name;
        public double[]? Notes = [0, 0, 0];
        public double Media;

        public double FinalMedia()
        {
            Media = (Notes![0] + Notes![1] + Notes![2]);
            return Media;
        }

        public string StudentResult()
        {
            if (Media > 60) return "Approved";
            else return "Disapproved\n" + (60 - Media).ToString("F2", CultureInfo.InvariantCulture) + " points missing.";
        }
    }
}
