namespace Challenge_Arrays_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Arrays, for and foreach loops

             This time, you have to fill out two methods:
             GetOdd will get an array as input and will print every odd number from it to the console;
             GetEven will do the same for evens;
            */
            Run();

        }
        public static void GetOdd(int[] Array)
        {
           
            foreach (int number in Array)
            {
                if (number % 2 != 0)
                {
                    Console.WriteLine(number);
                }
            }

        }

        public static void GetEven(int[] Array)
        {
            foreach (int number in Array)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }
        }

        public static void Run()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            GetOdd(array);
            GetEven(array);

        }

        //personal exercise: try getting array input from user and logging the even and odd
    }
}


