using System;

namespace Kuy_
{
    class Program
    {
        static void Main(string[] args)
        {
        BEGIN:
            Console.Write("Insert the N number: ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insert the X number: ");
            int X = Convert.ToInt32(Console.ReadLine());

            string result = "";

            for (int i = 1; i <= N; i++)
            {
                if (i % X == 0)
                {
                    result += "Kuy!" + " ";
                }
                else
                {
                    result += i + " ";
                }
            }

            Console.WriteLine(result);
            Console.ReadKey(true);
            Console.Clear();
            goto BEGIN;
        }
    }
}
