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
                {50, "L" },
                {90, "XC" },
                {100, "C" },
                {400, "CD" },
                {500, "D" },
                {900, "CM" },
                {1000, "M" },
            };

            var descendedDictonary = numberTable.OrderByDescending(x => x.Key);

            var results = "";
           
            if (number != 0)
            {
                foreach (var num in descendedDictonary)
                {
                    while (number >= num.Key)
                    {
                        results += num.Value;
                        number -= num.Key;
                    }
                } 
            }
            else
            {
                throw new Exception("Number cannot be zero.");
            }

            return results;
        }
    }
}
