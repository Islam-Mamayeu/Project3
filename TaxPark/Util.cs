using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPark
{
    static class Util
    {



        public static List<TaxAvto> Write(List<TaxAvto> taxi)
        {
            TaxAvto objTaxAvto = new TaxAvto() ;//object for writing

            Console.WriteLine("Enter name of file :");
            String nameofFile = Console.ReadLine()+".txt";

            int i = 0;
            if (nameofFile == ".txt")
            {
                Console.WriteLine("Enter correct name of File!");

            }
            else
            {
                FileInfo file = new FileInfo("C:\\Users\\Islam_Mamayeu@epam.com\\Documents\\Visual Studio 2015\\Projects\\" + nameofFile);

                if (file.Exists == false)
                {
                    file.Create();
                    Console.WriteLine("File is created");
                }

                Console.WriteLine("Model: ");
                objTaxAvto.model = Console.ReadLine();

                Console.WriteLine("Type: ");
                objTaxAvto.type = Console.ReadLine();

                Console.WriteLine("FuelType: ");
                objTaxAvto.fueltype = Console.ReadLine();

                Console.WriteLine("FuelConsumption: ");
                objTaxAvto.fuelConsumption = Double.Parse(Console.ReadLine());

                Console.WriteLine("Price: ");
                objTaxAvto.price = Int32.Parse(Console.ReadLine());

                Console.WriteLine("SeatCount: ");
                objTaxAvto.seatCount = Int32.Parse(Console.ReadLine());

                Read(nameofFile);

                
                StreamWriter sw;

                    sw = file.AppendText();
                    sw.Write(objTaxAvto.model + " ");
                    sw.Write(objTaxAvto.type + " ");
                    sw.Write(objTaxAvto.fueltype + " ");
                    sw.Write(objTaxAvto.fuelConsumption + " ");
                    sw.Write(objTaxAvto.price + " ");
                    sw.WriteLine(objTaxAvto.seatCount);
                    sw.Close();
                taxi.Add(objTaxAvto);

            }
            return taxi;
        }
        public static List<TaxAvto> Read(string nameofFile)
        {
            List<TaxAvto> ListFromFile = new List<TaxAvto>();

            try {
                StreamReader sr = new StreamReader("C:\\Users\\Islam_Mamayeu@epam.com\\Documents\\Visual Studio 2015\\Projects\\" + nameofFile);
            
        
                List<string> listTax = new List<string>();//list of rows in file

                int i = 0;
                while (!sr.EndOfStream)
                {
                    listTax.Add(sr.ReadLine());
                }
                for (int j = 0; j < listTax.Count; j++)
                {
                    TaxAvto ta = new TaxAvto();
                    string[] str;
                    str = listTax[j].Split(' ');

                    for (i = 0; i < str.Length -1 ; i++)
                    {
                        ta.model = str[i++];
                        ta.type = str[i++];
                        ta.fueltype = str[i++];
                        ta.fuelConsumption = double.Parse(str[i++]);
                        ta.price = Int32.Parse(str[i++]);
                        ta.seatCount = Int32.Parse(str[i++]);
                        ListFromFile.Add(ta);
                    }

                }
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("File is not exsist!");

            }
            
            return ListFromFile;

        }
        public static void Price(List<TaxAvto> taxi)
        {
            double priceResult=0;

            for(int i=0;i<taxi.Count;i++)
            {
                priceResult +=taxi[i].price;

            }
            Console.WriteLine("The Park costs :" + priceResult);

        }
        public static List<TaxAvto> Add()
        {
            List<TaxAvto> taxi = new List<TaxAvto>();
            taxi.Add(new TaxAvto("Mercedes", "Minivan", "Diesel", 15.5, 10000, 7));
            taxi.Add(new TaxAvto("Toyota", "sedan", "Gas", 11.5, 100000, 5));
            taxi.Add(new TaxAvto("Dodge", "Minivan", "Gas", 12.5, 100000, 7));
            taxi.Add(new TaxAvto("Lada", "sedan", "Backlagan", 8.5, 5000, 5));
            taxi.Add(new TaxAvto("Audio", "Hatchback", "Gas", 17, 12000, 5));
            taxi.Add(new TaxAvto("Chrysler", "Minivan", "Gas", 16.7, 11000, 6));
            return taxi;


        }
        public static void ShowList(List<TaxAvto> taxi)
        {
            for (int i = 0; i < taxi.Count; i++)
            {
                Console.WriteLine(i + 1 + ":");
                Console.WriteLine("Name: " + taxi[i].model);
                Console.WriteLine("Type: " + taxi[i].type);
                Console.WriteLine("Fuel: " + taxi[i].fueltype);
                Console.WriteLine("Fuel Cunsumption: " + taxi[i].fuelConsumption);
                Console.WriteLine("Price: " + taxi[i].price);
                Console.WriteLine("Seat Count: " + taxi[i].seatCount);           


            }
        }
        public static void SearchShow(TaxAvto taxi,int i)
        {
            Console.WriteLine(i+1 + ":");
            Console.WriteLine("Name: " + taxi.model);
            Console.WriteLine("Type: " + taxi.type);
            Console.WriteLine("Fuel: " + taxi.fueltype);
            Console.WriteLine("Fuel Cunsumption: " + taxi.fuelConsumption);
            Console.WriteLine("Price: " + taxi.price);
            Console.WriteLine("Seat Count: " + taxi.seatCount);

        }
        public static void ShowSortedListbyConsumption(List<TaxAvto> taxi)
        {

         taxi.Sort((p1, p2) => p1.fuelConsumption.CompareTo(p2.fuelConsumption));

            Console.WriteLine("Sorted by fuelComsumtion : ");
            
            for (int i = 0; i < taxi.Count; i++)
            {
                Console.WriteLine(i + 1 + ":");
                Console.WriteLine("Name: " + taxi[i].model);
                Console.WriteLine("Type: " + taxi[i].type);
                Console.WriteLine("Fuel: " + taxi[i].fueltype);
                Console.WriteLine("Fuel Cunsumption: " + taxi[i].fuelConsumption);
                Console.WriteLine("Price: " + taxi[i].price);
                Console.WriteLine("Seat Count: " + taxi[i].seatCount);

            }

        }
        public static void SearchBy(List<TaxAvto> taxi)
        {
            String choice = null;
            int ch=0;
            bool b = true;
            while (b)
            {
                bool IsInt = true;
                int counter = 0;
                Console.WriteLine("\nSearch :");
                Console.WriteLine("1.By price:");
                Console.WriteLine("2.By Fuelconsumption :");
                Console.WriteLine("3.By Fueltype:");
                Console.WriteLine("4.By model:");
                Console.WriteLine("5.Return:");

                choice = Console.ReadLine();
               
                    switch (choice)
                    {
                       case "1":
                        counter = 0;
                            int price = 0;
                            Console.WriteLine("Enter price :");
                            IsInt = Int32.TryParse(Console.ReadLine(), out price);
                            if (IsInt)
                            {
                                for (int i = 0; i < taxi.Count; i++)
                                {
                                    if (taxi[i].price <= price)
                                    {
                                        SearchShow(taxi[i], i);
                                    counter++;
                                    }

                                }
                            if (counter == 0) Console.WriteLine("No matches!");
                            }
                            else
                            {
                                Console.WriteLine("Incorrect price!");
                            }

                            break;
                    case "2":
                        counter = 0;
                        int fuelConsumption = 0;
                        Console.WriteLine("Enter FuelConsumption :");
                        IsInt = Int32.TryParse(Console.ReadLine(), out fuelConsumption);
                        if (IsInt)
                        {

                            for (int i = 0; i < taxi.Count; i++)
                            {
                                if (taxi[i].fuelConsumption <= fuelConsumption)
                                {
                                    SearchShow(taxi[i], i);
                                    counter++;
                                }

                            }
                            if (counter == 0) Console.WriteLine("No matches!");
                        }
                        else
                        {
                            Console.WriteLine("Digits Only!");
                        }
                        break;
                        case "3":
                        
                            Console.WriteLine("Enter Fueltype(Gas,Diesel):");
                            while (true)
                            {


                                String fuelType = Console.ReadLine();
                                if (fuelType == "Gas" || fuelType == "Diesel")
                                {
                                    for (int i = 0; i < taxi.Count; i++)
                                    {
                                        if (taxi[i].fueltype == fuelType)
                                        {
                                            SearchShow(taxi[i], i);
                                            counter++;
                                        }

                                    }
                                    if (counter == 0)
                                    {
                                        Console.WriteLine("No matches!");
                                        break;
                                    }
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("PLease enter (Gas or Diesel)");
                                }
                                
                            }
                        break;

                    case "4":
                            Console.WriteLine("Enter model:");
                       
                            String model = Console.ReadLine();
                           
                                for (int i = 0; i < taxi.Count; i++)
                                {
                                    if (taxi[i].model== model)
                                    {
                                        SearchShow(taxi[i], i);
                                        counter++;
                                    }

                                }
                                if (counter == 0)
                                {
                                    Console.WriteLine("No matches!");
                                    break;
                                }
                        break;
   
                    case "5":
                        b = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect choice,Please try again!");
                        break;
                    }
                }
            

           

        }
        public static List<TaxAvto> Delete(List<TaxAvto> taxi)
        {

            Console.WriteLine("Please type index of avto:");
            try
            {
              int indexOfTaxi= Int32.Parse(Console.ReadLine());

                taxi.RemoveAt(indexOfTaxi);

            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("No matches!");
            }
            catch(SystemException e)
            {
                Console.WriteLine("Only Digits!");

            }

            return taxi;

        }

    }
    }

