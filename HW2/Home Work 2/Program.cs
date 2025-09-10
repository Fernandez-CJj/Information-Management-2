    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Home_Work_2
    {
        class Program
        {
            static void Main(string[] args)
            {
                double sum = 0;

                Console.Write("enter row size: ");
                int row = int.Parse(Console.ReadLine());
                Console.Write("enter column size: ");
                int column = int.Parse(Console.ReadLine());

                List<List<double>> numbers = new List<List<double>>();

                for (int x = 0; x < row; x++)
                {
                    numbers.Add(new List<double>(column));
                    Console.WriteLine($"Row {x+1}");
                    for (int y = 0; y < column; y++)
                    {
                        Console.Write($"enter number[{y+1}]: ");
                        numbers[x].Add(double.Parse(Console.ReadLine()));
                        sum += numbers[x][y];
                    }
                }

                Console.WriteLine("\nYou entered:");

                for (int x = 0; x < row; x++)
                {   
                    for (int y = 0; y < column; y++)
                    {
                        Console.Write($"{numbers[x][y]:F1} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine($"Sum: {sum:F1} Average: {sum/(row*column):F1}");

                Console.ReadKey();
            }
        }
    }
