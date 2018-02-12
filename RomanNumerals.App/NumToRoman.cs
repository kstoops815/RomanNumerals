using System;

namespace RomanNumerals.App
{
    public class NumToRoman
    {
        string result;
        public string Convert(int number)
        {
            if ((number < 0) || (number > 3999))
            {
                throw new ArgumentOutOfRangeException("Value must be between 1 and 3999");
            }
            if (number < 1)
            {
                result = string.Empty;
            }
            if (number >= 1)
            {
                result = "I" + Convert(number - 1);
            }
            if (number == 4)
            {
                result = "IV" + Convert(number - 4);
            }
            if (number == 5)
            {
                result = "V" + Convert(number - 5);
            }
            if (number > 5)
            {
                result = "V" + Convert(number - 1);
            }
            if (number >= 10)
            {
                result = "X" + Convert(number - 10);
            }
            if (number >= 40)
            {
                result = "XL" + Convert(number - 40);
            }
            if (number >= 50)
            {
                result = "L" + Convert(number - 50);
            }
            if (number >= 90)
            {
                result = "XC" + Convert(number - 90);
            }
            if (number >= 100)
            {
                result = "C" + Convert(number - 100);
            }
            if (number >= 400)
            {
                result = "CD" + Convert(number - 400);
            }
            if (number >= 500)
            {
                result = "D" + Convert(number - 500);
            }
            if (number >= 900)
            {
                result = "CM" + Convert(number - 900);
            }
            if (number >= 1000)
            {
                result = "M" + Convert(number - 1000);
            }

            throw new ArgumentOutOfRangeException("Value must be between 1 and 3999");

            //{
            //    if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException("Value must be between 1 and 3999");
            //    if (number < 1) return string.Empty;
            //    if (number >= 1000) return "M" + Convert(number - 1000);
            //    if (number >= 900) return "CM" + Convert(number - 900); //EDIT: i've typed 400 instead 900
            //    if (number >= 500) return "D" + Convert(number - 500);
            //    if (number >= 400) return "CD" + Convert(number - 400);
            //    if (number >= 100) return "C" + Convert(number - 100);
            //    if (number >= 90) return "XC" + Convert(number - 90);
            //    if (number >= 50) return "L" + Convert(number - 50);
            //    if (number >= 40) return "XL" + Convert(number - 40);
            //    if (number >= 10) return "X" + Convert(number - 10);
            //    if (number >= 9) return "IX" + Convert(number - 9);
            //    if (number >= 5) return "V" + Convert(number - 5);
            //    if (number >= 4) return "IV" + Convert(number - 4);
            //    if (number >= 1) return "I" + Convert(number - 1);
            //    throw new ArgumentOutOfRangeException("Value must be between 1 and 3999");
            //}

            //return result;
        }
    }
}