using System;

namespace TheF
{
    class Program
    {
        static void Main(string[] args)
        {
        BEGIN:
            Console.Write("Insert the number to find the factor: ");
            int numberToFind = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numberToFind; i++)
            {
                if (numberToFind % i == 0)
                {
                    Console.WriteLine("{0} ", i);
                }
            }

            Console.ReadKey(true);
            Console.Clear();
            goto BEGIN;
        }
    }
}
