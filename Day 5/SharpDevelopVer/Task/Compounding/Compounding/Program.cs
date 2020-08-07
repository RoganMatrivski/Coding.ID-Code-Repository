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

namespace Compounding
{
    class Program
    {
        static void Main(string[] args)
        {
        BEGIN:
            Console.Write("Insert input: ");
            string input = Console.ReadLine().ToLower();

            string[] compoundedInput = new string[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                char[] compoundedChar = new String(input[i], i + 1).ToCharArray();
                compoundedChar[0] = char.ToUpper(compoundedChar[0]);
                compoundedInput[i] = new string(compoundedChar);
            }

            Console.WriteLine(string.Join("-", compoundedInput));

            Console.ReadKey(true);
            Console.Clear();
            goto BEGIN;
        }
    }
}
