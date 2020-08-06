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
using System.Linq;

namespace CountD
{
    class Program
    {
        static void Main(string[] args)
        {
BEGIN:

            Console.WriteLine("Write the L, R and K input: ");
            string input = Console.ReadLine();
            string[] splittedInput = input.Split(' ');

            if (splittedInput.Length != 3)
            {
                Console.WriteLine("Input error");
                goto END;
            }

            int[] splittedInteger = splittedInput.Select(str => int.Parse(str)).ToArray();

            int L = splittedInteger[0];
            int R = splittedInteger[1];
            int K = splittedInteger[2];

            List<int> divisibleNumbers = new List<int>();

            for (int i = L + 1; i < R; i++)
            {
                if (i % K == 0)
                {
                    Console.WriteLine(i);
                    divisibleNumbers.Add(i);
                }
            }

            Console.WriteLine(divisibleNumbers.Sum());

END:
            Console.ReadKey(true);
            Console.Clear();
goto BEGIN;
        }
    }
}
