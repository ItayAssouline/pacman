﻿
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

            board[PacmanOBJ.getY(), PacmanOBJ.getX()] = new Pacman();

            //Obstcales
            board[3,4] = new Wall();

            //Ghosts
            // TODO: add ghosts here
            board[2, 2] = new Ghost();
        }

        /////////////////


        static void UpdateBoard(Pacman PacmanObject, GamePiece[,] board, string userInput, int rows, int cols)
        {
            board[PacmanObject.getY(), PacmanObject.getX()] = new Cell();

            //Update Before Board

            if (userInput == "a" || userInput == "A" || userInput == "ש")
            {
                ///////////////////
                if (PacmanObject.getX() > 0 && board[PacmanObject.getY(), PacmanObject.getX() + -1].GetPieceType() != PieceType.Wall)
                {
                    //PacmanObject.x -= 1;
                    PacmanObject.ChangeLocation(PacmanObject.getX()-1, PacmanObject.getY());
                }

            }
            else if (userInput == "d" || userInput == "D" || userInput == "ג")
            {
                if (PacmanObject.getX() < rows-1 && board[PacmanObject.getY(), PacmanObject.getX()+1].GetPieceType() != PieceType.Wall)
                {
                    PacmanObject.ChangeLocation(PacmanObject.getX() + 1, PacmanObject.getY());
                }
            }



            else if (userInput == "S" || userInput == "s" || userInput == "ד")
            {
                if (PacmanObject.getY() < cols - 1 && board[PacmanObject.getY()+1, PacmanObject.getX()].GetPieceType() != PieceType.Wall)
                {
                    PacmanObject.ChangeLocation(PacmanObject.getX(), PacmanObject.getY()+1);
                }
                
            }
            else if (userInput == "w" || userInput == "W" || userInput == "'")
            {
                ///////////////////
                if (PacmanObject.getY() > 0 && board[PacmanObject.getY() - 1, PacmanObject.getX()].GetPieceType() != PieceType.Wall)
                {
                    PacmanObject.ChangeLocation(PacmanObject.getX(), PacmanObject.getY()-1);
                }
                
            }
            //Update Pacman
            board[PacmanObject.getY(), PacmanObject.getX()] = PacmanObject;

            
        }

        static void Main(string[] args)
        {

            const int ROWS = 10, COLS = 10;
            GamePiece[,] board = new GamePiece[ROWS, COLS];
            Pacman PacmanOBJ = new Pacman();

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
                
                UpdateBoard(PacmanOBJ, board, userInput, ROWS, COLS);
                
                
            }
            void gameOver()
            {
                isOn = false;
                Console.Clear();
                Console.WriteLine("Game Over! Sorry.");
            }
        }
        
    }
}
