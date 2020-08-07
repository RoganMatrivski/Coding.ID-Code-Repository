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

//* This thing is complicated as hell but please, bear with me. This thing will make sense.
//* If you see a lot of select, that's because i was a Javscript developer and i've used .map() a lot. Sorry.

using System;
using System.Linq;

namespace CreateNA
{
    class Program
    {
        static void Main(string[] args)
        {
        BEGIN:
            Console.Write("Input Row: ");
            int rowCount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Column: ");
            int columnCount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Operand : ");
            string op = Console.ReadLine();

            //* I'm inverting the row and column to make me easier to sum them
            int[][] table = new int[columnCount][];
            table = table.Select((e) => new int[rowCount]).ToArray(); //* Populate the array with empty rows

            for (int i = 0; i < rowCount; i++)
            {
                Console.Write("Input Row {0}: ", i + 1);
                //* This block of code ahead is convoluted, but (a bit) fool proof.
                int[] rowInputs = Console.ReadLine()         //* Read the rows number
                                            .Split(' ')         //* Split by space
                                            .Select(c =>
                    {                                           //* For each number string
                        int parseResult = 0;                        //* Create a container to store the conversion result
                        if (int.TryParse(c, out parseResult))       //* Try to parse the string
                            return parseResult;                     //* Return the parse result
                        else                                        //* If it can't
                            return -1;                              //* Return error as -1
                    }).ToArray();

                if (rowInputs.Contains(-1) || rowInputs.Length != columnCount) //* Check if the row input is incorrect
                {
                    Console.WriteLine("Input Error");
                    goto END;
                }

                for (int j = 0; j < columnCount; j++)
                {
                    table[j][i] = rowInputs[j];
                }
            }

            int[] reducedTable = new int[columnCount];

            switch (op)
            {
                case "+":
                    for (int i = 0; i < reducedTable.Length; i++)
                        reducedTable[i] = table[i].Aggregate((accumulator, value) => accumulator + value); //* Probably can use the Sum() Linq as well

                    break;
                case "-":
                    for (int i = 0; i < reducedTable.Length; i++)
                        reducedTable[i] = table[i].Aggregate((accumulator, value) => accumulator - value);

                    break;
                case "*":
                    for (int i = 0; i < reducedTable.Length; i++)
                        reducedTable[i] = table[i].Aggregate((accumulator, value) => accumulator * value);

                    break;
                default:
                    Console.WriteLine("Wrong Operator");
                    goto END;
            }

            Console.WriteLine("Result: {0}", string.Join(' ', reducedTable));
        END:
            Console.ReadKey(true);
            Console.Clear();
            goto BEGIN;
        }
    }
}
