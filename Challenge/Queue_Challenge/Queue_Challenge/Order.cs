using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Challenge
{
    internal class Order
    {
        //create properties
        public int OrderId { get; set; }
        public int OrderQuantity { get; set; }

        //simple constructor
        public Order(int id, int quantity)
        {
            OrderId = id;
            OrderQuantity = quantity;
        }

        //simple method - message that prints order was a success message
        public void ProcessedOrder()
        {
            Console.WriteLine($"\nOrder: {OrderId}, was processed successfully.");

            //you can do other things here like sending out an email to a customer, events etc
        }
    }
}
