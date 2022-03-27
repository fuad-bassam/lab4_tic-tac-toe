using System;
using Lab04_TicTacToe.Classes;
namespace lab4_tic_tac_toe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StartGame();
           
        }

        // Initialise player name and Start the game.
        //return the name of winner if exist.
        static void StartGame()
        {

            Player fuad = new Player();
            Player ali = new Player();


            Console.WriteLine("Player 1 enter your name");
            fuad.Name = Console.ReadLine();
            fuad.Marker = "x";


            Console.WriteLine("Player 2 enter your name");
            ali.Name = Console.ReadLine();
            ali.Marker = "o";


            Game game = new Game(fuad,ali);

            Console.WriteLine( game.Play().Name);

            Console.ReadKey();
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 

        }

    }
}
