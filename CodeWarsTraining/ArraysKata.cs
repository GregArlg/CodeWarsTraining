namespace Solution
{
    public class ArraysKata
    {
        public static int[] InvertValues(int[] input)
        {
            //Code it!
            return input.Select(x => -x).ToArray();
        }

        public static double FindAverage(double[] array)
        {
            //if (array.Length > 0)
            //{
            //    double sum = 0;

            //    foreach (double item in array)
            //    {
            //        sum += item;
            //    }

            //    return sum / array.Length; 
            //}
            //else { return 0; }

            return array.Average();
        }

        public static double SumArray(double[] array)
        {
            return array.Sum();
        }

        public static int SquareSum(int[] numbers)
        {
            return numbers.Sum(x => x * x);
        }

        public static int[] CountBy(int x, int n)
        {
            //int[] z = new int[n];

            //for (int i = 1; i <= n; i++)
            //{
            //    z[i - 1] = i * x;
            //}

            //return z;

            //SOLUTION
            return Enumerable.Range(1, n).Select(i => i * x).ToArray();
        }

        public static int[] ReverseSeq(int n)
        {
            return Enumerable.Range(1, n - 1).Reverse().ToArray();
        }

        public static string OddOrEven(int[] array)
        {
            return array.Sum() % 2 == 0 ? "even" : "odd";
        }

        public static int FindSmallestInt(int[] args)
        {
            return args.Min();
        }

        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            return names.Where(n => n.Length == 4);
        }

        public static int Find(int[] integers)
        {
            //int isEven1 = integers[0] % 2 == 0 ? 1 : 0;
            //int isEven2 = integers[1] % 2 == 0 ? 1 : 0;
            //int isEven3 = integers[2] % 2 == 0 ? 1 : 0;

            //bool isArrayEven = isEven1 + isEven2 + isEven3 > 1;

            //var filtered = integers.Where(x =>
            //{
            //    if (isArrayEven)
            //    {
            //        return x % 2 != 0;
            //    }
            //    else
            //    {
            //        return x % 2 == 0;
            //    }
            //});

            //return filtered.First();

            //SOLUTION
            var evenNumbers = integers.Where(integer => integer % 2 == 0);
            var oddNumbers = integers.Where(integer => integer % 2 == 1);
            return evenNumbers.Count() == 1 ? evenNumbers.First() : oddNumbers.First();
        }

        public static int find_it(int[] seq)
        {
            return seq.Where(n => seq.Count(i => i == n) % 2 != 0).First();
        }

        public static string Likes(string[] name)
        {
            switch (name.Length)
            {
                case 0:
                    return "no one likes this";
                case 1:
                    return $"{name[0]} likes this";
                case 2:
                    return $"{name[0]} and {name[1]} like this";
                case 3:
                    return $"{name[0]}, {name[1]} and {name[2]} like this";
                default:
                    return $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
            }

        }
    }
}
