/*
 * Copyright (C) 2020  Robin Mauritz Languju
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Affero General Public License as published
 * by the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
    * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU Affero General Public License for more details.
 * 
 * You should have received a copy of the GNU Affero General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

//* Repository link: https://github.com/RoganMatrivski/Coding.ID-Code-Repository

using System;

namespace TravelT
{
    class Program
    {
        static void Main(string[] args)
        {
BEGIN:
            Console.Write("Enter the departure time: ");
            int[] departureTimeInput = Array.ConvertAll(Console.ReadLine().Split(':'), int.Parse);
            Console.Write("Enter the travel duration: ");
            int[] travelDurationInput = Array.ConvertAll(Console.ReadLine().Split(':'), int.Parse);

            if (
                departureTimeInput.Length != 2 || 
                travelDurationInput.Length != 2 ||
                departureTimeInput[0] > 24 ||
                departureTimeInput[1] > 60 ||
                travelDurationInput[0] > 24 ||
                travelDurationInput[1] > 60
                )
            {
                Console.WriteLine("Invalid Input");
                goto END;
            }

            int startTime = (departureTimeInput[0] * 60) + departureTimeInput[1];
            int travelDuration = (travelDurationInput[0] * 60) + travelDurationInput[1];

            int endTime = startTime + travelDuration;

            int endHour = (endTime / 60) % 24;
            int endMinute = endTime % 60;

            Console.WriteLine("Arrive time: {0}:{1}", endHour.ToString().PadLeft(2, '0'), endMinute.ToString().PadLeft(2, '0'));

END:
            Console.ReadKey(true);
            Console.Clear();
goto BEGIN;
        }
    }
}
