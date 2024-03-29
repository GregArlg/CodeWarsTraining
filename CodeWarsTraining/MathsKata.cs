using System;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace Solution
{
    public static class MathsKata
    {
        public static int DescendingOrder(int num)
        {
            return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
        }

        public static long[] Digitize(long n)
        {
            ////convert long to string
            //var sn = n.ToString();
            ////convert string to array of char
            //char[] asn = sn.ToCharArray();

            ////browse char array,
            ////convert each char in int and place it at the end of long array
            //long[] reverse_an = new long[asn.Length];
            //for (int i = 0; i < asn.Length; i++)
            //{
            //    long numberToPlace = (long)char.GetNumericValue(asn[i]);

            //    reverse_an[asn.Length - 1 - i] = numberToPlace;
            //}

            //return reverse_an;

            //SOLUTION
            return n.ToString()
                .Reverse()
                .Select(Convert.ToInt64)
                .ToArray();
        }

        /*
     Given the triangle of consecutive odd numbers:

                     1
                  3     5
               7     9    11
           13    15    17    19
        21    23    25    27    29

    Calculate the sum of the numbers in the nth row of this triangle (starting at index 1)
     */
        public static long RowSumOddNumbers(long n)
        {
            //int valuePosition = Enumerable.Range(1, (int)n - 1).Sum();

            //long firstOddOfRow = valuePosition * 2 + 1;

            //long res = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    res += firstOddOfRow + 2 * i;
            //}

            //return res;

            //SOLUTION

            return (long)Math.Pow(n, 3);
        }

        public static bool IsTriangle(int a, int b, int c)
        {
            return Math.Min(a, b) + Math.Min(b, c) > Math.Max(a, Math.Max(b, c));
        }

        public static int СenturyFromYear(int year)
        {
            return (int)Math.Ceiling(year / 100d);
        }

        public static bool IsSquare(int n)
        {
            return Math.Sqrt(n) % 1 == 0;
        }

        public static int GetSum(int a, int b)
        {
            return Enumerable.Range(Math.Min(a, b), Math.Abs(a - b) + 1).Sum();
        }

        public static string AddBinary(int a, int b)
        {
            return Convert.ToString(a + b, 2);
        }

        public static string GetReadableTime(int seconds)
        {
            //DateTime date = DateTime.MinValue.AddSeconds(seconds);
            //string totalHours = (date.Hour + (date.Day - 1) * 24).ToString().PadRight(2, '0');

            //return date.ToLongTimeString().Remove(0, 2).Insert(0, totalHours);

            //SOLUTION
            var t = TimeSpan.FromSeconds(seconds);
            return string.Format("{0:00}:{1:00}:{2:00}", (int)t.TotalHours, t.Minutes, t.Seconds);
        }

        public static double[] Tribonacci(double[] signature, int n)
        {
            if (n == 0)
            {
                return new double[0];
            }
            if (n <= 3)
            {
                return signature[..^(3 - n)];
            }
            else
            {
                double[] result = new double[n];
                signature.CopyTo(result, 0);

                for (int i = 3; i < n; i++)
                {
                    result[i] = result[(i - 3)..].Sum();
                }

                return result;
            }
        }

        public static int Solution(int value)
        {
            return value < 0 ?
                0 :
                Enumerable.Range(1, value - 1).Where(n => n % 3 == 0 || n % 5 == 0).Sum();
        }

        public static int NbYear(int p0, double percent, int aug, int p)
        {
            int year = 0;
            int currentNb = p0;
            while (currentNb < p)
            {
                currentNb += (int)Math.Floor(currentNb * percent * 0.01 + aug);

                year++;
            }

            return year;
        }

        public static string game(long n)
        {
            return n * n % 2 == 0 ? $"[{n * n / 2}]" : $"[{n * n}, 2]";
        }
    }
}