namespace RomanNumerals.App
{
    public class NumToRoman
    {
        string result;
        public string Convert(int number)
        {
            if(number >= 1)
            {
                result =  "I" + Convert(number - 1);
            }
            if(number == 4)
            {
                result = "IV";
            }
            if(number == 5)
            {
                result = "V";
            }
            if(number > 5)
            {
                result = "V" + Convert(number - 1);
            }
            return result;
        }
    }
}