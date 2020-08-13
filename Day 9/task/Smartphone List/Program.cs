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

namespace SmartphoneL
{
    class Smartphone
    {
        public string Name { get; set; }
        public int ROM { get; set; }
        public int RAM { get; set; }

        private const int pricePerROM = 100000;
        private const int pricePerRAM = 150000;

        public int getPrice()
        {
            return (ROM * pricePerROM) + (RAM * pricePerRAM);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        BEGIN:
            Console.Write("Insert number count: ");
            int numberCount = int.Parse(Console.ReadLine());

            List<Smartphone> smartphones = new List<Smartphone>();

            for (int i = 0; i < numberCount; i++)
            {
                Smartphone newSmartphone = new Smartphone();

                Console.Write("Smartphone name #{0}: ", i + 1);
                newSmartphone.Name = Console.ReadLine();
                Console.Write("Smartphone ROM: ");
                newSmartphone.ROM = int.Parse(Console.ReadLine());
                Console.Write("Smartphone RAM: ");
                newSmartphone.RAM = int.Parse(Console.ReadLine());

                smartphones.Add(newSmartphone);
                Console.WriteLine();
            }

            foreach (var phone in smartphones)
            {
                Console.WriteLine("The price of smartphone {0} with ROM {1} GB and RAM {2} GB is Rp. {3}", phone.Name, phone.ROM, phone.RAM, phone.getPrice());
            }

            Console.ReadKey(true);
            Console.Clear();
            goto BEGIN;
        }
    }
}
