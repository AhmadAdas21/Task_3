using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class services :Iservices
    {

        //ateTime datee= new DateTime();
        List<order> orders = new List<order>();
        public void make_order()
        {
            int idd;
            Console.WriteLine("enter the id of the order");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out idd))
                {
                    Console.WriteLine("well done you have entrted the id correctly");
                    break;
                }
                else
                {
                    Console.WriteLine("enter the id num correctly");
                }
            }
            Console.WriteLine("enter your name");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("enter the all amount of the order");
            float amounte;
            while (true)
            {
            if(float.TryParse(Console.ReadLine(),out amounte))
                {
                    Console.WriteLine("well done you hva enterd the amount");break;
                }
            }
            Console.WriteLine("enter the status of the order:");
            Console.WriteLine("1-completed");
            Console.WriteLine("2-pending");
            int st;
            bool status;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out st))
                {
                    Console.WriteLine("you enterd the statues correctly");

                    if (st == 1)
                    {
                        status = true;
                        break;
                    }
                    else if (st == 2)
                    {
                        status = false; break;
                    }
                    else
                    {
                        Console.WriteLine("enter the status correctly 1 or 2 just");
                    }
                    
                }
            }
            

           DateTime dateTime = DateTime.Now;

            order ord = new order(idd, name, amounte, status, dateTime);
            orders.Add(ord);
        //  idd++;

        }
        public void view_all()
        {
            foreach (var i in orders)
            {
                Console.WriteLine(i.id + " " + i.customer_name);

            }

        }
        public void search_order()
        {
            Console.WriteLine("pls enter the id of the order you want to search abou");
            int iddd;
            while (true)
            {
                if(int.TryParse(Console.ReadLine(),out iddd))
                {
                    Console.WriteLine("the number enterd correctly");break;
                }
            }
            var ord = orders.FirstOrDefault(x => x.id == iddd);
            Console.WriteLine(ord);
            
        }
        public void show_order()
        {
            Console.WriteLine("enter the amount that you want the orders be above");
            float amoountt;
            while (true)
            {
                if (float.TryParse(Console.ReadLine(), out amoountt))
                {
                    Console.WriteLine("ok"); break;
                }
            }
            /*  foreach(var s in orders)
                {
                    if (s.amount > amoountt)
                    {
                        Console.WriteLine(s.id);
                        Console.WriteLine(s.customer_name + " " + s.amount);
                        Console.WriteLine(s.statues);
                    }
                }
            */

            var e = orders.Where(x => x.amount > amoountt);
            // Console.WriteLine(e);
            foreach (var n in e)
            {
                Console.WriteLine(n.id + " " + n.customer_name + "   " + n.amount);
            }
        }
        public void completed_orders()
        {
            var completed = orders.Where(x => x.statues == true).ToList();
            foreach (var n in completed)
            {
                Console.WriteLine(n.id + " " + n.customer_name+"   " + n.amount);
            }
        }
        public void sort_order_by_amount()
        {
            var sor = orders.OrderBy(x=>x.amount).ToList();
            foreach (var n in sor)
            {
                Console.WriteLine(n.id + " "+ "   " + n.amount);
            }


        }
        public void sort_order_by_date()
        {
            var da=orders.GroupBy(x=>x.created_Date).ToList();
            foreach (var group in da)
            {
                Console.WriteLine($"Orders for Date: {group.Key}");
                foreach (var order in group)
                {
                    Console.WriteLine(order.id + " " + order.customer_name + " " + order.amount);
                }
            }
        }
        public void total_amount()
        {
            var sum=orders.Sum(x=>x.amount);
            Console.WriteLine(sum);

        }
        public void group_orders_by_customers()
        {
            
            var customers=orders.GroupBy(x=>x.customer_name).ToList();
            foreach (var group in customers)
            {
                Console.WriteLine("Customer: " + group.Key);

                foreach (var order in group)
                {
                    Console.WriteLine(
                        order.id + " " +
                        order.amount
                    );
                }
            }
        }
    }
}
