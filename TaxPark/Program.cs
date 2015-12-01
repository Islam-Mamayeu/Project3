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

            List<TaxAvto> taxi = Util.Add();

            while (b)
            {
                Console.WriteLine("1.Add");
                Console.WriteLine("2.Print taxi list");
                Console.WriteLine("3.Price of TaxPark");
                Console.WriteLine("4.Print list sorted by FuelConsumption ");
                Console.WriteLine("5.Search avto");
                Console.WriteLine("6.Delete avto");
                Console.WriteLine("7.Exit\n");

                isInt = Int32.TryParse(Console.ReadLine(), out ch);
                try
                {
                    if (isInt)
                    {

                        switch (ch)
                        {
                            case 1:
                               taxi = Util.ReadWriteFile(taxi);
                                break;
                            case 2:
                                Util.ShowList(taxi);
                                break;
                            case 3:
                                Util.Price(taxi);
                                break;
                            case 4:
                                Util.ShowSortedListbyConsumption(taxi);
                                break;
                            case 5:
                                Util.SearchBy(taxi);
                                break;
                            case 6:
                                taxi = Util.Delete(taxi);
                                break;
                            case 7:
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
    
