namespace Jagged_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jagged Array is an array with multiple arrays

            //Declaring  and initializing a jagged array
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[4];
            jaggedArray[2] = new int[3];

            jaggedArray[0] = new int[] { 1, 2, 3, 4, 5 };
            jaggedArray[1] = new int[] { 1, 2, 3, 4 };
            jaggedArray[2] = new int[] { 1, 2, 3 };

            //alternatively - creating and initializing directly
            int[][] jaggedArray2 = new int[3][]
            {
                 new int[]{ 1, 2, 3, },
                 new int[]{ 4, 5, 6, },
                 new int[]{ 7, 8, 9, }
            };
            //accessing values in jagged array
            //Console.WriteLine("Here we accessed the value: {0}", jaggedArray2[1][1]);

            //Getting all the values within the jaggedArray2 onto the console
            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                //get the indeces of the nested arrays
                // Console.WriteLine("The values of the jaggedArray2 first elements are: {0}", i);
                for (int j = 0; j < jaggedArray2.Length; j++)
                {
                    //get all the elements of the nested arrays 
                    //Console.WriteLine("The values of the jaggedArray2 elements 2 are: {0}", jaggedArray2[i][j]);
                }
            }

            /*jagged Array versus multidimensional arrays
                 - A jagged array, also known as array of arrays is an array whose elements are arrays
                 - The elements of a jagged array can be of different dimensions and sizes
                 - it allows us to create complex data structures
                */

            int[][] createTriangle = new int[][]
            {
                    new int[]{1},
                    new int[]{2, 3 },
                    new int[]{4, 5, 6 },
                    new int[]{7, 8, 9, 10}

            };

            //using foreach loop to print each row of the triangle
            foreach (int[] row in createTriangle)
            {
                foreach (int number in row)
                {
                    //Console.WriteLine(number);
                }
            }

            /*jagged Array versus multidimensional arrays
               - Unlike jagged array, the elements in a multidimensional arrays are same size
               - This makes a multidimensional arrays ideal for mathematical operations
               - it suitable for grid of equal numbers of elements
            */

            int[,] numbers =
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}

            };

            //creating a for loop to print the elements out
            for(int i = 0;i < numbers.GetLength(0); i++)
            {
                //the outer for loop is used to iterate over the rows of the grid array
                for(int j = 0;j < numbers.GetLength(1); j++)
                {
                    //while the inner for loop is used to iterate over the columns of the grid array
                    Console.WriteLine(numbers[i, j]);
                }
            }

            /*when to uses jaggedArray and multidimensional arrays
             - Use jagged arrays for complex data structures
             - Use jagged arrays when there are elements of different sizes
             - Use multidimensional arrays for mathematical operations
             - Or on a grid of numbers with the same size
            */
         }  
    }
}