using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeProgram
{
    /// <summary>
    /// Main Program
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            //Displaying Welcome Message
            Console.WriteLine("Welcome to the tic toe program");

            //Calling the tictactoegame start fresh method
            TicTacToeGame.StartFresh();           
            //Calling the get player input method
            TicTacToeGame.GetPlayerInput();
            Console.ReadLine();
        }
    }
}
