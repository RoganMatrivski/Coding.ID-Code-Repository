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

namespace Combination
{
    class Program
    {
        static void Main(string[] args)
        {
        BEGIN:

            Console.Write("Input the text: ");
            string input = Console.ReadLine();
            string lowercasedInput = input.ToLower();
            string sterilizedInput = string.Concat(lowercasedInput.Where(character => character != ' '));

            char[] vowels = { 'a', 'i', 'u', 'e', 'o' };

            char[] separatedVowels = sterilizedInput.Where(character => vowels.Contains(character)).ToArray();
            char[] separatedConsonants = sterilizedInput.Where(character => !vowels.Contains(character)).ToArray();

            List<string> vowelGroups = new List<string>();
            List<string> consonantGroups = new List<string>();

            for (int i = 0; i < separatedVowels.Count() - 1; i += 2)
            {
                char[] chars = { separatedVowels[i], separatedVowels[i + 1] };
                vowelGroups.Add(new string(chars));
            }

            for (int i = 0; i < separatedConsonants.Count() - 1; i += 2)
            {
                char[] chars = { separatedConsonants[i], separatedConsonants[i + 1] };
                consonantGroups.Add(new string(chars));
            }

            Console.WriteLine("Vowel\t\t: {0}", string.Join(" ", vowelGroups));
            Console.WriteLine("Consonants\t: {0}", string.Join(" ", consonantGroups));

            Console.ReadKey(true);
            Console.Clear();
            goto BEGIN;
        }
    }
}
