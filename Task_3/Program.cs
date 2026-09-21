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
        bool ok = true;
        int c;
        List<order>orders=new List<order>();

        static void Main(string[] args)

        {

            while (ok)
            {
                Console.WriteLine("************************");
                Console.WriteLine("select one of our features");
                Console.WriteLine("1 make an oreder");
                Console.WriteLine("2 view all orders");
                Console.WriteLine("3 search for an order");
                Console.WriteLine("4  show orders above the amount");
                Console.WriteLine("show completed orders");
                Console.WriteLine("6 sort orders by amount");
                Console.WriteLine("7 sort orders by date");
                Console.WriteLine("8 calculate total amount of the order");
                Console.WriteLine("9 group orders by customers");
                Console.WriteLine("10 exit");
                int d;
                if (int.TryParse(args[0], out d))
                {
                    Console.WriteLine("you choice has received");
                }
                else
                {
                    Console.WriteLine("enter a valid choice between 1 and 9");
                }
                switch (d)
                {
                    case 1:make_order();break;
                    case 2:view_all() break;
                    case 3: search_order();break;
                    case 4: show_order();break;
                    case 5: completed_orders();break;
                    case 6:sort_order_by_amount();break;
                    case 7:sort_order_by_date();break;
                    case 8:total_amount();break;
                    case 9:group_orders_by_customers();break;
                    case 10:Console.WriteLine("thank you for using our system");ok = false;break;


                }
            }
            
        }



       
    }
}
