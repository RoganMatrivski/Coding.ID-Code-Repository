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

namespace MarryM
{
    class Program
    {
        static void Main(string[] args)
        {
        BEGIN:
            double joniPercentage = 0.6;
            double jeniPercentage = 0.4;
            int requiredMoney = 60000000;
            Console.Write("Input Joni's money: ");
            int joniMoney = (int)(int.Parse(Console.ReadLine()) * joniPercentage);
            Console.Write("Input Jeni's money: ");
            int jeniMoney = (int)(int.Parse(Console.ReadLine()) * jeniPercentage);
            Console.Write("Input growth rate (in percentages, without the percent sign): ");
            double growthRate = double.Parse(Console.ReadLine()) / 100;

            int mergedMoney = joniMoney + jeniMoney;
            int storedMoney = 0;

            for (int i = 0; i < 2; i++)
            {
                storedMoney += mergedMoney;

                if (i > 0)
                    storedMoney += (int)(storedMoney * growthRate);
            }

            if (storedMoney < requiredMoney)
                Console.WriteLine("They can't get married in the 2th year");
            else
                Console.WriteLine("They can get married in the 2th year");

            Console.ReadKey(true);
            Console.Clear();
            goto BEGIN;
        }
    }
}
