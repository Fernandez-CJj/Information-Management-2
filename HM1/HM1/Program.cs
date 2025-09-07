using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM1
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "";
            String reverseStr = "";


            while (str != "*")
            {
                Console.Write("enter a string: ");
                str = Console.ReadLine();

                if (str == "*") break;

                Console.WriteLine($"Original String: {str}");

                for (int c = str.Length - 1; c >= 0; c--)
                {
                    reverseStr += str[c];
                }
                Console.WriteLine($"Reversed String: {reverseStr.ToLower()}");

                Console.WriteLine(str.ToLower() == reverseStr.ToLower() ? "Palindrome?: YES" : "Palindrome?: NO");

                reverseStr = "";

                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}