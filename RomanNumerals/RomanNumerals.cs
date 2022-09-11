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
        private int choice;
        private ConverterRomanNumeralToNumber CRNTN;
        private ConverterNumberToRomanNumeral CNTRN;

        public RomanNumerals()
        {
            this.CRNTN = new ConverterRomanNumeralToNumber();
            this.CNTRN = new ConverterNumberToRomanNumeral();
        }
        /// <summary>
        /// Method <c>Start</c>
        /// start the application.
        /// contains the logic of the application
        /// </summary>
        public void Start()
        {
            //print to video a message
            Console.WriteLine("First of all, what do you want do?");
            Console.WriteLine("Press 1 if you want convert a Roman Numeral to Number");
            Console.WriteLine("Press 2 if you want convert a Number to Roman Numeral");

            this.choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {

                Console.WriteLine("Insert the Roman Numeral to convert");

                //read the input
                string romanNumerals = Console.ReadLine().ToUpper();

                //convert the roman numeral
                int numero = CRNTN.transform_roman_numeral_to_number(romanNumerals);
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
            } else
            {
                if (choice == 2)
                {
                    Console.WriteLine("Insert the Number to convert");
                    //read the input
                    string number = Console.ReadLine().ToUpper();

                    //convert the roman numeral
                    string romanNumeric = CNTRN.transform_number_to_roman_numeral(number);
                    //clear the video
                    Console.Clear();
                    //print to video a message with the result
                    if (romanNumeric == "-1")
                    {
                        Console.WriteLine("This is not a number [" + number + "]");
                    }
                    else
                    {
                        Console.WriteLine("The number " + number + " is equal to " + romanNumeric);
                    }
                }
                else
                {
                    Console.WriteLine("Your choise is not valid!");
                }
            }
        }
    }
}
