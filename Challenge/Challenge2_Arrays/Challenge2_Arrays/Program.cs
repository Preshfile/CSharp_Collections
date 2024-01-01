using System.ComponentModel;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

namespace Challenge2_Arrays_TicTacToe_Game_Checker
{
    internal class Program
    {
        /*
        Tic Tac Toe winner identifier

        create your own Tic Tac Toe game, so let's prepare a bit!
        This time, you have to write only a checker for the game.
        It will be a method that takes a 2D array and returns a boolean.
        If there is a winner, it returns true otherwise false.

        We use "X" and "O" as signs of our players. The empty places will be filled with numbers from 1 to 9.

        You have to check 3 types of cases:

        horizontal;
        vertical;
        diagonal;

        We have faith in you 💕
        */
        static void Main(string[] args)
        {
            string[,] ticTac =
               {
                    { "A", "B", "C" },
                    { "D", "A", "F" },
                    { "", "H", "A" }
                };

            bool ticTacToe = TicTacToeChecker(ticTac);

            Console.WriteLine(ticTacToe);

        }
        public static bool TicTacToeChecker(string[,] ticTacBoard)
        {   
            //top-right to bottom-left diagonal check
            if(ticTacBoard[0, 2] == ticTacBoard[1, 1] && ticTacBoard[0, 2] == ticTacBoard[2, 0]
               && ticTacBoard[0,2] != "" && ticTacBoard[1, 1] != "" && ticTacBoard[2, 0] != "")
            {
                return true;
            }

            //top-left to bottom-right diagonal check
            if (ticTacBoard[0, 0] == ticTacBoard[1, 1] && ticTacBoard[0, 0] == ticTacBoard[2, 2]
               && ticTacBoard[0, 0] != "" && ticTacBoard[1, 1] != "" && ticTacBoard[2, 2] != "")
            {
                return true;
            }

            //Vertical Check
            if (ticTacBoard[0, 0] == ticTacBoard[1, 0] && ticTacBoard[0, 0] == ticTacBoard[2, 0]
               && ticTacBoard[0, 0] != "" && ticTacBoard[1, 0] != "" && ticTacBoard[2, 0] != "")
            {
                return true;
            }

            if (ticTacBoard[0, 1] == ticTacBoard[1, 1] && ticTacBoard[0, 1] == ticTacBoard[2, 1]
               && ticTacBoard[0, 1] != "" && ticTacBoard[1, 1] != "" && ticTacBoard[2, 1] != "")
            {
                return true;
            }

            if (ticTacBoard[0, 2] == ticTacBoard[1, 2] && ticTacBoard[0, 2] == ticTacBoard[2, 2]
               && ticTacBoard[0, 2] != "" && ticTacBoard[1, 2] != "" && ticTacBoard[2, 2] != "")
            {
                return true;
            }

            
            //Horizontal check
            if (ticTacBoard[0, 0] == ticTacBoard[0, 1] && ticTacBoard[0, 0] == ticTacBoard[0, 2]
               && ticTacBoard[0, 0] != "" && ticTacBoard[0, 1] != "" && ticTacBoard[0, 2] != "")
            {
                return true;
            }

            if (ticTacBoard[1, 0] == ticTacBoard[1, 1] && ticTacBoard[1, 0] == ticTacBoard[1, 2]
               && ticTacBoard[1, 0] != "" && ticTacBoard[1, 1] != "" && ticTacBoard[1, 2] != "")
            {
                return true;
            }

            if (ticTacBoard[2, 0] == ticTacBoard[2, 1] && ticTacBoard[2, 0] == ticTacBoard[2, 2]
               && ticTacBoard[2, 0] != "" && ticTacBoard[2, 1] != "" && ticTacBoard[2, 2] != "")
            {
                return true;
            }

            return false;

        }

        /*Possible improvements
         - the array could be a char instead of a string
         - check for different positions can be transformed into methods
         - some repetitions can be avoided by creating methods for re-usability
         */
    }
}