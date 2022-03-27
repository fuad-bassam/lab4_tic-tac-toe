﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    class Board
    {
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};


		//Display Board as 3X3 matrix on console.
		public void DisplayBoard()
		{


            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Console.Write( GameBoard[i, j]+"  ");
                }
				Console.WriteLine();
				Console.WriteLine();
			}



		
		}
	}
}
