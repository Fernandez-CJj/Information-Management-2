using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dollarToPesoYen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter currency in ($): ");
            string input = Console.ReadLine();

            int[] arrnum = input.Split(',').Select(int.Parse).ToArray();

            Console.WriteLine($"{"Dollars($)",-12}{"Phil Peso(P)",-15}{"Jpn Yen(y)",-15}");
            for(int c=0; c<arrnum.Length; c++)
            {
                (double peso, double yen) = convertCurrency(arrnum[c]);
                Console.WriteLine($"{arrnum[c],-12}{peso,-15:F2}{yen,-15:F2}");
            }

            Console.ReadKey();
        }

        static (double peso, double yen) convertCurrency(int dollar)
        {
            double peso = dollar * 57.17;
            double yen = dollar * 146.67;

            return (peso, yen);

        }
    }
}
