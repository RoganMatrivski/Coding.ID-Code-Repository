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

namespace ListPF
{
    class Program
    {
        static void Main(string[] args)
        {
BEGIN:
            Console.Write("Insert number count: ");
            int numberCount = int.Parse(Console.ReadLine());

            List<List<int>> results = new List<List<int>>(numberCount);
            for (int i = 0; i < numberCount; i++)
            {
                Console.Write("Input the number to find the prime factor: ");
                int number = int.Parse(Console.ReadLine());

                List<int> primeFactorNumbers = new List<int>();
                int divider = 2;
                while (true) 
                { 
                    //* Check if the divider is the same as the number. If it does, it means it reached the biggest prime.
                    if (number == divider)
                    {
                        primeFactorNumbers.Add(divider);
                        break;
                    }

                    //* If the number can be divided by divider, add divider to list. If not, increment the divider.
                    if (number % divider == 0)
                    {
                        if (!primeFactorNumbers.Contains(divider))
                            primeFactorNumbers.Add(divider);
                        
                        number /= divider;
                    }
                    else
                    {
                        divider++;
                    }
                } 

                results.Add(primeFactorNumbers);
            }

            foreach (var result in results)
            {
                Console.WriteLine(string.Join(" ", result));
            }

            Console.ReadKey(true);
            Console.Clear();
goto BEGIN;
        }
    }
}
