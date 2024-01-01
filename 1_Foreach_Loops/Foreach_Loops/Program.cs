namespace Array_Foreach_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[15];

            // First loop: Filling the array with values
            for (int i = 0; i < 15; i++)
            {
                //Console.WriteLine(i); only incremented from 1 - 14
                num[i] = i; //filling the array with i

                //num[i] = i + 10;
                //Console.WriteLine("The element at index{0} is {1}", i, num[i]);//you can still assign and print
                                                                               //in the first loop without needing the second loop
            }

            //Second loop: Printing the elements of the array
            for (int j = 0; j < num.Length; j++) //if the length here is more than
                                         //the stipulated length of the array, outOfRange Exception occurs
            {
               Console.WriteLine("The element at index{0} is {1}", j, num[j]);
            }

            //foreach Loop
            int counter = 0;//to see the index

            foreach(int k in num) //this performs similar function with the second loop above
            {                    // k represents each value in the array
                Console.WriteLine("The element at index{0} is {1}\n", counter, k);
                counter++;
            }

            /*Advantages of foreach loop over the traditional for loop
             - foreach is simple, more concise and readable
             - foreach knows where to start and stop unlike the for loop where you need to specify it which can create out of range error
             - no need to manually manage indices or worry about off-by-one errors
             - The foreach loop eliminates the possibility of index out of range errors, which can occur in a for 
             - In some cases, the foreach loop might offer better performance optimizations, 
             */

            //However, While foreach has its advantages, there are situations
            //where the explicit control provided by a for loop (with index management)
            //is necessary or more appropriate.
            //

            //Exercise:
            //create an array with 5 of your best friends
            //create a foreach loop which greets all of them

            // string[] friends = new string[num];//This is appropriate when you want to create an array of strings
                                                  // with a specific size and you plan to assign values
                                                  // to individual elements later in your code
            string[] friends =  { "Precious", "Ella", "Josh", "Amaka", "Sammie"};
            
            foreach(string friend in friends)
            {
                Console.WriteLine("Hello {0}, it's good to see you.", friend);
            }

            //Foreach is a powerful tool when working with collections like arrays or lists

            //When to use each loop

            //print each number in an array of numbers
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; //foreach is perfect for this task

            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

            //print each item in an array of numbersCollection in reverse
            int[] numberCollection = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //a traditional for loop is suitable for this
            //allowing you to specify the start and end including step size

            for (int item = numberCollection.Length - 1; item >= 0; item--) 
            {
                Console.WriteLine("index: {0}, value: {1} ", item, numberCollection[item]);
            }

            //While loops are best when you don't know how many times you need to lop
            //i.e like keep asking a user for an input until a valid input is obtained

            //write a program that keeps asking users for a valid input until you get a valid input
            string userInput;
           
            do
            {
                Console.WriteLine("Please enter a valid number");
                 userInput = Console.ReadLine();

            } while (!int.TryParse(userInput, out int validInput));

            //use foreach when you don't need to manipulate the index
            //use for when you need more control over the iteration process
                //like skipping elements or iterating in reverse
            //Use while when you do not know how many times you need to loop


            Console.ReadKey();
        }
    }
}