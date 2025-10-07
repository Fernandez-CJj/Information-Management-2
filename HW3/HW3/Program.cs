using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter String: ");
            string input = Console.ReadLine();
            printOutput(input);

            Console.ReadKey();
        }

        static void printOutput(string input)
        {
            string cleanInput = input.Trim().ToLower().Replace(" ", "");

            string[] arr = cleanInput.Split(',');

            for(int c=0; c<arr.Length; c++)
            {
                char[] arrLetters = arr[c].ToCharArray();
                Dictionary<char, int> letterCount = new Dictionary<char, int>();

                foreach(char ch in arrLetters)
                {
                    if (letterCount.ContainsKey(ch))
                    {
                        letterCount[ch]++;
                    }
                    else
                    {
                        letterCount[ch] = 1;
                    }
                }

                int count = 0;
                int total = letterCount.Count;

                foreach (KeyValuePair<char, int> pair in letterCount)
                {
                    count++;
                    if (count == total)
                        Console.Write($"{pair.Key}={pair.Value}");
                    else
                        Console.Write($"{pair.Key}={pair.Value}, ");
                }

                Console.WriteLine();
            }
        }
    }
}
