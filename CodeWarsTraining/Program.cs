using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

namespace Solution
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //StringsKata.IsIsogram("Dermatoglyphics");
            //var r = StringsKata.Solution("Dermatoglyphics");
            //StringsKata.AlphabetPosition("The sunset sets at twelve o' clock.");

            //MathsKata.GetSum(-1, 1);
            //MathsKata.GetReadableTime(59);
            MathsKata.Tribonacci([0d, 0d, 1d], 8);

            //ArraysKata.Find(new int[] { 2, 4, 0, 100, 4, 11, 2602, 36 });
        }
    }
}