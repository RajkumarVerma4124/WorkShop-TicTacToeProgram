using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeProgram
{
    /// <summary>
    /// TicTacToe Game Program
    /// </summary>
    public class TicTacToeGame
    {
        // static variables
        public static char[] playBoard = new char[10];
        public static char player;
        public static char computer;

        //Method for player to start fresh by resetting the board(UC1)
        public static void StartFresh()
        {
            Console.WriteLine("==================");
            Console.WriteLine("||              ||");
            Console.WriteLine("|| Game Started ||");
            Console.WriteLine("||              ||");
            Console.WriteLine("==================");

            //To ignore first index i is initialized as 1
            for (int i = 1; i < playBoard.Length; i++)
            {
                playBoard[i] = ' ';
            }
            Console.ReadLine();
        }

        //Method to get the player and computer input(UC2)
        public static void GetPlayerInput()
        {
            Console.Write("Choose What Symbol You Want \"X\" or \"O\" : ");
            player = Convert.ToChar(Console.ReadLine());
            if (player == 'X' || player == 'x')
            {
                computer = 'O';
            }
            else if (player == 'O' || player == 'o')
            {
                computer = 'X';
            }
            else
            {
                Console.WriteLine("Wrong Input Try Again");
                GetPlayerInput();
            }
            Console.WriteLine("Player Chose : " + player);
            Console.WriteLine("Computer Chose : " + computer);
        }
    }
}
