using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RomanNumerals.App.Roman;

namespace RomanNumberalsTests.cs
{
    [TestFixture]
    public class NumberTests
    {
       
        [Test]
        public void Convert_number_one_to_roman_numerals()
        {
            var number = "1";
            var converter = new RomanConverter();

            var results = converter.ConvertToRomanNumeral(number);

            var expected = "I";

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_number_five_to_numerals()
        {
            var number = "5";
            var converter = new RomanConverter();

            var results = converter.ConvertToRomanNumeral(number);

            var expected = "V";

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_number_three_to_numerals()
        {
            var number = "3";
            var converter = new RomanConverter();

            var results = converter.ConvertToRomanNumeral(number);

            var expected = "III";

            Assert.AreEqual(expected, results);
        }


        [Test]
        public void Convert_number_nine_to_numerals()
        {
            var number = "9";
            var converter = new RomanConverter();

            var results = converter.ConvertToRomanNumeral(number);

            var expected = "IX";

            Assert.AreEqual(expected, results);
        }

    }
}
