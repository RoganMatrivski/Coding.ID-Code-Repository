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

namespace CreateBC1
{
    class Animal
    {
        private string name;
        private int legs;
        private string color;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Legs
        {
            get { return legs; }
            set { legs = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public void getInfo()
        {
            Console.WriteLine("This is information of {0}", this.Name);
            Console.WriteLine("{0} has {1} legs and has a {2}", this.name, this.legs, this.color);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        BEGIN:
            Console.Write("Name: ");
            string objName = Console.ReadLine();
            Console.Write("Legs: ");
            int objLegs = int.Parse(Console.ReadLine());
            Console.Write("Color: ");
            string objColor = Console.ReadLine();

            Animal _animal = new Animal();
            _animal.Name = objName;
            _animal.Legs = objLegs;
            _animal.Color = objColor;

            _animal.getInfo();

            Console.ReadKey(true);
            Console.Clear();
            goto BEGIN;
        }
    }
}
