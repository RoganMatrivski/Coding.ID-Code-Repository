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
using System.Collections.Generic;

namespace MostOA
{
    class Program
    {
        static void Main(string[] args)
        {
BEGIN:
            Console.WriteLine("Insert the numbers: ");
            string[] numbers = Console.ReadLine().Split(' ');

            Dictionary<string, int> numberCounts = new Dictionary<string, int>();

            foreach (string number in numbers)
            {
                if (numberCounts.ContainsKey(number))
                {
                    numberCounts[number] += 1;
                }
                else
                {
                    numberCounts.Add(number, 1);
                }
            }

            KeyValuePair<string, int> mostCountNumber = new KeyValuePair<string, int>("", 0);
            foreach (KeyValuePair<string, int> numberCount in numberCounts)
            {
                if (numberCount.Value > mostCountNumber.Value)
                    mostCountNumber = numberCount;
            }

            foreach (KeyValuePair<string, int> numberCount in numberCounts)
            {
                if (numberCount.Value == mostCountNumber.Value && numberCount.Key != mostCountNumber.Key)
                    mostCountNumber = new KeyValuePair<string, int>("", -1);
            }

            if (mostCountNumber.Value != -1) 
            {
                Console.WriteLine("Found {0} occurs {1} times.", mostCountNumber.Key, mostCountNumber.Value);
            }
            else
            {
                Console.WriteLine("Not found");
            }

            Console.ReadKey(true);
            Console.Clear();
goto BEGIN;
        }
    }
}
