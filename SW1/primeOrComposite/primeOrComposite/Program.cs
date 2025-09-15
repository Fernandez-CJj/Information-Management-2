using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeOrComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            primeOrComposite(input);

           
            Console.ReadKey();
        }

        static void primeOrComposite(string arr)
        {
            int[] num = arr.Split(' ').Select(int.Parse).ToArray();
            
            for(int c=0; c<num.Length; c++)
            {   
                if(num[c] <= 1)
                {
                    Console.WriteLine($"{c + 1}. {num[c],-5} Neither prime nor composite");
                    continue;
                }
                int factorCount = 0;
                for(int i=1; i <= num[c]; i++)
                {
                    if(num[c] % i == 0)
                    {
                        factorCount++;
                    }
                }

                if (factorCount == 2)
                    Console.WriteLine($"{c + 1}. {num[c],-5} Prime");
                else
                    Console.WriteLine($"{c + 1}. {num[c],-5} Composite");
            }


        }
    }
}