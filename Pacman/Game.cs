using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    class Game
    {
        Pacman PacmanObject;
        GamePiece[,] board;

          public void Init(GamePiece[,] board, Pacman PacmanOBJ)
                {
            this.board = board;
            int rows = this.board.GetLength(0);
            int cols = this.board.GetLength(1);
            for (int rowIdx = 0; rowIdx < rows; rowIdx++)
            {
                for (int colsIdx = 0; colsIdx < cols; colsIdx++)
                {
                    this.board[rowIdx, colsIdx] = new Cell();
                }
            }
            PacmanOBJ.ChangeLocation(0, 0);
            this.board[PacmanOBJ.getY(), PacmanOBJ.getX()] = PacmanOBJ;
            //Obstcales
            this.board[3, 4] = new Wall();

            //Ghosts
            // TODO: add ghosts here
            this.board[2, 2] = new Ghost();

                }

        

        public Game() {
           
        }

        

        public void startGame()
        {

            const int ROWS = 10, COLS = 10;
            GamePiece[,] board = new GamePiece[ROWS, COLS];
            Pacman PacmanOBJ = new Pacman();

            

            //Initialize Loop
           Init(board, PacmanOBJ);
            //Game Loop
            bool isOn = true;
            GameBoard Gameboard = new GameBoard(board);
            while (isOn)
            {

                Console.Clear();
                for (int rowIdx = 0; rowIdx < ROWS; rowIdx++)
                {
                    for (int colsIdx = 0; colsIdx < COLS; colsIdx++)
                    {
                        Console.Write(board[rowIdx, colsIdx].ToString());
                    }

                    Console.WriteLine();

                }
                

                    string userInput = Console.ReadLine();
                    if (userInput == "a" || userInput == "A" || userInput == "ש")
                    {
                        Gameboard.executeTurn(GameBoard.MoveDir.Left);
                    }
                    else if (userInput == "d" || userInput == "D" || userInput == "ג")
                    {
                        Gameboard.executeTurn(GameBoard.MoveDir.Right);
                    }
                    else if (userInput == "S" || userInput == "s" || userInput == "ד")
                    {
                        Gameboard.executeTurn(GameBoard.MoveDir.Down);
                    }
                    else if (userInput == "w" || userInput == "W" || userInput == "'")
                    {
                        Gameboard.executeTurn(GameBoard.MoveDir.Up);
                    }
            }
            

           
        }
    }
}
