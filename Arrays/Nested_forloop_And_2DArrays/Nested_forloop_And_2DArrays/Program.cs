using System.Diagnostics;

namespace Nested_forloop_And_2DArrays
{
    internal class Program
    {
        //static is used with the array because it will be used inside the static method
        static int[,] numberCollections =
        {
            {1, 2, 3, 4 },
            {5, 6, 7, 8 },
            {9, 10, 11, 12 }
        };
        static void Main(string[] args)
        {


            foreach (int number in numberCollections)
            {
                //Console.WriteLine(number); //displays all the items in the array vertically
                //Console.Write(number + " "); //displays all the items in the array horizontally

                //one major disadvantage is that we can't reassign a value to an array item with foreach
                //number = 5; // cannot assign to number because it is a foreach iteration variable
            }

            //This nested loop prints all the items in the 2D array
            for (int i = 0; i < numberCollections.GetLength(0); i++)
            {
                for (int j = 0; j < numberCollections.GetLength(1); j++)
                {
                    //numberCollections[i, j] = 0; //we can assign value with the for loop

                    //which is not achievable with foreach
                    if (numberCollections[i, j] % 2 == 0) //print even numbers from the array
                    {
                        //Console.WriteLine(numberCollections[i, j]);
                    }
                    else
                    {
                        //Console.WriteLine(" ");
                    }

                    if (numberCollections[i, j] % 2 != 0) //print odd numbers
                    {
                        //Console.WriteLine(numberCollections[i, j]);
                    }
                    else
                    {
                        //Console.WriteLine(" ");
                    }

                    //Printing the diagonal items in the numberCollections array
                    //To do this, we need i and j to be the same
                    if (i == j)  //print odd numbers
                    {
                        //Console.Write(numberCollections[i, j] + " ");
                    }
                    else
                    {
                        //Console.Write(" ");
                    }
                    //Console.WriteLine("");
                }

                //the advantage of the nested for loop over the foreach is that
                //we can assign value to the number collection

            }

            //Printing diagonal items with just a single for loop
            for (int k = 0; k < numberCollections.GetLength(0); k++)
            {
                //Console.WriteLine(numberCollections[k, k]);

            }
            //Printing diagonal items from the end with just a single for loop
            //This only works in matrix with the same amount of columns and rows
            //This is difficult to read and it is not a common practice, so be careful when when you decide to use it.
            for (int k = 0, l = 3;  k < numberCollections.GetLength(0); k++, l--)
            {
                Console.WriteLine(numberCollections[k, l]);

            }

            TicTacToeChecker();
        }

        public static void TicTacToeChecker()
        {
            string[,] ticTacBoard =
                {
                    { "A", "B", "C" },
                    { "D", "E", "F" },
                    { "G", "H", "I" }
                };

            //how do i print diagonally A
            //how do i print diagonally AEI
            for (int i = 0; i < ticTacBoard.GetLength(0); i++)
            {
                //Console.WriteLine(ticTacBoard[i, 0]);

                //print diagonally from top-left to bottom-right "AEI"
                //Console.WriteLine(ticTacBoard[i, i]);

                //print diagonally from top-right to bottom-left "CEG"
                Console.WriteLine(ticTacBoard[i, ticTacBoard.GetLength(0) - 1 - i]);

                for (int j = 0; j < ticTacBoard.GetLength(0); j++)
                {
                    //get all the items from index 0 to the last
                    //Console.WriteLine(ticTacBoard[i, j]);



                }
            }

        }
    }
}