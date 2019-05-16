using System;

namespace PrintTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter symbol");

            char symbol = char.Parse(Console.ReadLine());

            PrintTree(4, symbol);

            Console.ReadLine();

        }



        static void PrintTree(int height, char symbol)
        {

            int n = height;

            int t = 1;
            for (int i = 0; i < n; i++)

            {
                for (int z = height - i; z > 0; z--)

                {

                    Console.Write(" ");

                }

                for (int j = 0; j < 2 * t - 1; j++)

                {
                    Console.Write(symbol);

                }

                t++;

                Console.Write("\n");

            }
        }
    }
}

