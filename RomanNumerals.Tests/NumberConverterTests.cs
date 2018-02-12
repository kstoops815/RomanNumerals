using NUnit.Framework;
using RomanNumerals.App;

namespace RomanNumerals.Tests
{
    [TestFixture]
    public class NumberConverterTests
    {
        [Test]
        public void Entering_the_number_1_returns_the_roman_numeral_equivalent()
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
        public void Entering_the_number_5_returns_the_roman_numeral_equivalent()
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
        public void Entering_the_number_9_returns_the_roman_numeral_equivalent()
        {
            //Arrange
            var number = 9;
            var numToRoman = new NumToRoman();

            //Act
            var result = numToRoman.Convert(number);

            //Assert
            Assert.AreEqual("IX", result);
        }
        [Test]
        public void Entering_the_number_12_returns_the_roman_numeral_equivalent()
        {
            //Arrange
            var number = 12;
            var numToRoman = new NumToRoman();

            //Act
            var result = numToRoman.Convert(number);

            //Assert
            Assert.AreEqual("XII", result);
        }
        [Test]
        public void Entering_the_number_16_returns_the_roman_numeral_equivalent()
        {
            //Arrange
            var number = 16;
            var numToRoman = new NumToRoman();

            //Act
            var result = numToRoman.Convert(number);

            //Assert
            Assert.AreEqual("XVI", result);
        }
        [Test]
        public void Entering_the_number_29_returns_the_roman_numeral_equivalent()
        {
            //Arrange
            var number = 29;
            var numToRoman = new NumToRoman();

            //Act
            var result = numToRoman.Convert(number);

            //Assert
            Assert.AreEqual("XXIX", result);
        }
        [Test]
        public void Entering_the_number_44_returns_the_roman_numeral_equivalent()
        {
            //Arrange
            var number = 44;
            var numToRoman = new NumToRoman();

            //Act
            var result = numToRoman.Convert(number);

            //Assert
            Assert.AreEqual("XLIV", result);
        }
        [Test]
        public void Entering_the_number_45_returns_the_roman_numeral_equivalent()
        {
            //Arrange
            var number = 45;
            var numToRoman = new NumToRoman();

            //Act
            var result = numToRoman.Convert(number);

            //Assert
            Assert.AreEqual("XLV", result);
        }
        [Test]
        public void Entering_the_number_68_returns_the_roman_numeral_equivalent()
        {
            //Arrange
            var number = 68;
            var numToRoman = new NumToRoman();

            //Act
            var result = numToRoman.Convert(number);

            //Assert
            Assert.AreEqual("LXVIII", result);
        }
        [Test]
        public void Entering_the_number_83_returns_the_roman_numeral_equivalent()
        {
            //Arrange
            var number = 83;
            var numToRoman = new NumToRoman();

            //Act
            var result = numToRoman.Convert(number);

            //Assert
            Assert.AreEqual("LXXXIII", result);
        }
        [Test]
        public void Entering_the_number_97_returns_the_roman_numeral_equivalent()
        {
            //Arrange
            var number = 97;
            var numToRoman = new NumToRoman();

            //Act
            var result = numToRoman.Convert(number);

            //Assert
            Assert.AreEqual("XCVII", result);
        }
        [Test]
        public void Entering_the_number_99_returns_the_roman_numeral_equivalent()
        {
            //Arrange
            var number = 99;
            var numToRoman = new NumToRoman();

            //Act
            var result = numToRoman.Convert(number);

            //Assert
            Assert.AreEqual("XCIX", result);
        }
        [Test]
        public void Entering_the_number_500_returns_the_roman_numeral_equivalent()
        {
            //Arrange
            var number = 500;
            var numToRoman = new NumToRoman();

            //Act
            var result = numToRoman.Convert(number);

            //Assert
            Assert.AreEqual("D", result);
        }
        [Test]
        public void Entering_the_number_501_returns_the_roman_numeral_equivalent()
        {
            //Arrange
            var number = 501;
            var numToRoman = new NumToRoman();

            //Act
            var result = numToRoman.Convert(number);

            //Assert
            Assert.AreEqual("DI", result);
        }
        [Test]
        public void Entering_the_number_649_returns_the_roman_numeral_equivalent()
        {
            //Arrange
            var number = 649;
            var numToRoman = new NumToRoman();

            //Act
            var result = numToRoman.Convert(number);

            //Assert
            Assert.AreEqual("DCXLIX", result);
        }
        [Test]
        public void Entering_the_number_798_returns_the_roman_numeral_equivalent()
        {
            //Arrange
            var number = 798;
            var numToRoman = new NumToRoman();

            //Act
            var result = numToRoman.Convert(number);

            //Assert
            Assert.AreEqual("DCCXCVIII", result);
        }
        [Test]
        public void Entering_the_number_891_returns_the_roman_numeral_equivalent()
        {
            //Arrange
            var number = 891;
            var numToRoman = new NumToRoman();

            //Act
            var result = numToRoman.Convert(number);

            //Assert
            Assert.AreEqual("DCCCXCI", result);
        }
        [Test]
        public void Entering_the_number_1000_returns_the_roman_numeral_equivalent()
        {
            //Arrange
            var number = 1000;
            var numToRoman = new NumToRoman();

            //Act
            var result = numToRoman.Convert(number);

            //Assert
            Assert.AreEqual("M", result);
        }
        [Test]
        public void Entering_the_number_1004_returns_the_roman_numeral_equivalent()
        {
            //Arrange
            var number = 1004;
            var numToRoman = new NumToRoman();

            //Act
            var result = numToRoman.Convert(number);

            //Assert
            Assert.AreEqual("MIV", result);
        }
        [Test]
        public void Entering_the_number_1006_returns_the_roman_numeral_equivalent()
        {
            //Arrange
            var number = 1006;
            var numToRoman = new NumToRoman();

            //Act
            var result = numToRoman.Convert(number);

            //Assert
            Assert.AreEqual("MVI", result);
        }
        [Test]
        public void Entering_the_number_1023_returns_the_roman_numeral_equivalent()
        {
            //Arrange
            var number = 1023;
            var numToRoman = new NumToRoman();

            //Act
            var result = numToRoman.Convert(number);

            //Assert
            Assert.AreEqual("MXXIII", result);
        }
        [Test]
        public void Entering_the_number_2014_returns_the_roman_numeral_equivalent()
        {
            //Arrange
            var number = 2014;
            var numToRoman = new NumToRoman();

            //Act
            var result = numToRoman.Convert(number);

            //Assert
            Assert.AreEqual("MMXIV", result);
        }
        [Test]
        public void Entering_the_number_3999_returns_the_roman_numeral_equivalent()
        {
            //Arrange
            var number = 3999;
            var numToRoman = new NumToRoman();

            //Act
            var result = numToRoman.Convert(number);

            //Assert
            Assert.AreEqual("MMMCMXCIX", result);
        }
    }
}
