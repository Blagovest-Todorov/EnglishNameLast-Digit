using System;

namespace pritntNameLastDigitOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine(); //read the number
            returnEnglishName(inputText);

        }
        public static void returnEnglishName(string inputNumber) 
        {
            
            int lastDigit = 0;
            lastDigit = inputNumber[inputNumber.Length - 1]; // here we take always the last digit of the Number
            // Console.WriteLine((char)lastDigit);  // as the last digit is an Ascii CodeNumber -we take the symbol representing this number., so we have the number
            char digit = (char)lastDigit;
            // Console.WriteLine(digit);
            string nameInEnglish = string.Empty;

            if (digit == '0')
            {
                nameInEnglish = "zero";
            }
            else if (digit == '1')
            {
                nameInEnglish = "one";
            }
            else if (digit == '2')
            {
                nameInEnglish = "two";
            }
            else if (digit == '3')
            {
                nameInEnglish = "three";
            }
            else if (digit == '4')
            {
                nameInEnglish = "four";
            }
            else if (digit == '5')
            {
                nameInEnglish = "five";
            }
            else if (digit == '6')
            {
                nameInEnglish = "six";
            }
            else if (digit == '7')
            {
                nameInEnglish = "seven";
            }
            else if (digit == '8')
            {
                nameInEnglish = "eight";
            }
            else if (digit == '9')
            {
                nameInEnglish = "nine";
            }

            Console.WriteLine(nameInEnglish);

        }
    }
}
