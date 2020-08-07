using System;

namespace Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
        BEGIN:
            Console.Write("Insert the X number: ");
            int X_brick = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insert the total brick number: ");
            int totalBricks = Convert.ToInt32(Console.ReadLine());

            int bricksLaid = 0;

            while (true)
            {
                bricksLaid += X_brick;
                if (bricksLaid >= totalBricks)
                {
                    Console.WriteLine("Adhit");
                    break;
                }

                bricksLaid += X_brick * 3;
                if (bricksLaid >= totalBricks)
                {
                    Console.WriteLine("Yoga");
                    break;
                }
            }

            Console.ReadKey(true);
            Console.Clear();
            goto BEGIN;
        }
    }
}
