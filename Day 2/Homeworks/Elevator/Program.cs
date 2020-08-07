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

            Console.Write("Enter the floor number: ");
            int floorNumber = Convert.ToUInt16(Console.ReadLine());

            //* Check beforehand if user inputs a wrong floor
            if (floorNumber > TOP_ELEVATOR || floorNumber < GROUND_ELEVATOR)
            {
                Console.WriteLine("Wrong floor");
                goto END;
            }

            //* Get the distance to the lowest and highest elevator
            int distanceToGroundElevator = Math.Abs(GROUND_ELEVATOR - floorNumber);
            int distanceToTopElevator = Math.Abs(TOP_ELEVATOR - floorNumber);

            if (distanceToTopElevator < distanceToGroundElevator)
            {
                //* The top elevator is the nearest
                Console.WriteLine("B");
            }
            else
            {
                //* The ground elevator is the nearest, including if the distance between elevator is the same.
                Console.WriteLine("A");
            }

        END:

            Console.ReadKey(true);
            Console.Clear();

            goto BEGIN;
        }
    }
}
