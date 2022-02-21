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

        //Method for player to start fresh by resetting the board
        public static void StartFresh()
        {
            Console.WriteLine("==================");
            Console.WriteLine("||              ||");
            Console.WriteLine("|| Game Started ||");
            Console.WriteLine("||              ||");
            Console.WriteLine("==================");
            playBoard = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '};
            Console.ReadLine();
        }
    }
}
