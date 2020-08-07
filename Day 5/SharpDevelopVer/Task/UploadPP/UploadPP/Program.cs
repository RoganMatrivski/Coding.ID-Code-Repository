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

namespace UploadPP
{
    class Program
    {
        static void Main(string[] args)
        {
        BEGIN:
            Console.Write("Insert minimum dimensions: ");
            int minDimension = int.Parse(Console.ReadLine());
            Console.Write("Insert number of photos: ");
            int photoNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < photoNumber; i++)
            {
                Console.Write("Insert photo #{0} dimension: ", i + 1);
                int[] photoDimension = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                if (photoDimension.Length != 2)
                {
                    Console.WriteLine("INPUT ERROR");
                    continue;
                }

                if (!photoDimension.All(dimension => dimension >= minDimension))
                {
                    Console.WriteLine("UPLOAD ANOTHER");
                    continue;
                }

                if (photoDimension[0] - photoDimension[1] != 0)
                {
                    Console.WriteLine("CROP IT");
                    continue;
                }

                Console.WriteLine("ACCEPTED");
            }

        END:
            Console.ReadKey(true);
            Console.Clear();
            goto BEGIN;
        }
    }
}
