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

namespace DigitF
{
    class Program
    {
        static int factorial(int number)
        {
            if (number == 0)
                return 1;

            int result = 1;
            for (int i = 2; i <= number; i++) //* Skip number one because 1! = 1.
                result *= i;

            return result;
        }

        static void Main(string[] args)
        {
        BEGIN:
            Console.Write("Insert the string: ");
            string numberInput = Console.ReadLine();

            int result = 0;
            foreach (char character in numberInput)
            {
                int number = (int)char.GetNumericValue(character);
                result += factorial(number);
            }

            Console.WriteLine(result);

            Console.ReadKey(true);
            Console.Clear();
            goto BEGIN;
        }
    }
}
