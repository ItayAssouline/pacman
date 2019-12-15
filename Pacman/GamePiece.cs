using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public enum PieceType
    {
        Pacman,
        Wall,
        Ghost,
        Cell
    }
    public abstract class GamePiece 
    {
        private PieceType type;
        public GamePiece(PieceType type)
        {
            this.type = type;
        }

        public PieceType GetPieceType()
        {
            return this.type;
        }

        public abstract string ToString();
    }
}