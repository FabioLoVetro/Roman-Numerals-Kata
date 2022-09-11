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
            if (this.isIntString(number)) return "-1";
            int numberCount = int.Parse(number);
            //
            while (numberCount>0)
            {
                if (numberCount >= 1000) result.Concat("M");
                numberCount = numberCount - 1000;
                if (numberCount >= 500 && numberCount<1000) result.Concat("D");
                numberCount = numberCount - 500;
                if (numberCount >= 100 && numberCount < 500) result.Concat("C");
                numberCount = numberCount - 100;
                if (numberCount >= 50 && numberCount < 100) result.Concat("L");
                numberCount = numberCount - 50;
                if (numberCount >= 10 && numberCount < 50) result.Concat("X");
                numberCount = numberCount - 10;
                if (numberCount >= 5 && numberCount < 10) result.Concat("V");
                numberCount = numberCount - 5;
                if (numberCount >= 1 && numberCount < 5) result.Concat("I");
                numberCount = numberCount - 1;
            }

            return result;
        }
    }
}
