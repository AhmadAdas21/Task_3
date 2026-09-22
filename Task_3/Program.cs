using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_3
{
    

    internal class Program
    {
        
        List<order>orders=new List<order>();

        static void Main(string[] args)
        {
            bool ok = true;

            services service = new services();

            while (ok)
            {
                Console.WriteLine("************************");
                Console.WriteLine("select one of our features");
                Console.WriteLine("1 make an order");
                Console.WriteLine("2 view all orders");
                Console.WriteLine("3 search for an order");
                Console.WriteLine("4 show orders above the amount");
                Console.WriteLine("5 show completed orders");
                Console.WriteLine("6 sort orders by amount");
                Console.WriteLine("7 sort orders by date");
                Console.WriteLine("8 calculate total amount of the orders");
                Console.WriteLine("9 group orders by customers");
                Console.WriteLine("10 exit");

                int d;

                if (!int.TryParse(Console.ReadLine(), out d))
                {
                    Console.WriteLine("enter a valid choice between 1 and 10");
                    continue;
                }

                switch (d)
                {
                    case 1:
                        service.make_order();
                        break;

                    case 2:
                        service.view_all();
                        break;

                    case 3:
                        service.search_order();
                        break;

                    case 4:
                        service.show_order();
                        break;

                    case 5:
                        service.completed_orders();
                        break;

                    case 6:
                        service.sort_order_by_amount();
                        break;

                    case 7:
                        service.sort_order_by_date();
                        break;

                    case 8:
                        service.total_amount();
                        break;

                    case 9:
                        service.group_orders_by_customers();
                        break;

                    case 10:
                        Console.WriteLine("thank you for using our system");
                        ok = false;
                        break;

                    default:
                        Console.WriteLine("choose a number between 1 and 10");
                        break;
                }
            }
        }




    }
}
