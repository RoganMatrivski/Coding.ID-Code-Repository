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

namespace SellingD
{
    class Drugs
    {
        public int HargaApotik { get; set; }
        public int JumlahBeli { get; set; }
        public int HargaPerTablet { get; set; }
        private const int tabletPerStrip = 12;

        public Drugs(int apothecaryPrice, int buyAmount, int perTabletPrice)
        {
            HargaApotik = apothecaryPrice;
            JumlahBeli = buyAmount;
            HargaPerTablet = perTabletPrice;
        }

        public int calculateProfit()
        {
            int buyPrice = HargaApotik * JumlahBeli;
            int sellPrice = (JumlahBeli * tabletPerStrip) * HargaPerTablet;

            return sellPrice - buyPrice;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        BEGIN:
            Console.Write("Harga Apotik [Strip]: ");
            int apothecaryPrice = int.Parse(Console.ReadLine());
            Console.Write("Jumlah Beli [Strip]: ");
            int buyAmount = int.Parse(Console.ReadLine());
            Console.Write("Harga Jual/Tablet: ");
            int perTabletPrice = int.Parse(Console.ReadLine());

            Drugs drugObject = new Drugs(apothecaryPrice, buyAmount, perTabletPrice);
            int profit = drugObject.calculateProfit();

            Console.WriteLine("Jumlah Keuntungan: Rp. {0}", profit);

            Console.ReadKey(true);
            Console.Clear();
            goto BEGIN;
        }
    }
}
