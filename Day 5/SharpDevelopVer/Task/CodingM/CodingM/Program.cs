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

namespace CodingM
{
    class Program
    {
        static void Main(string[] args)
        {
        BEGIN:
            Console.Write("Input the directions: ");
            string directions = Console.ReadLine().ToLower();

            int xCoordinate = 0;
            int yCoordinate = 0;

            foreach (char direction in directions)
            {
                switch (direction)
                {
                    case 'l':
                        xCoordinate--;
                        break;
                    case 'r':
                        xCoordinate++;
                        break;
                    case 'u':
                        yCoordinate++;
                        break;
                    case 'd':
                        yCoordinate--;
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        goto END;
                }
            }

            Console.WriteLine("{0} {1}", xCoordinate, yCoordinate);

        END:
            Console.ReadKey(true);
            Console.Clear();
            goto BEGIN;
        }
    }
}
