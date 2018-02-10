using NUnit.Framework;
using RomanNumerals.App;

namespace RomanNumerals.Tests
{
    [TestFixture]
    public class NumberConverterTests
    {
        [Test]
        public void Entering_the_number_one_returns_the_roman_numeral_equivalent()
        {
            //Arrange
            var number = 1;
            var numToRoman = new NumToRoman();

            //Act
            var result = numToRoman.Convert(number);

            //Assert
            Assert.AreEqual("I", result);
        }

        [Test]
        public void Entering_the_number_two_returns_the_roman_numeral_equivalent()
        {
            //Arrange
            var number = 2;
            var numToRoman = new NumToRoman();

            //Act
            var result = numToRoman.Convert(number);

            //Assert
            Assert.AreEqual("II", result);
        }

        [Test]
        public void Entering_the_number_three_returns_the_roman_numeral_equivalent()
        {
            //Arrange
            var number = 3;
            var numToRoman = new NumToRoman();

            //Act
            var result = numToRoman.Convert(number);

            //Assert
            Assert.AreEqual("III", result);
        }
        [Test]
        public void Entering_the_number_five_returns_the_roman_numeral_equivalent()
        {
            //Arrange
            var number = 5;
            var numToRoman = new NumToRoman();

            //Act
            var result = numToRoman.Convert(number);

            //Assert
            Assert.AreEqual("V", result);
        }
        [Test]
        public void Entering_the_number_four_returns_the_roman_numeral_equivalent()
        {
            //Arrange
            var number = 4;
            var numToRoman = new NumToRoman();

            //Act
            var result = numToRoman.Convert(number);

            //Assert
            Assert.AreEqual("IV", result);
        }
        [Test]
        public void Entering_the_number_eight_returns_the_roman_numeral_equivalent()
        {
            //Arrange
            var number = 8;
            var numToRoman = new NumToRoman();

            //Act
            var result = numToRoman.Convert(number);

            //Assert
            Assert.AreEqual("VIII", result);
        }
    }
}
