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
using System.Linq;
using System.Collections.Generic;

namespace customTemplate
{
    class Program
    {
        static string formatCurrency(int value) {
            string stringValue = value.ToString();

            char[] invertedValue = stringValue.Reverse().ToArray();

            List<char> result = new List<char>(stringValue.Length + (stringValue.Length / 3));

            for (int i = 0; i < invertedValue.Count(); i++)
            {
                result.Add(invertedValue[i]);
                if ((i + 2) % 4 == 0)
                    result.Add('.');
            }

            result.Reverse();

            return "Rp " + new string(result.ToArray());
        }

        static void Main(string[] args)
        {
BEGIN:
            Console.Write("In: ");
            int[] startTimeInput = Console.ReadLine().Split(':').Select(int.Parse).ToArray();
            Console.Write("Out: ");
            int[] endTimeInput = Console.ReadLine().Split(':').Select(int.Parse).ToArray();

            int startTime = (startTimeInput[0] * 60) + startTimeInput[1];
            int endTime = (endTimeInput[0] * 60) + endTimeInput[1];

            int workDuration = endTime - startTime;
            double workHour = Math.Round((double)workDuration / 60, 2);
            int overtimeDuration = workDuration - (9 * 60);
            int overtimeHour = overtimeDuration / 60;

            int overtimeWages = 0;

            if (overtimeHour > 0)
            {
                if (overtimeHour >= 4)
                    overtimeWages = 20000 * 4;
                else
                    overtimeWages = 20000 * overtimeHour;
            }

            Console.WriteLine("Total Working Hours: {0}", workHour);
            Console.WriteLine("Overtime Wages: {0}", formatCurrency(overtimeWages));

            Console.ReadKey(true);
            Console.Clear();
goto BEGIN;
        }
    }
}
