using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    interface Iservices
    {
        void make_order();
        void view_all();
        void search_order();
        void show_order();
        void completed_orders();
        void sort_order_by_amount();
        void sort_order_by_date();
        void total_amount();
        void group_orders_by_customers();
    }
}
