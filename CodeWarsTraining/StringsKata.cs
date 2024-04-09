using System.Globalization;

namespace Solution
{
    public static class StringsKata
    {
        public static string AbbrevName(string name)
        {
            return string.Concat(name.ToUpper().Split(' ').Select(s => s.First())).Insert(1, ".");
        }
        public static string RepeatStr(int n, string s)
        {
            //string sol = string.Empty;

            //for (int i = 0; i < n; i++)
            //{
            //    sol += s;
            //}

            //return sol;

            //SOLUTION
            return String.Concat(Enumerable.Repeat(s, n));
        }

        public static bool IsIsogram(string str)
        {
            // Code on you crazy diamond!
            //str = str.ToLower();
            //return string.Concat(str.Distinct()) == str;

            //SOLUTION
            return str.ToLower().Distinct().Count() == str.Length;
        }

        public static bool XO(string input)
        {
            input = input.ToLower();
            return input.Count(s => s == 'o') == input.Count(s => s == 'x');
        }

        public static string[] Solution(string str)
        {
            //if (str.Length % 2 != 0) str += "_";

            //string[] res = new string[str.Length / 2];
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        res[i/2] = str.Substring(i - 1, 2);
            //    }
            //}

            //return res;

            //SOLUTION
            if (str.Length % 2 != 0)
                str += "_";

            return Enumerable.Range(0, str.Length)
              .Where(x => x % 2 == 0)
              .Select(x => str.Substring(x, 2))
              .ToArray();
        }

        public static string AlphabetPosition(string text)
        {
            //if (!string.IsNullOrEmpty(text))
            //{
            //    //select letters only and then
            //    //use ascii table to get int equivalent
            //    string pos = string.Concat(
            //        text.Where(c => char.ToUpper(c) > 64 && char.ToUpper(c) < 91)
            //            .Select(c => (char.ToUpper(c) - 64).ToString() + " ")
            //    );

            //    return pos.Length > 0 ? pos[..^1] : pos;
            //}

            //return text;

            //SOLUTION
            return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a' + 1));
        }

        public static int GetVowelCount(string str)
        {
            return str.Count("aeiou".Contains);
        }

        public static string ToJadenCase(this string phrase)
        {
            return string.Join(" ", phrase.ToLower().Split(' ').Select(s => char.ToUpper(s[0]) + s.Substring(1)));

            //OR
            //return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
        }

        public static string SpinWords(string sentence)
        {
            return string.Join(" ", sentence.Split(' ').Select(s => s.Length > 4 ? string.Concat(s.Reverse()) : s));
        }

        public static string DuplicateEncode(string word)
        {
            word = word.ToLower();
            return string.Concat(word.Select(c => word.Count(x => x == c) > 1 ? ')' : '('));
        }

        public static string HighAndLow(string numbers)
        {
            var array = numbers.Split(' ').Select(int.Parse);
            return array.Max() + " " + array.Min();
        }
    }
}
