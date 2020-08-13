/*
 * Created by SharpDevelop.
 * User: NAWADATA
 * Date: 29/03/2020
 * Time: 18:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace _TEMPLATE_
{
    public class Car
    {
        private string name;
        private int speed;
        public Car(int param_speed, string param_name)
        {
            //TODO: Add code here
            //your code here
            //set speed and name
            this.speed = param_speed;
            this.name = param_name;

        }

        public int Speed
        {
            get
            {
                return speed;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }
    }

    public class Race
    {
        private string name;
        private int length;
        private List<Car> listCar;

        public List<Car> ListCar
        {
            get
            {
                return listCar;
            }
        }

        public Race(string param_name, int param_length)
        {
            //TODO: Add code here
            //your code here
            //set name, length, and initiate list
            this.name = param_name;
            this.length = param_length;
            this.listCar = new List<Car>();
        }

        public void proRace()
        {
            Dictionary<string, int> carPosition = new Dictionary<string, int>(this.listCar.Count);
            for (int x = 1; true; x++)
            {
                Console.WriteLine("Current Position for Loop " + x);
                //TODO: Add code here
                //your code here
                //loop per car and show current position for each car

                bool raceEnd = false;

                foreach (var car in this.listCar)
                {
                    if (carPosition.ContainsKey(car.Name))
                    {
                        carPosition[car.Name] += car.Speed;
                    }
                    else
                    {
                        carPosition.Add(car.Name, car.Speed);
                    }

                    Console.Write("Current position for car {0} is {1}\n", car.Name, carPosition[car.Name]);

                    if (carPosition[car.Name] > this.length)
                    {
                        Console.WriteLine("The winner is car {0}", car.Name);
                        raceEnd = true;
                        break;
                    }
                }

                if (raceEnd)
                {
                    break;
                }
            }

        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
        Begin:

            Console.Write("Race Name? ");
            string race_name = Console.ReadLine();

            Console.Write("Length for " + race_name + "? ");
            int race_length = Convert.ToInt16(Console.ReadLine());

            //TODO: Add code here
            //your code here
            //create object of Race
            Race objRace = new Race(race_name, race_length);

            //TODO: Add code here
            //your code here
            //input cars

            Console.Write("How many cars? ");
            int carCount = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < carCount; i++)
            {
                Console.Write("Car Name? ");
                string carName = Console.ReadLine();

                Console.Write("Speed for Car " + carName + "? ");
                int carSpeed = Convert.ToInt16(Console.ReadLine());

                objRace.ListCar.Add(new Car(carSpeed, carName));
            }

            Console.WriteLine();

            //TODO: Add code here
            //your code here
            //Show race result
            objRace.proRace();

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
            Console.Clear();
            goto Begin;
        }
    }
}
