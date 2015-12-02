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
            bool isInt = true;
            List<TaxAvto> taxi = new List<TaxAvto>();

            while (b)
            {
                Console.WriteLine("1.Read");
                Console.WriteLine("2.Write");
                Console.WriteLine("3.Print taxi list");
                Console.WriteLine("4.Price of TaxPark");
                Console.WriteLine("5.Print list sorted by FuelConsumption ");
                Console.WriteLine("6.Search avto");
                Console.WriteLine("7.Delete avto");
                Console.WriteLine("8.Exit\n");

                isInt = Int32.TryParse(Console.ReadLine(), out ch);
                try
                {
                    if (isInt)
                    {

                        switch (ch)
                        {
                            case 1:
                                Console.WriteLine("PLease enter name of file:");
                                string nameofFile = Console.ReadLine() + ".txt";

                                taxi = Util.Read(nameofFile);//Read from file
                                break;
                            case 2:
                                    taxi = Util.Write(taxi);
                                break;
                            case 3:
                                if(taxi.Count==0)
                                {
                                    Console.WriteLine("PLease read file");
                                }
                                else
                                { 
                                Util.ShowList(taxi);
                                }
                                break;
                            case 4:
                                Util.Price(taxi);
                                break;
                            case 5:
                                Util.ShowSortedListbyConsumption(taxi);
                                break;
                            case 6:
                                Util.SearchBy(taxi);
                                break;
                            case 7:
                                taxi = Util.Delete(taxi);
                                break;
                            case 8:
                                b = false;
                                break;
                            default:
                                Console.WriteLine("Incorrect choice");
                                break;
                        }

                    }

                    else
                    {
                        throw new MyException("Digits only!");
                    }
                }catch(MyException ex)
                {
                    Console.WriteLine("Error:"+ex.Message);
                }
            }

        }

    }
}
    
