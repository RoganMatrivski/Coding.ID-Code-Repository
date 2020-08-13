/*
 * Created by SharpDevelop.
 * User: NAWADATA
 * Date: 29/03/2020
 * Time: 13:55
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

        public Mall()
        {
            listStore = new List<Store>();
        }

        public List<Store> ListStore
        {
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
        private List<Transaction> listTrans;
        private string name;
        private double cash;

        public Store()
        {
            listPhone = new List<Smartphone>();
            listTrans = new List<Transaction>();
            cash = 0;
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

        public void displaySmartphoneList()
        {
            Console.WriteLine("This is List Stock from " + name);

            foreach (Smartphone item in listPhone)
            {
                Console.WriteLine("The Price of Smartphone " + item.Name + " - " + item.SmartphoneCode + " with ROM " + item.Rom + " GB and RAM " + item.Ram + " GB is Rp " + item.Calculate());
            }

            Console.WriteLine();

        }

        public void setTransaction(string code)
        {
            //TODO: Add code
            //Search smartphone from Store
            //If Found, add to transaction list and display "Transaction Success"
            //If Not Found, display "Code Not Found"
            var found = this.listPhone.Find(e => e.SmartphoneCode == code);
            if (found == null)
            {
                Console.WriteLine("Code Not Found");
                //TODO: Ask the coach if i should end the program or nah
            }

            Console.Write("How many Smartphone with code {0}? ", code);
            int phoneCount = int.Parse(Console.ReadLine());

            this.listTrans.Add(new Transaction(found, phoneCount));
        }

        public double getProfit()
        {
            //TODO: Add code
            //Profit 20% dari total

            double totalSale = 0;
            foreach (Transaction transaction in this.listTrans)
            {
                totalSale += transaction.getTotal();
            }

            return totalSale * 0.2;
        }

    }

    public class Transaction
    {
        private Smartphone objSmart;
        private int amount;

        public Transaction(Smartphone param_smart, int param_amount)
        {
            //TODO: Add code
            //Set objSmart and amount
            this.objSmart = param_smart;
            this.amount = param_amount;
        }

        public Smartphone ObjSmart
        {
            set
            {
                objSmart = value;
            }

            get
            {
                return objSmart;
            }
        }

        public double getTotal()
        {
            //TODO: Add code
            //Return [price of smartphone] * amount
            return this.objSmart.Calculate() * this.amount;
        }

    }

    public class Smartphone
    {
        private string name;
        private int rom;
        private int ram;
        private string smartphone_code;
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
        public string SmartphoneCode
        {
            set { smartphone_code = value; }
            get { return smartphone_code; }
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
            Store objStore = new Store();

            Console.Write("What is Store Name ?");
            objStore.Name = Console.ReadLine();

            Console.Write("How many Smartphone ?");
            string jml = Console.ReadLine();

            for (int x = 0; x < Convert.ToInt16(jml); x++)
            {
                //TODO: Add code
                //Create an object of Smartphone
                Smartphone item = new Smartphone();
                Console.Write("Smartphone Name ?");
                item.Name = Console.ReadLine();
                Console.Write("Smartphone Code ?");
                item.SmartphoneCode = Console.ReadLine();
                Console.Write("Smartphone ROM ?");
                item.Rom = Convert.ToInt16(Console.ReadLine());
                Console.Write("Smartphone RAM ?");
                item.Ram = Convert.ToInt16(Console.ReadLine());

                //Set List to object Store
                objStore.ListPhone.Add(item);
            }

            return objStore;

        }
        public static void Main(string[] args)
        {
        Begin:
            //TODO: Add code
            //Create Mall
            Mall objMall = new Mall();

            //Insert List Store
            Console.Write("How many Store for Mall? ");
            int storeCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < storeCount; i++)
            {
                Store newStore = insertStoreData();

                objMall.ListStore.Add(newStore);
            }

            //Insert data list smartphone to store


            //Loop Store to show List Stock from each Store
            foreach (Store store in objMall.ListStore)
            {
                Console.WriteLine("This is List Stock from Store {0}", store.Name);
                foreach (Smartphone phone in store.ListPhone)
                {
                    Console.WriteLine("The Price of Smartphone {0} with ROM {1} GB and RAM {2} GB is Rp {3}", phone.Name, phone.Rom, phone.Ram, phone.Calculate());
                }
            }



            //Loop Store to insert Transaction for each Store
            foreach (Store item in objMall.ListStore)
            {

                Console.Write("How many Transaction for Store " + item.Name + "?");
                string jml = Console.ReadLine();

                //TODO: Add code

                for (int i = 0; i < int.Parse(jml); i++)
                {
                    Console.Write("Smartphone code? ");
                    string phoneCode = Console.ReadLine();

                    item.setTransaction(phoneCode);
                }

            }

            Console.WriteLine();

            //TODO: Add code
            //Loop Store to show profit from each Store
            foreach (Store item in objMall.ListStore)
            {
                //TODO: Add code
                //Display Format => Profit from Store [Store Name] is [Store Profit]

                Console.WriteLine("Profit from store {0} is {1}", item.Name, item.getProfit());
            }
            Console.WriteLine();

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
            Console.Clear();
            goto Begin;
        }
    }
}
