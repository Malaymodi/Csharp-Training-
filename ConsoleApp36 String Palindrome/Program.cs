using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36_String_Palindrome
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();

            String s;
        repeat:
            Console.WriteLine("Enter String to check whether it is palindrome or not ");
            s = Console.ReadLine();
            string palindrome = s.Trim();
            if (string.IsNullOrEmpty(palindrome))
            {
                goto repeat;
            }

            char[] char_array = palindrome.ToCharArray();
            char_array.Reverse();
            string rev_str = string.Join("", char_array);
            Console.WriteLine(rev_str);


            //Console.WriteLine(char_array);

            /* int strlen = palindrome.Length;
             string rev="";
             char[] char_arr = {};

             for (int i = strlen-1; i >=0; i--)
             {

                 rev += palindrome[i];
                char_arr[] = palindrome[i];
                 char_arr.Append(palindrome[i]);
                 Console.WriteLine(char_arr);
             }*/

            // char[] char_array = rev.ToCharArray();


            if (palindrome == rev_str)
            {
                Console.WriteLine("Your String is Palindrome");
            }

            else
            {
                Console.WriteLine("Your String is not palindrome");
            }

            Console.ReadLine();

        }
    }
}
