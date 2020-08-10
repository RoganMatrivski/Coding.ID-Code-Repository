﻿/*
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

namespace customTemplate
{
    class Program
    {
        //* Source (It's my own snippet. With a lot of researching on the net): 
        //* https://github.com/RoganMatrivski/Coding.ID-Code-Repository/blob/ae6fca56abb079d4240d4d0909ab1ab150538c46/Is%20Prime/Program.cs#L26-L49
        public static bool IsPrime(long number)
        {
            //* Return if number is less than 2. Because prime number can't be less than 2
            if (number <= 1)
                return false;
            else if (number % 2 == 0)   //* If the number is divisible by 2
                if (number == 2)        //* If the number is 'actually' 2
                    return true;        //* Return true, because number 2 is a prime by default
                else                    //* If not
                    return false;       //* Return false, because no even number is prime other than 2

            //* Find the upper limit of the prime. We using square root operation for this one.
            //* I really want to explain this. But i know that i can't. But i swear to god i understand this code.
            //* Source: http://mathandmultimedia.com/2012/06/02/determining-primes-through-square-root/
            long N = (long)(Math.Sqrt(number) + 0.5); //* Also adding 0.5 for rounding

            //* Starting from three, run the code below and then increment by 2. Remember, no even number is prime. Only odds.
            for (int i = 3; i <= N; i += 2)
                if (number % i == 0)    //* Your usual run of the mill if it's divisible.
                    return false;       //* Return false if it does.

            //* After all of the checks, the number gets a seal-of-approval authentic prime number.
            return true;
        }

        static void Main(string[] args)
        {
        BEGIN:
            Console.Write("Insert how much do you want to find the numbers: ");
            int numberCount = int.Parse(Console.ReadLine());

            List<string> results = new List<string>(numberCount);
            int currentNumberPosition = 100;

            while (results.Count < numberCount)
            {
                string currentNumber = currentNumberPosition.ToString();

                HashSet<int> numberToTest = new HashSet<int>(); //* This array is the same as List<T>, but it prevents duplicates. Ex: 103 => 103, 03, 3. The '03' part is unnecessary, since it'll evaluate as 3.
                for (int i = 0; i < currentNumber.Length; i++)
                {
                    numberToTest.Add(                   //* Add the number
                        int.Parse(                      //* That has been converted
                            currentNumber.Substring(i)  //* From this subset of string. This line of code is getting the part of string starting from 'i'.
                        )
                    );
                }

                bool isMagicPrime = true;
                foreach (int number in numberToTest)
                {
                    if (!IsPrime(number))
                    {
                        isMagicPrime = false;
                        break;
                    }
                }

                if (isMagicPrime)
                    results.Add(currentNumber);

                currentNumberPosition++;
            }

            for (int i = 0; i < results.Count; i++)
            {
                Console.WriteLine("#{0} Number => {1}", i + 1, results[i]);
            }

            Console.ReadKey(true);
            Console.Clear();
            goto BEGIN;
        }
    }
}
