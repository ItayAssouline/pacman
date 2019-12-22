
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
	class Program
    {
       
        static void Init(GamePiece[,] board, Pacman PacmanOBJ)
        {
           int rows = board.GetLength(0);
           int cols = board.GetLength(1);
            for (int rowIdx = 0; rowIdx < rows; rowIdx++)
            {
                for (int colsIdx = 0; colsIdx < cols; colsIdx++)
                {
                    board[rowIdx, colsIdx] = new Cell();
				}
            }
            PacmanOBJ.ChangeLocation(0, 0);
            board[PacmanOBJ.getY(), PacmanOBJ.getX()] = PacmanOBJ;
            //Obstcales
            board[3,4] = new Wall();

            //Ghosts
            // TODO: add ghosts here
            board[2, 2] = new Ghost();
        }

        static void Main(string[] args)
        {

            
            const int ROWS = 10, COLS = 10;
            GamePiece[,] board = new GamePiece[ROWS, COLS];
            Pacman PacmanOBJ = new Pacman();

            Game Game = new Game(PacmanOBJ, board);

            //Initialize Loop
            Init(board, PacmanOBJ);
            //Game Loop
            bool isOn = true;
            while (isOn)
            {
               
                Console.Clear();
                for (int rowIdx = 0; rowIdx < ROWS; rowIdx++)
                {
                    for (int colsIdx = 0; colsIdx < COLS; colsIdx++)
                    {
						Console.Write(board[rowIdx,colsIdx].ToString());
					}

                    Console.WriteLine();
					
                }
                string userInput = Console.ReadLine();              
                
            }

        }
        
    }
}
