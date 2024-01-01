namespace Using_Arrays_As_Parameters
{
    internal class Program
    {
        //Using methods with parameters of the type array

        /* Challenge 1
         - create a program that takes in arrays as numbers
           and calculates the average
        */

        /* Challenge 2
         - create an array of happiness in the Main Method
           and assign 5 values to it
         - Create a method which has an array of type int as its parameter
         - This method should increase the argument given by two for each entry
         - Call this method in the main method and use "happiness" as the argument
         - Create a foreach loop and log all values out to the console
        */

        static void Main(string[] args)
        {
            //Challenge 1
            int[] scores = new int[] { 10, 20, 35 };

            double studentAverage = GetAverageScore(scores);
            Console.WriteLine("The average score is: {0}",studentAverage);


            //Challenge 2
            int[] happiness = new int[5] {1, 2, 3, 4, 5 };

            //print each item in the array happiness

            //print each doubled item in the array
 
            DoubleNumber(happiness);

            //print the doubled numbers
            foreach(int number in happiness)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
        
        public static double GetAverageScore(int[] scoreArray)
        {
            int arrayLength = scoreArray.Length;
            int sum = 0;
            double averageScore = 0;

            //loop through the array

            Console.WriteLine("students scores are:");

            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine(scoreArray[i]);

                sum += scoreArray[i];  
            }
            averageScore = (double)sum / arrayLength;
            // Calculating the average inside the loop will cause it to be updated in each iteration.
            // Moving the calculation outside the loop ensures that
            // it is performed after the sum has been computed for all elements in the array.

            return averageScore;   
        }

        //Challenge 2
        public static void DoubleNumber(int[] numbers)
        {
            //multiply every element in the array by 2
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= 2;
            }
        }
    }
}