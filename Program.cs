using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Lab_3._3_Data_Structures
{
    class Program
    {
        static string Reverse(string input)
        {
            char[] letterData = input.ToCharArray();
            Stack<char> reverseWord = new Stack<char>();

            for (int i = 0; i < letterData.Length; i++) //For loop to take each part of the Reverse Work Stack and add it to a char array
            {
                reverseWord.Push(letterData[i]);
            }

            foreach (char c in letterData)
            {
                char output = reverseWord.Pop();

                Console.Write(output);
            }

            return null;
        }
        //////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args)
        {
            Console.Write("Please enter a word or sentence you would like to reverse:");

            string input = Console.ReadLine();

            Regex reg = new Regex(@"^[A-Za-z]*$"); // Check to make sure letters are the only thing input. No Numbers or Symbols.

            bool matched = reg.IsMatch(input);

            if (matched == false)
            {
                Console.WriteLine("Please use letters only.");
            }
            else
            {
                string answer = Reverse(input);

                //Console.WriteLine(answer);
            }




        }
    }
}