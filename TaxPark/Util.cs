using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPark
{
    static class Util
    {




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

