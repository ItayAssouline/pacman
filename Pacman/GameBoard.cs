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
        private GamePiece[,] board;
        private GameBoard(GamePiece[,] board)
        {
            this.board = board;
        }


        public Point pacmanLocator()
        {
            
            int rows = this.board.GetLength(0);
            int cols = this.board.GetLength(1);
            for (int rowIdx = 0; rowIdx < rows; rowIdx++)
            {
                for (int colsIdx = 0; colsIdx < cols; colsIdx++)
                {
                    if(this.board[rowIdx, colsIdx].GetPieceType() == PieceType.Pacman)
                    {
                        return new Point(colsIdx, rowIdx);
                    }
                }
            }
            return new Point(-1,-1);
            // Implements: return null;

        }

        
        
       


        public enum MoveDir
        {
            Right,
            Left,
            Up,
            Down
        }

        public void executeTurn(MoveDir turn)
        {

            if(turn == MoveDir.Left)
            {

            }
            else if(turn == MoveDir.Right)
            {

            } 
            else if(turn == MoveDir.Down)
            {

            }
            else if(turn == MoveDir.Up)
            {

            }

        }
     
    }
}
