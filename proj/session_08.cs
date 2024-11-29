using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj
{
    internal class session_08
    {
        static void Main8(string[] args)
        {
            Console.WriteLine("Enter the first string:");
            string s1 = Console.ReadLine().ToLower();

            ///to input a string and print it.
            /*Console.WriteLine($"Sentence: {s1}");
            
             ///to find the length of a string without using a library function.
            int length = 0;
            foreach(char a in s1)
            {
                length++;
            }
            Console.WriteLine($"This string has the length: {length}.");

            ///to separate individual characters from a string.
            Console.WriteLine("Seperate character in string:");
            for (int i = 0;i<s1.Length;i++)
            {
                Console.WriteLine(s1[i]);
            }

            ///to print individual characters of the string in reverse order.
            Console.WriteLine("List each char in the string in reverse order:");
            for(int i = s1.Length-1;i>=0;i--)
            {
                Console.WriteLine(s1[i]);
            }


            ///to count the total number of words in a string.
            string[] word = s1.Split(new[] {' ','\t'},StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"The number of words is :{word.Length}");*/


            ///to compare two strings without using a string library functions.
            /* Console.WriteLine("Enter the second string:");
             string s2=Console.ReadLine();
             if(CompareTwoString(s1, s2))
             {
                 Console.WriteLine("Two strings are equal.");
             }
             else Console.WriteLine("Two strings are different.");*/


            ///to count the number of alphabets, digits and special characters in a string.
            /* int countLetter = 0;
             int countDigit = 0;
             int countSpecialChar = 0;

             foreach (char a in s1)
             {
                 if(char.IsLetter(a))
                     countLetter++;
                 else if(char.IsDigit(a))
                     countDigit++;
                 else if(!char.IsWhiteSpace(a))
                     countSpecialChar++;
             }
             Console.WriteLine($"The string has {countLetter} letters, {countDigit} digits and {countSpecialChar} special characters. ");*/

            ///to count the number of vowels or consonants in a string.
            /*int countVowel = 0;
            int countConsonant = 0;
            foreach(char a in s1)
            {
                if(char.IsLetter(a))
                {
                    if ("ueoai".Contains(a))
                        countVowel++;
                    else countConsonant++;
                }
            }
            Console.WriteLine($"The string has {countVowel} vowels and {countConsonant} consonants.");*/

            ///to check whether a given substring is present in the given string.
            ///to search for the position of a substring within a string.
            ///to check whether a character is an alphabet and not and if so, check for the case.

            Console.WriteLine("Enter the substring:");
            string sub= Console.ReadLine();
            int position=0;
            bool found= false;
            int count = 0;
            while((position=s1.IndexOf(sub,position))!=-1)
            {
                Console.WriteLine($"This substring is present in the string at the index: {position+1}.");
                position ++;
                count++;
                found = true;
            }
            if(count>0) Console.WriteLine($"The substring exists at {count} times.");
            if(!found) 
             Console.WriteLine("This substring isn't present in the string.");

            ///to insert a substring before the first occurrence of a string.
            string s3 = sub +" "+ s1;
            Console.WriteLine(s3);

            

            /*Console.WriteLine("Enter a character:");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if(char.IsLetter(input) )
            {
                if (char.IsUpper(input))
                {
                    Console.WriteLine($"{input} is an alphabet and it is an uppercase letter.");
                }
                else Console.WriteLine($"{input} is an alphabet and it is an lowercase letter.");                                               
            }
            else Console.WriteLine($"{input} is not an alphabet.");*/

            ///to find the number of times a substring appears in a given string.

        }
        static bool CompareTwoString(string s1, string s2)
        {
            if (s1.Length != s2.Length) return false;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i]) return false;
            }
            return true;
        }
    }
}
