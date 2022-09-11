using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    /// <summary>
    /// Class <c>ConverterNumberToRomanNumeral</c>
    /// manage the convertion from numeric to roman numerals.
    /// </summary>
    public class ConverterNumberToRomanNumeral
    {
        private readonly Dictionary<int, Char> map;

        public ConverterNumberToRomanNumeral()
        {
            this.map = new Dictionary<int, Char>();
            this.map.Add(1, 'I');
            this.map.Add(5, 'V');
            this.map.Add(10, 'X');
            this.map.Add(50, 'L');
            this.map.Add(100, 'C');
            this.map.Add(500, 'D');
            this.map.Add(1000, 'M');
        }
        /// <summary>
        /// Method <c>isIntString</c>
        /// verify if a string is an integer.
        /// return true if the string is an integer,
        /// false otherwise
        /// </summary>
        public bool isIntString(String stringInt)
        {
            return stringInt.All(char.IsDigit);
        }
        /// <summary>
        /// Method <c>transform_number_to_roman_numeral</c>
        /// converts a number in roman numeral.
        /// if the convertion is not possible returns -1
        /// </summary>
        public String transform_number_to_roman_numeral(string number)
        {
            String result = "";

            //if is not a number return a string
            if (!this.isIntString(number)) return "-1";
            int numberCount = int.Parse(number);
            //
            while (numberCount>0)
            {
                //=>1000
                if (numberCount >= 1000)
                {
                    result += "M";
                    numberCount = numberCount - 1000;
                }
                //900-999
                if (numberCount >= 900 && numberCount < 1000)
                {
                    result += "CM";
                    numberCount = numberCount - 900;
                }
                //500-899
                if (numberCount >= 500 && numberCount < 900)
                {
                    result += "D";
                    numberCount = numberCount - 500;
                }
                //400-499
                if (numberCount >= 400 && numberCount < 500)
                {
                    result += "CD";
                    numberCount = numberCount - 400;
                }
                //100-399
                if (numberCount >= 100 && numberCount < 400)
                {
                    result += "C";
                    numberCount = numberCount - 100;
                }
                //90-99
                if (numberCount >= 90 && numberCount < 100)
                {
                    result += "XC";
                    numberCount = numberCount - 90;
                }
                //50-89
                if (numberCount >= 50 && numberCount < 90)
                {
                    result += "L";
                    numberCount = numberCount - 50;
                }
                //40-49
                if (numberCount >= 40 && numberCount < 50)
                {
                    result += "XL";
                    numberCount = numberCount - 40;
                }
                //10-39
                if (numberCount >= 10 && numberCount < 40)
                {
                    result += "X";
                    numberCount = numberCount - 10;
                }
                //9
                if (numberCount == 9)
                {
                    result += "IX";
                    numberCount = numberCount - 9;
                }
                //5-8
                if (numberCount >= 5 && numberCount < 9)
                {
                    result += "V";
                    numberCount = numberCount - 5;
                }
                //4
                if (numberCount == 4)
                {
                    result += "IV";
                    numberCount = numberCount - 4;
                }
                //1-3
                if (numberCount >= 1 && numberCount < 4)
                {
                    result+="I";
                    numberCount = numberCount - 1;
                }
            }
            return result;
        }
    }
}
