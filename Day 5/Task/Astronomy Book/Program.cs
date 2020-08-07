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

namespace AstronomyB
{
    class Program
    {
        static void Main(string[] args)
        {
        BEGIN:
            Console.Write("Insert the ISBN code: ");
            string input = Console.ReadLine();

            int[] parsedInput = input.Select( //* For each character in input
                character => (int)char.GetNumericValue(character) //* Get the numerical value. Ex: '9' => 9, '1' => 1.
            ).ToArray(); //* Convert to array. Because IEnumerable is a pain to deal with.

            int[] multipliedInput = parsedInput.Select( //* For each number pn parsed input
                (number, index) => number * (index + 1) //* Multiply the number with it's own index position + 1
            ).ToArray(); //* Convert to array.

            int summedInput = multipliedInput.Sum(); //* Sum every element on array

            //! AUTHOR NOTE: The test case said that 1401601499 is Illegal, and 1401691499 is Legal. But this code shows the reverse of it. Ask the instructor.
            bool isDivisible = summedInput % 11 == 0; //* Check if it's divisible by 11.

            if (isDivisible)
                Console.WriteLine("LEGAL");
            else
                Console.WriteLine("ILLEGAL");

            Console.ReadKey(true);
            Console.Clear();
            goto BEGIN;
        }
    }
}
