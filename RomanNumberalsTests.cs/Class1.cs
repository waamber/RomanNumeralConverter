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

        [Test]
        public void Convert_number_twelve_to_numerals()
        {
            var number = "12";
            var converter = new RomanConverter();

            var results = converter.ConvertToRomanNumeral(number);

            var expected = "XII";

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_number_sixteen_to_numerals()
        {
            var number = "16";
            var converter = new RomanConverter();

            var results = converter.ConvertToRomanNumeral(number);

            var expected = "XVI";

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_number_twentynine_to_numerals()
        {
            var number = "29";
            var converter = new RomanConverter();

            var results = converter.ConvertToRomanNumeral(number);

            var expected = "XXIX";

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_number_fourtyfourt_to_numerals()
        {
            var number = "44";
            var converter = new RomanConverter();

            var results = converter.ConvertToRomanNumeral(number);

            var expected = "XLIV";

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_number_fourtyfive_to_numerals()
        {
            var number = "45";
            var converter = new RomanConverter();

            var results = converter.ConvertToRomanNumeral(number);

            var expected = "XLV";

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_number_sixtyeight_to_numerals()
        {
            var number = "68";
            var converter = new RomanConverter();

            var results = converter.ConvertToRomanNumeral(number);

            var expected = "LXVIII";

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_number_eightythree_to_numerals()
        {
            var number = "83";
            var converter = new RomanConverter();

            var results = converter.ConvertToRomanNumeral(number);

            var expected = "LXXXIII";

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_number_ninetyseven_to_numerals()
        {
            var number = "97";
            var converter = new RomanConverter();

            var results = converter.ConvertToRomanNumeral(number);

            var expected = "XCVII";

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_number_ninetynine_to_numerals()
        {
            var number = "99";
            var converter = new RomanConverter();

            var results = converter.ConvertToRomanNumeral(number);

            var expected = "XCIX";

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_number_fivehundred_to_numerals()
        {
            var number = "500";
            var converter = new RomanConverter();

            var results = converter.ConvertToRomanNumeral(number);

            var expected = "D";

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_number_fivehundredone_to_numerals()
        {
            var number = "501";
            var converter = new RomanConverter();

            var results = converter.ConvertToRomanNumeral(number);

            var expected = "DI";

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_number_sixhundredfourtynine_to_numerals()
        {
            var number = "649";
            var converter = new RomanConverter();

            var results = converter.ConvertToRomanNumeral(number);

            var expected = "DCXLIX";

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_number_sevenhundredninetyeight_to_numerals()
        {
            var number = "798";
            var converter = new RomanConverter();

            var results = converter.ConvertToRomanNumeral(number);

            var expected = "DCCXCVIII";

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_number_eighthundredninetyone_to_numerals()
        {
            var number = "891";
            var converter = new RomanConverter();

            var results = converter.ConvertToRomanNumeral(number);

            var expected = "DCCCXCI";

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_number_onethousand_to_numerals()
        {
            var number = "1000";
            var converter = new RomanConverter();

            var results = converter.ConvertToRomanNumeral(number);

            var expected = "M";

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_number_onethousandfour_to_numerals()
        {
            var number = "1004";
            var converter = new RomanConverter();

            var results = converter.ConvertToRomanNumeral(number);

            var expected = "MIV";

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_number_onethousandsix_to_numerals()
        {
            var number = "1006";
            var converter = new RomanConverter();

            var results = converter.ConvertToRomanNumeral(number);

            var expected = "MVI";

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_number_onethousandtwentythree_to_numerals()
        {
            var number = "1023";
            var converter = new RomanConverter();

            var results = converter.ConvertToRomanNumeral(number);

            var expected = "MXXIII";

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_number_twothousandfourteen_to_numerals()
        {
            var number = "2014";
            var converter = new RomanConverter();

            var results = converter.ConvertToRomanNumeral(number);

            var expected = "MMXIV";

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_number_threethousandninetynine_to_numerals()
        {
            var number = "3999";
            var converter = new RomanConverter();

            var results = converter.ConvertToRomanNumeral(number);

            var expected = "MMMCMXCIX";

            Assert.AreEqual(expected, results);
        }

        //test for not a nummber
        [Test]
        public void When_user_inputs_something_that_is_not_a_number()
        {
            var number = "dog";
            var converter = new RomanConverter();

            var results = converter.ConvertToRomanNumeral(number);

            var expected = "IX";

            Assert.AreEqual(expected, results);
        }

        //test for input that 0
        [Test]
        public void When_user_inputs_zero()
        {
            var number = "0";
            var converter = new RomanConverter();
            var error = new System.Exception("Number cannot be zero.");
            var results = converter.ConvertToRomanNumeral(number);

            if (number != "0")
            {
                converter.ConvertToRomanNumeral(number);
            }
            else
            {
                throw error;
            }
            
            var expected = error;

            Assert.AreEqual(expected, results);
        }
    }
}
