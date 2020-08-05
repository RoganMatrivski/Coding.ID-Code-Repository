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

namespace customTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
BEGIN:
            Console.Write("Insert the text: ");
            string input = Console.ReadLine();
            input = input.ToLower().Replace(" ", "");

            char[] reversedInputChars = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                int reversedIndex = (input.Length - 1) - i;
                reversedInputChars[i] = input[reversedIndex];
            }

            string reversedInput = new string(reversedInputChars);

            if (input == reversedInput)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

            Console.ReadKey(true);
            Console.Clear();
goto BEGIN;
        }
    }
}
