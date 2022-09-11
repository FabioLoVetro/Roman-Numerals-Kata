using NUnit.Framework;
using FluentAssertions;
using System.Collections.Generic;
using System;
using RomanNumerals;

namespace RomanNumerals
{
    public class ConverterNumberToRomanNumeralTest
    {
        private ConverterNumberToRomanNumeral converter;

        [SetUp]
        public void Setup()
        {
            converter = new ConverterNumberToRomanNumeral();
        }

        [Test]
        public void transform_roman_numeral_to_number_should_return_minus_one_for_invalid_numbers()
        {
            converter.transform_number_to_roman_numeral("a123").Should().Be("Is not possible converte [a123] in Roman Numeral");
            converter.transform_number_to_roman_numeral("123B").Should().Be("Is not possible converte [123B] in Roman Numeral");
            converter.transform_number_to_roman_numeral("1e2").Should().Be("Is not possible converte [1e2] in Roman Numeral");
            converter.transform_number_to_roman_numeral("123@").Should().Be("Is not possible converte [123@] in Roman Numeral");
            converter.transform_number_to_roman_numeral("#").Should().Be("Is not possible converte [#] in Roman Numeral");
            converter.transform_number_to_roman_numeral("@@@").Should().Be("Is not possible converte [@@@] in Roman Numeral");
        }

        [Test]
        public void transform_number_to_roman_numeral_should_return_I_for_1()
        {
            converter.transform_number_to_roman_numeral("1").Should().Be("I");
        }

        [Test]
        public void transform_number_to_roman_numeral_should_return_V_for_5()
        {
            converter.transform_number_to_roman_numeral("5").Should().Be("V");
        }

        [Test]
        public void transform_number_to_roman_numeral_should_return_X_for_10()
        {
            converter.transform_number_to_roman_numeral("10").Should().Be("X");
        }

        [Test]
        public void transform_number_to_roman_numeral_should_return_L_for_50()
        {
            converter.transform_number_to_roman_numeral("50").Should().Be("L");
        }

        [Test]
        public void transform_number_to_roman_numeral_should_return_C_for_100()
        {
            converter.transform_number_to_roman_numeral("100").Should().Be("C");
        }

        [Test]
        public void transform_number_to_roman_numeral_should_return_D_for_500()
        {
            converter.transform_number_to_roman_numeral("500").Should().Be("D");
        }

        [Test]
        public void transform_number_to_roman_numeral_should_return_M_for_1000()
        {
            converter.transform_number_to_roman_numeral("1000").Should().Be("M");
        }

        [Test]
        public void transform_number_to_roman_numeral_should_return_MMXXII_for_2022()
        {
            converter.transform_number_to_roman_numeral("2022").Should().Be("MMXXII");
        }

        [Test]
        public void transform_number_to_roman_numeral_should_return_MDCCXXV_for_1725()
        {
            converter.transform_number_to_roman_numeral("1725").Should().Be("MDCCXXV");
        }

        [Test]
        public void transform_number_to_roman_numeral_should_return_XMIV_for_994()
        {
            converter.transform_number_to_roman_numeral("994").Should().Be("XMIV");
        }
    }
}
