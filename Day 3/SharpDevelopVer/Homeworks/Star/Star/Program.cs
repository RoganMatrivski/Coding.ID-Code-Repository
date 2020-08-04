using System;

namespace Star
{
    class Program
    {
        static void Main(string[] args)
        {
BEGIN:
            Console.Write("Pick the mode (A, B, C, D): ");
            string mode = Console.ReadLine();

            switch (mode)
            {
                case "A":
                    for (int row = 0; row < 5; row++)
                    {
                        for (int col = 0; col < 5 - row; col++)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }
                    break;
                case "B":
                    for (int row = 0; row < 5; row++)
                    {
                        for (int emptyCol = 0; emptyCol < row; emptyCol++)
                        {
                            Console.Write(" ");
                        }
                        for (int col = 0; col < 5 - row; col++)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }
                    break;
                case "C":
                    for (int row = 0; row < 5; row++)
                    {
                        for (int emptyCol = 0; emptyCol < 5 - (row + 1); emptyCol++)
                        {
                            Console.Write(" ");
                        }
                        for (int col = 0; col < row + 1; col++)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }
                    break;
                case "D":
                    for (int row = 0; row < 5; row++)
                    {
                        for (int col = 0; col < row + 1; col++)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }
                    break;
                default:
                    Console.WriteLine("Wrong input!");
                    break;
            }

            Console.ReadKey(true);
            Console.Clear();
goto BEGIN;
        }
    }
}
