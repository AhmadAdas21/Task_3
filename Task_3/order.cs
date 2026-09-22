using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    
    internal class order
    {
        public int id { get; set; }
        public string customer_name { get; set; }
        public float amount { get; set; }
        public bool statues { get; set; }
        public DateTime created_Date { get; set; }

        public order(int id, string customer_name, float amount, bool statues, DateTime created_Date)
        {
            this.id = id;
            this.customer_name = customer_name;
            this.amount = amount;
            this.statues = statues;
            this.created_Date = created_Date;


        
        }

    }
}
