namespace Multidimesional_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaring a 2D array
            int[,] collection1;

            //declaring a 3D array
            int[,,] collection2;

            //hence, one comma (,) for 2D arrays, (,,) - 3d, (,,,) - 4Ddimen etc.

            //Initializing multi-dimensional arrays

            string[,] students = new string[,]
            {
                {"Annie", "Sammie", "Juliet" },
                {"Ugo", "Oluchi", "Nnamani" },
                {"John", "Mandi", "Julie" },
                {"Glory", "Happy", "Lory" }
            };
            Console.WriteLine(students[0, 2]); //Get Juliet
            Console.WriteLine(students[3, 2]); //Get Lory
            Console.WriteLine(students[2, 1]); //Get Mandi

            //3D Array
            int[,,] numbers = new int[,,]
            {
                {
                    {1, 2, 3, 4 },
                    {5, 6, 7, 8 }
                },

                {
                    {9, 10, 11, 12 },
                    {13, 14, 15, 16 }
                }
            };

            //Console.WriteLine(numbers[0, 1, 1]); //Get 6
            //Console.WriteLine(numbers[1, 0, 1]); //Get 10

            //Another way of creating a multi-dimensional arrays in C# is by
            //  specifying the number of dimensions and entries
            string[,] pupilRecord = new string[3, 2]
            {
                { "Nkechi", "Agnes"},
                { "David", "Beatrice"},
                { "Noni", "Nkem"}
            };

            //to change Beatrice to Martin in the above array:

            pupilRecord[1, 1] = "Martin";

            //Console.WriteLine(pupilRecord[1, 1]);

            //checking the dimensions of an array with Rank

            var findArrayDimension = pupilRecord.Rank;
            //Console.WriteLine("The dimension of the pupilRecord array is: {0}",findArrayDimension);

            //Creating an array without specifying the rank
             int[,] _2DArray = { {20, 100, 40 }, {10, 89, 50 } };
            //Console.WriteLine(_2DArray[1,2]);
        }
    }
}