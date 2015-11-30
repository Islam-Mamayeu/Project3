using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPark
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int ch = 0;
            bool b = true;
            bool isInt;

            List<TaxAvto> taxi = Util.Add();

            while (b)
                {
                    Console.WriteLine("\n1.Print taxi list");
                    Console.WriteLine("2.Price of TaxPark");
                    Console.WriteLine("3.Print list sorted by FuelConsumption ");
                    Console.WriteLine("4.Search avto");
                    Console.WriteLine("5.Delete avto");
                    Console.WriteLine("6.Exit\n");

                    isInt = Int32.TryParse(Console.ReadLine(), out ch);

                    if (isInt)
                    {

                        switch (ch)
                        {
                            case 1:
                                Util.ShowList(taxi);
                                break;
                            case 2:
                                Util.Price(taxi);
                                break;
                            case 3:
                                Util.ShowSortedListbyConsumption(taxi);
                                break;
                            case 4:
                                Util.SearchBy(taxi);
                                break;                        
                            
                            case 5:
                            try
                            {
                                taxi = Util.Delete(taxi); 
                            }
                            catch(MyException e)
                            {
                                e.listNotFoundException();
                            }
                           

                            break;
                            case 6:
                            b = false;
                            break;

                        default:
                                Console.WriteLine("Incorrect choice");
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Please try again!:");
                    }
                }
            }



            }

        }
    
