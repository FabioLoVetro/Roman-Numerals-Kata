using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    /// <summary>
    /// Class <c>RomanNumerals</c>
    /// manage the logic of the application.
    /// </summary>
    public class RomanNumerals
    {
        private string romanNumerals = "";
        private int numero;

        /// <summary>
        /// Method <c>Start</c>
        /// start the application.
        /// contains the logic of the application
        /// </summary>
        public void Start()
        {
            //print to video a message
            Console.WriteLine("Insert the roman numeral to convert");
            //read the input
            romanNumerals = Console.ReadLine().ToUpper();
            //convert the roman numeral
            ConverterRomanNumeralToNumber converter = new ConverterRomanNumeralToNumber();
            numero = converter.transform_roman_numeral_to_number(romanNumerals);
            //clear the video
            Console.Clear();
            //print to video a message with the result
            if (numero == -1)
            {
                Console.WriteLine("This is not a roman numeral [" + romanNumerals + "]");
            }
            else
            {
                Console.WriteLine("The roman numerals " + romanNumerals + " is equal to " + numero);
            }
        }
    }
}
