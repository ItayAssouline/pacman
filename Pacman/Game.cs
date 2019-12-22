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

        public Game(Pacman PacmanObject, GamePiece[,] board) {
            this.PacmanObject = PacmanObject;
            this.board = board;
            GameFunction();
        }

        

        public void GameFunction()
        {

            GameBoard Gameboard = new GameBoard(board);


            string userInput = Console.ReadLine();
            if (userInput == "a" || userInput == "A" || userInput == "ש")
            {

                Gameboard.executeTurn(4);

                /*
                if (PacmanObject.getX() > 0 && board[PacmanObject.getY(), PacmanObject.getX() + -1].GetPieceType() != PieceType.Wall)
                {
                    //PacmanObject.x -= 1;
                    
                }
                */
            }
            else if (userInput == "d" || userInput == "D" || userInput == "ג")
            {
                Gameboard.executeTurn(6);
                /*
                if (PacmanObject.getX() < rows - 1 && board[PacmanObject.getY(), PacmanObject.getX() + 1].GetPieceType() != PieceType.Wall)
                {
                    PacmanObject.ChangeLocation(PacmanObject.getX() + 1, PacmanObject.getY());
                }
                */
            }



            else if (userInput == "S" || userInput == "s" || userInput == "ד")
            {
                Gameboard.executeTurn(2);
                /*
                if (PacmanObject.getY() < cols - 1 && board[PacmanObject.getY() + 1, PacmanObject.getX()].GetPieceType() != PieceType.Wall)
                {
                    PacmanObject.ChangeLocation(PacmanObject.getX(), PacmanObject.getY() + 1);
                }
                */

            }
            else if (userInput == "w" || userInput == "W" || userInput == "'")
            {
                Gameboard.executeTurn(8);
                ///////////////////
                ////*
                /*
                if (PacmanObject.getY() > 0 && board[PacmanObject.getY() - 1, PacmanObject.getX()].GetPieceType() != PieceType.Wall)
                {
                    PacmanObject.ChangeLocation(PacmanObject.getX(), PacmanObject.getY() - 1);
                }
                */

            }
        }
    }
}
