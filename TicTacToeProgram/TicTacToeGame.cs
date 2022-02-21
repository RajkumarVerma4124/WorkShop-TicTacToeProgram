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
        public static char[] playBoard;
        public static char player;
        public static char computer;

        //Method for player to start fresh by resetting the board
        public static void StartFresh()
        {
            Console.WriteLine("==================");
            Console.WriteLine("||              ||");
            Console.WriteLine("|| Game Started ||");
            Console.WriteLine("||              ||");
            Console.WriteLine("==================");
            playBoard = new char[10] {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '};

            //To ignore first index
            playBoard = playBoard.Skip(1).ToArray();
            Console.ReadLine();
        }

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
