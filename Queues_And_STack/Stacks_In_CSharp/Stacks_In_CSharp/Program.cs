namespace Stacks_In_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Defining a new stack
            Stack<int> intStackCollection = new Stack<int>();

            //calling a pop before adding an item to a stack will raise an exception because you cannot pop from an empty stack.
            //So its advisable to check if the stack is not empty before calling for a removal

            if(intStackCollection.Count > 0)
            {
                intStackCollection.Pop();
            }
            else
            {
                Console.WriteLine("\nStack is empty\n");
            }

            //adding values to the stack with the Push() method
            intStackCollection.Push(0);
            intStackCollection.Push(1);
            intStackCollection.Push(2);
            intStackCollection.Push(3);
            intStackCollection.Push(4);
            intStackCollection.Push(5);

            //Accessing the object at the topmost part of the stack
            Console.WriteLine("The object at the top of the stack is: {0}", intStackCollection.Peek());

            //Removing an item from the top of the stack with the Pop() method
            intStackCollection.Pop();
             Console.WriteLine("The object at the top of the stack is: {0}", intStackCollection.Peek());


            //using a while loop to delete items from the stack until there are no items left
            //However, Clear method is preferred for such operation
            //instStackCollection.Clear();

            while(intStackCollection.Count > 0)
            {
                //remove an item from the stack
                Console.WriteLine("\nItem {0} was removed from the stack", intStackCollection.Pop());
                    
                //Count the remaining items in the stack
                Console.WriteLine("\nWe have {0} item left in the stack ", intStackCollection.Count);

            }
            Console.WriteLine("\nThe stack is empty\n");


            //Reversing an Array using stack
            int[] myInts = new int[] { 10, 20, 30, 40, 50, 60, 70 };

            //define a stack
            Stack<int> myIntegers = new Stack<int>();

            foreach(int number in myInts)
            {
                //print the original order of the array 
                Console.Write(number + " ");

                //populating the stack with the array items
                myIntegers.Push(number);
            }

            Console.WriteLine();

            //Reverse the array
            while (myIntegers.Count > 0)
            {
                int storePoppedInt = myIntegers.Pop();

                //Display popped int
                Console.Write(storePoppedInt + " ");
            }
            

            Console.ReadKey();

        }
    }
}