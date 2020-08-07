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

namespace CreditS
{
    class Program
    {
        static void Main(string[] args)
        {
        BEGIN:
            Console.Write("Business Type: ");
            double businessType = Convert.ToInt32(Console.ReadLine());
            Console.Write("Monthly Income: ");
            double monthlyIncome = Convert.ToInt32(Console.ReadLine());
            Console.Write("Domicile: ");
            double domicile = Convert.ToInt32(Console.ReadLine());

            businessType *= 0.5;
            monthlyIncome *= 0.3;
            domicile *= 0.2;

            double total_value = businessType + monthlyIncome + domicile;
            char creditScore;

            if (total_value <= 60)
                creditScore = 'D';
            else
            if (total_value <= 75)
                creditScore = 'C';
            else
            if (total_value <= 90)
                creditScore = 'B';
            else
                creditScore = 'A';

            Console.WriteLine("Total Value: {0}", total_value);
            Console.WriteLine("Credit Score: {0}", creditScore);

            Console.ReadKey(true);
            Console.Clear();
            goto BEGIN;
        }
    }
}
