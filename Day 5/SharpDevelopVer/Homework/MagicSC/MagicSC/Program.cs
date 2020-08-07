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

namespace MagicSC
{
    class Program
    {
        static void Main(string[] args)
        {
BEGIN:
            Console.Write("Insert the text: ");
            string input = Console.ReadLine().Replace(" ", "");

            Dictionary<char, int> characterCounts = new Dictionary<char, int>();
            foreach (char character in input)
            {
                if (characterCounts.ContainsKey(character))
                {
                    characterCounts[character] += 1;
                }
                else
                {
                    characterCounts.Add(character, 1);
                }
            }

            List<string> stringArray = new List<string>();
            foreach (var keyPair in characterCounts)
            {
                stringArray.Add(new string(keyPair.Key, keyPair.Value));
            }

            Console.WriteLine(string.Join("", stringArray));

            Console.ReadKey(true);
            Console.Clear();
goto BEGIN;
        }
    }
}
