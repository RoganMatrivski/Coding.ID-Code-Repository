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

namespace Overriding
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

        public virtual void getInfo()
        {
            Console.WriteLine("{0} has {1} legs and has a {2}", this.name, this.legs, this.color);
        }

        public virtual void getVoice()
        {
            Console.WriteLine("Guguk");
        }
    }

    class Duck : Animal
    {
        public Duck()
        {
            this.Name = "Duck";
            this.Legs = 2;
            this.Color = "White";
        }

        public override void getInfo()
        {
            Console.WriteLine("This is information of {0}", this.Name);
            Console.WriteLine("{0} have {1} legs", this.Name, this.Legs);
        }

        public override void getVoice()
        {
            Console.WriteLine("Koek koek");
        }
    }

    class Cat : Animal
    {
        public Cat()
        {
            this.Name = "Cat";
            this.Legs = 4;
            this.Color = "Black";
        }

        public override void getInfo()
        {
            Console.WriteLine("This is information of {0}", this.Name);
            Console.WriteLine("{0} have {1} legs", this.Name, this.Legs);
        }

        public override void getVoice()
        {
            Console.WriteLine("Meong Meong");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        BEGIN:
            Duck duck = new Duck();
            Cat cat = new Cat();

            duck.getInfo();
            duck.getVoice();
            cat.getInfo();
            cat.getVoice();

            Console.ReadKey(true);
            Console.Clear();
            goto BEGIN;
        }
    }
}
