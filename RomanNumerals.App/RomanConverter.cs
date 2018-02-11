using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals.App.Roman
{
    public class RomanConverter
    {
        public string ConvertToRomanNumeral(string input)
        {
            int number = Convert.ToInt32(input);
            var numberTable = new Dictionary<int, string>()
            {
                {1, "I"},
                {4, "IV" },
                {5, "V" },
                {9, "IX"},
                {10, "X" },
                {40, "XL" },
                {50, "100" },
                {100, "C" },
                {400, "CD" },
                {500, "D" },
                {900, "CM" },
                {1000, "M" },
            };

            var descendedDictonary = numberTable.OrderByDescending(x => x.Key);

            var results = "";

            //while (number > 0)
            //{
            //    foreach (var num in descendedDictonary)
            //    {
            //        if (number >= num.Value)
            //        {
            //            results += num.Key;
            //            number -= num.Value;
            //            continue;
            //        }

            //    }
            //}

            foreach(var num in descendedDictonary)
            {
                while (number >= num.Key)
                {
                    results += num.Value;
                    number -= num.Key;
                }
            }

            //Console.WriteLine(results);
            //Console.ReadKey();
            return results;
        }
    }
}
