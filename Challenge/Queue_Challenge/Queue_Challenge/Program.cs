namespace Queue_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n********** Order Processing Challenge **********\n");

            //Challenge
            //create a class named order to store instances of order from an E-commerce site
            Queue<Order> orderedOrder = new Queue<Order>();

            //Add all orders to the created queue
            //For Branch1
            foreach (Order branch1Order in ArrayOfOrdersBranch1())
            {
                orderedOrder.Enqueue(branch1Order);
            }

            //For Branch2
            foreach (Order branch2Order in ArrayOfOrdersBranch2())
            {
                orderedOrder.Enqueue(branch2Order);
            }


            //Process the orders and print
            //First check if the is not empty
            while (orderedOrder.Count > 0)
            {
                //Keep on removing the order at the front of the queue
                //and store in dequeuedOrder while at it
                Order dequeuedOrder = orderedOrder.Dequeue();

                //print an order process success message
                dequeuedOrder.ProcessedOrder();

            }

            Console.ReadKey();
        }

        //Create a method to return an array of orders from two branches
        static Order[] ArrayOfOrdersBranch1()
        {
            //Create a new order array
            Order[] orders = new Order[]
            {
                new Order(1, 4),
                new Order(20, 2),
                new Order(4, 10),
                new Order(81, 1),
                new Order(12, 1),
            };

            return orders;
        }
        static Order[] ArrayOfOrdersBranch2()
        {
            //Create a new order and initialize it with objects type of order
            Order[] orders = new Order[]
            {
                new Order(5, 8),
                new Order(11, 1),
                new Order(18, 2),
                new Order(3, 40),
                new Order(9, 5),
            };

            //return the array in the given order
            return orders;
        }
    }
}