/*
 * Created by SharpDevelop.
 * User: NAWADATA
 * Date: 28/03/2020
 * Time: 19:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace _TEMPLATE_
{
    public class Mall
    {
        private List<Store> listStore;
        private string name;

        public Mall(string param_name)
        {
            //TODO: Add code
            this.listStore = new List<Store>();
            this.name = param_name;
        }

        public List<Store> ListStore
        {
            //TODO: Add code
            set { listStore = value; }
            get { return listStore; }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

    }

    public class Store
    {
        private List<Smartphone> listPhone;
        private string name;

        public Store(string param_name)
        {
            listPhone = new List<Smartphone>();
            name = param_name;
        }

        public List<Smartphone> ListPhone
        {
            set { listPhone = value; }
            get { return listPhone; }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

    }

    public class Smartphone
    {
        private string name;
        private int rom;
        private int ram;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Rom
        {
            get { return rom; }
            set { rom = value; }
        }
        public int Ram
        {
            get { return ram; }
            set { ram = value; }
        }
        public int Calculate()
        {
            int price = (100000 * Rom) + (150000 * Ram);
            return price;
        }
    }

    class Program
    {
        public static Store insertStoreData()
        {
            Console.Write("What is Store Name ? ");
            string store_name = Console.ReadLine();
            Store objStore = new Store(store_name);

            //TODO: Add code
            Console.Write("How many smartphones? ");
            int phoneCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < phoneCount; i++)
            {
                Smartphone newSmartphone = new Smartphone();

                Console.Write("Smartphone name #{0}: ", i + 1);
                newSmartphone.Name = Console.ReadLine();
                Console.Write("Smartphone ROM: ");
                newSmartphone.Rom = int.Parse(Console.ReadLine());
                Console.Write("Smartphone RAM: ");
                newSmartphone.Ram = int.Parse(Console.ReadLine());

                objStore.ListPhone.Add(newSmartphone);
            }

            return objStore;
        }

        public static Mall insertMallData()
        {
            Console.Write("What is Mall Name ? \n");
            string mal_name = Console.ReadLine();
            Mall objMall = new Mall(mal_name);

            //TODO: Add code
            Console.Write("How many Store for {0}? ", mal_name);
            int storeCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < storeCount; i++)
            {
                Store newStore = insertStoreData();

                objMall.ListStore.Add(newStore);
            }

            return objMall;
        }

        public static void Main(string[] args)
        {
        Begin:
            Console.Write("How many Mall ? ");
            string jml_mall = Console.ReadLine();

            List<Mall> listMall = new List<Mall>();

            for (int y = 0; y < Convert.ToInt16(jml_mall); y++)
            {
                //TODO: Add code
                //Insert Mall to listMall
                listMall.Add(insertMallData());
            }

            foreach (Mall mall in listMall)
            {
                //TODO: Add code
                // Display List Store and Smartphone from each Store 
                Console.WriteLine("This is List Store from Mall {0}", mall.Name);
                foreach (Store store in mall.ListStore)
                {
                    Console.WriteLine("This is List Stock from Store {0}", store.Name);
                    foreach (Smartphone phone in store.ListPhone)
                    {
                        Console.WriteLine("The Price of Smartphone {0} with ROM {1} GB and RAM {2} GB is Rp {3}", phone.Name, phone.Rom, phone.Ram, phone.Calculate());
                    }
                }

                //TODO: Add code
                //4. Display List Stock from each Store
                /*
                    Format
                    This is List Stock from [Store Name]

                    The Price of Smartphone [Smartphone Name] with ROM [Rom]GB and RAM [Ram]GB is Rp [Harga]
                    The Price of Smartphone [Smartphone Name] with ROM [Rom]GB and RAM [Ram]GB is Rp [Harga]
                */

            }

            Console.WriteLine();
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
            Console.Clear();
            goto Begin;
        }
    }
}
