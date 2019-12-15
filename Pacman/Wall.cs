using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    class Wall : GamePiece
    {
        public Wall() :  base(PieceType.Wall) {
        }

		public override string ToString()
		{
			return "|";
		}
	}
}
