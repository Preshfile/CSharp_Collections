namespace Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Queues are to be used when the order of the data is important

            //declare a queue - a queue is defined with a type because it is a generic collection
            Queue<int> myQueue = new Queue<int>();

            //trying to Dequeue an empty queue will result to an exception
            //So its advisable to check if the queue is not empty before dequeuing a queue

            if (myQueue.Count > 0)
            {
                myQueue.Dequeue();
            }
            else
            {
                Console.WriteLine("Queue is empty");
            }


            //Adding items to the queue using the Enqueue() method
            myQueue.Enqueue(20);
            //print the first item in the queue
            Console.WriteLine("\nThe first item in the queue is: {0}", myQueue.Peek());
            myQueue.Enqueue(30);
            Console.WriteLine("The first item in the queue is: {0}", myQueue.Peek());
            myQueue.Enqueue(40);
            Console.WriteLine("The first item in the queue is: {0}", myQueue.Peek());


            //Delete or remove an Item from the queue with the Dequeue() method
            int deletedItem = myQueue.Dequeue();
            Console.WriteLine("\nThe deleted item in front of the queue is: {0}", deletedItem);

            //print the new item in front of the queue
            Console.WriteLine("The first item in the queue is now: {0}", myQueue.Peek());


            //using a while loop to delete items from the queue until there are no items left
            //However, Clear method is preferred for such operation
            //myQueue.Clear();

            while (myQueue.Count > 0)
            {
                //remove an item from the queue
                Console.WriteLine("\nItem {0} was removed from the queue", myQueue.Dequeue());

                //Count the remaining items in the queue
                Console.WriteLine("\nWe have {0} item left in the queue", myQueue.Count);

            }
            Console.WriteLine("\nThe queue is empty\n");


            Console.ReadKey();

        }   
    }
}