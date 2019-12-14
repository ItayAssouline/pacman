
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public enum CellType
    {
        
        Pacman,
        Cell,
        Ghost,
        Wall,

    }
    

    class Program
    {
       
        static void Init(CellType[,] board, Pacman PacmanOBJ)
        {
           int rows = board.GetLength(0);
           int cols = board.GetLength(1);
            for (int rowIdx = 0; rowIdx < rows; rowIdx++)
            {
                for (int colsIdx = 0; colsIdx < cols; colsIdx++)
                {
                    board[rowIdx, colsIdx] = CellType.Cell;
                }
                
            }

            
            PacmanOBJ.ChangeLocation(0, 0);

            board[PacmanOBJ.getX(), PacmanOBJ.getY()] = CellType.Pacman;

            //Obstcales
            board[3,4] = CellType.Wall;

            //Ghosts
            
        }

        /////////////////


        static void UpdateBoard(Pacman PacmanObject, CellType[,] board, string userInput, int rows, int cols)
        {
            board[PacmanObject.getY(), PacmanObject.getX()] = CellType.Cell;

            //Update Before Board

            if (userInput == "a" || userInput == "A" || userInput == "ש")
            {
                ///////////////////
                if (PacmanObject.getX() > 0 && board[PacmanObject.getY(), PacmanObject.getX() + -1] != CellType.Wall)
                {
                    PacmanObject.x -= 1;
                }

            }
            else if (userInput == "d" || userInput == "D" || userInput == "ג")
            {
                if (PacmanObject.getX() < rows-1 && board[PacmanObject.getY(), PacmanObject.getX()+1] != CellType.Wall)
                {
                    PacmanObject.x += 1;
                }
            }



            else if (userInput == "S" || userInput == "s" || userInput == "ד")
            {
                if (PacmanObject.getY() < cols - 1 && board[PacmanObject.getY()+1, PacmanObject.getX()] != CellType.Wall)
                {
                    PacmanObject.y += 1;
                }
                
            }
            else if (userInput == "w" || userInput == "W" || userInput == "'")
            {
                ///////////////////
                if (PacmanObject.getY() > 0 && board[PacmanObject.getY() - 1, PacmanObject.getX()] != CellType.Wall)
                {
                    PacmanObject.y -= 1;
                }
                
            }
            //Update Pacman
            board[PacmanObject.getY(), PacmanObject.getX()] = CellType.Pacman;

            
        }

        static void Main(string[] args)
        {

            const int ROWS = 10, COLS = 10;
            CellType[,] board = new CellType[ROWS, COLS];
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
                        if (board[rowIdx, colsIdx] == CellType.Cell)
                        {
                            Console.Write(".");
                        }
                        else if (board[rowIdx, colsIdx] == CellType.Pacman)
                        {
                            Console.Write("+");
                        }
                        else if (board[rowIdx, colsIdx] == CellType.Ghost)
                        {
                            Console.Write("X");
                        }
                        else if (board[rowIdx, colsIdx] == CellType.Wall)
                        {
                            Console.Write("|");
                        }
                    }
                    Console.WriteLine();
                }
                string userInput = Console.ReadLine();
                
                UpdateBoard(PacmanOBJ, board, userInput, ROWS, COLS);
                /*
               if(PacmanOBJ.getX() == Ghost.getX() && PacmanOBJ.getX() == Ghost.getY())
                {
                    gameOver(); 
                }
                */
                
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
