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

namespace customTemplate
{
    class Investment
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public int Return { get; set; }

        public Investment(string _name, int _amount, int _return)
        {
            Name = _name;
            Amount = _amount;
            Return = _return;
        }

        public decimal calculateInvestmentReturn(int investingYear)
        {
            decimal result = this.Amount;
            decimal returnPercent = (decimal)this.Return / 100;
            for (int i = 0; i < investingYear; i++)
            {
                result += result * returnPercent;
            }

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        BEGIN:
            Console.Write("Invest Name: ");
            var investName = Console.ReadLine();
            Console.Write("Invest Name: ");
            var investReturn = int.Parse(Console.ReadLine());
            Console.Write("Invest Name: ");
            var investAmount = int.Parse(Console.ReadLine());
            Console.Write("Invest Name: ");
            var numberOfYears = int.Parse(Console.ReadLine());

            Investment investmentObject = new Investment(investName, investAmount, investReturn);
            var test = investmentObject.calculateInvestmentReturn(20);

            Console.ReadKey(true);
            Console.Clear();
            goto BEGIN;
        }
    }
}
