using System;
using System.Collections.Generic;
using System.Linq;

namespace conditionsPractice
{
    public class ConditionPracticeClass
    {
        /*TODO: The method must receive one parameter of the int type as input - a number to check.
        The method must return a boolean value, depending on whether the input parameter is even or odd*/
        public static bool IsEven(int number)
        {
            var isEven = number % 2 == 0;
            return isEven;
        }

        /* TODO: Receives a string as input and returns true if the string contains only unique characters, false otherwise. */
        public static bool HasUniqueCharacters(string input)
        {
            var count = input.Distinct().Count();
            var ifUnique = count == input.Length;
            return ifUnique;
        }

        /* TODO: Receives an integer as input and returns true if the number is divisible by both 5 and 7, excluding zero, false otherwise. */
        public static bool IsDivisibleBy5And7(int number)
        {
            if (number % 5 == 0 && number % 7 == 0 && number != 0)
            {
                return true;
            }
            return false;
        }

        /* TODO: Performs the specified arithmetic operation (char input paramether) on two double input paramethers and returns the result. */
        public static double PerformOperation(char operation, double number1, double number2)
        {
            double res = 0;
            switch (operation)
            {
                case '+':
                    res = number1 + number2;
                    break;
                case '/':
                    res = number1 / number2;
                    break;
                case '-':
                    res = number1 - number2;
                    break;
                case '*':
                    res = number1 * number2;
                    break;
            }
           return res;
        }

        /* TODO: Receives an integer as input and returns "Positive" if the number is positive, "Negative" if the number is negative, "Zero" if the number is zero. */
        public static string CheckNumber(int number)
        {
            if (number <0)
            {
                return "Negative";
            }
            else if (number > 0)
            {
                return "Positive";
            }
            else
            {
                return "Zero";
            }
        }

        /* TODO: Receives a string as input and returns true if the string is a palindrome, false otherwise. */
        public static bool IsPalindrome(string input)
        {
            throw new NotImplementedException();
        }

        /* TODO: Receives a int year as input paramether and returns true if the year is a leap year, false otherwise. */
        public static bool IsLeapYear(int year)
        {
            return DateTime.IsLeapYear(year);
        }


        /* TODO: Receives a character as input and returns true if the character is a vowel, false otherwise. */
        public static bool IsVowel(char character)
        {
            bool isVowel = "aeiouAEIOU".IndexOf(character) >= 0;
            return isVowel;
        }

        /* TODO: Converts a binary number represented as a string to its integer equivalent. */
        public static int BinaryToDecimal(string binaryNumber)
        {
            var res = Convert.ToInt32(binaryNumber, 2);
            return res;
        }

        /* TODO: Converts a binary number represented as a string to its hexadecimal string equivalent. */
        public static string BinaryToHexadecimal(string binaryNumber)
        {
            var res = Convert.ToInt32("1011", 2).ToString("X");
            return res;
        }
    }
}
