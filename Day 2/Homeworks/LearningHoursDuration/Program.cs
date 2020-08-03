// Author: Robin Mauritz Languju
// Written in Visual Studio Code, copy pasted to SharpDevelop.

using System;

namespace Elevator
{
    class Program
    {
        const int TOP_ELEVATOR = 7;
        const int GROUND_ELEVATOR = 1;

        static void Main(string[] args)
        {
            //* Shouldn't have used labels for code readability but... eh, okay.
BEGIN:

            Console.Write("Enter the starting time and the end time: ");
            string floorNumber = Console.ReadLine();

            //* Separate the start and end time
            string[] separatedString = floorNumber.Split(' ');

            //* Check for invalid input
            if (separatedString.Length != 4)
            {
                Console.WriteLine("Input invalid");
                goto END;
            }

            //* Convert to integer
            int[] separatedIntegers = Array.ConvertAll(separatedString, int.Parse);

            //* Check for invalid time
            if (separatedIntegers[1] > 60 || separatedIntegers[3] > 60)
            {
                Console.WriteLine("One of the minute time is invalid");
                goto END;
            }

            //* Define all the times, also convert hours to minute
            int startTime = (separatedIntegers[0] * 60) + separatedIntegers[1];
            int endTime = (separatedIntegers[2] * 60) + separatedIntegers[3];

            //* Get the time difference
            int durationTime = Math.Abs(endTime - startTime);

            //* Convert to hours and minutes
            int durationHour = durationTime / 60;
            int durationMinutes = durationTime % 60;

            //* Printout the result
            Console.WriteLine();
            //* This century-old compiler doesn't support string literal so i'm forced with a good ol' string concat
            Console.WriteLine("Time difference: " + durationHour.ToString().PadLeft(2, '0') + ":" + durationMinutes.ToString().PadLeft(2, '0'));

END:

            Console.ReadKey(true);
            Console.Clear();

goto BEGIN;
        }
    }
}
