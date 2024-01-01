namespace Collections_Array_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Arrays
             - A single array variable stores ONLY one type of data
             - Stores a fixed size collection of elements in sequence
             - Every collection can be stored in an array according to their types
             */

            //How to declare an array
            //dataype[] arrayName
           // int[] score;

            //How to initialize an array
            //datatype[] arrayName = new array[amount of entries]; 
            int[] score1 = new int[6];

            //Ways of Assigning values to array

            score1[0] = 40;
            score1[1] = 40;
            score1[2] = 40;
            score1[3] = 40;
            score1[4] = 40;
            score1[5] = 40;

            // 1) initializing array with values
            string[] color = { "red", "black", "blue", "yellow" };

            //Accessing the values in an array
            Console.WriteLine("Score at index 1 is: {0}", score1[1]);
            Console.WriteLine("Color at index 3 is: {0}", color[3]);

            //Changing the value in an array;
            color[3] = "Purple";
            Console.WriteLine("Color at index 3 is: {0}\n", color[3]);

            Console.WriteLine("Input a number");
            score1[2] = int.Parse(Console.ReadLine());
            Console.WriteLine($"score1[2] has been updated to {score1[2]}" );

            // 2) Another way of initializing array with values
            string[] studentsNames = new string[] { "Amaka", "Ekene", "Ifechukwu", "Andrew", "Chioma" };

            //Getting Array length
            //arrays legnth count starts from one while array index count starts from zero
            Console.WriteLine($"\nArray length of students names is: {studentsNames.Length}");
            Console.ReadKey();
        }
    }
}