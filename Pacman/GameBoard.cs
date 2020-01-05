using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Pacman
{
   
    class GameBoard
    {

        static public Point pacmanLocator(GamePiece[,] board)
        {
            Point pacmanPoint = new Point();
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);
            for (int rowIdx = 0; rowIdx < rows; rowIdx++)
            {
                for (int colsIdx = 0; colsIdx < cols; colsIdx++)
                {
                    if(board[rowIdx, colsIdx].GetPieceType() == PieceType.Pacman)
                    {
                        pacmanPoint.Y = rowIdx;
                        pacmanPoint.X = colsIdx;
                        return pacmanPoint;
                    }
                }
            }
            return pacmanPoint;

        }

        
        public GamePiece[,] board;
        public GameBoard(GamePiece[,] board)
        {
            this.board = board;
        }


        public void executeTurn(int turn)
        {

            if(turn == 4)
            {

            }
            else if(turn == 6)
            {

            } 
            else if(turn == 2)
            {

            }
            else if(turn == 8)
            {

            }

        }
     
    }
}
