using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

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
            var res = number % 35 == 0 && number != 0;
            return res;
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
            if (number < 0)
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
            var median = input.Length / 2;
            var str1 = input.Substring(0, median);
            var str2 = input.Substring(median + 1, str1.Length);
            string str2Reverse = new string(str2.Reverse().ToArray());
            var ifEqual = str1 == str2Reverse;
            return ifEqual;
        }

        /* TODO: Receives a int year as input paramether and returns true if the year is a leap year, false otherwise. */
        public static bool IsLeapYear(int year)
        {
            if (year % 400 == 0)
            {
                return true;
            }
            if (year % 4 == 0 && year % 100 != 0)
            {
                return true;
            }
            return false;
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
            // 1001
            double res = 0;
            for (int i = 0; i < binaryNumber.Length; i++)
            {
                var index = binaryNumber.Length - i - 1;
                var twoToThePower = Math.Pow(2, i);
                res += twoToThePower * (binaryNumber[index] - '0');
            }
            return Convert.ToInt32(res);
        }

        /* TODO: Converts a binary number represented as a string to its hexadecimal string equivalent. */
        public static string BinaryToHexadecimal(string binaryNumber)
        {
            var res = new StringBuilder();
            var residue = binaryNumber.Length % 4;
            var binaryNumberSB = new StringBuilder(binaryNumber);
            if (residue != 0)
            {
                for (int i = 0; i < 4 - residue; i++)
                {
                    binaryNumberSB = new StringBuilder("0").Append(binaryNumberSB);
                }
            }
            for (int i = 0; i <= binaryNumberSB.Length - 4; i += 4)
            {
                double fourDigitNumber = 0;
                string hexadecimalChar = "";
                for (int j = 0; j < 4; j++)
                {
                    var index = 4 + i - j - 1;
                    var power = Math.Pow(2, j);
                    fourDigitNumber += power * (binaryNumberSB[index] - '0');
                }
                if (fourDigitNumber <= 9)
                {
                    hexadecimalChar = ((int)fourDigitNumber).ToString();
                }
                switch (fourDigitNumber)
                {
                    case 10:
                        hexadecimalChar = "A";
                        break;
                    case 11:
                        hexadecimalChar = "B";
                        break;
                    case 12:
                        hexadecimalChar = "C";
                        break;
                    case 13:
                        hexadecimalChar = "D";
                        break;
                    case 14:
                        hexadecimalChar = "E";
                        break;
                    case 15:
                        hexadecimalChar = "F";
                        break;
                }
                res.Append(hexadecimalChar);

            }
            return res.ToString();
        }
    }
}
