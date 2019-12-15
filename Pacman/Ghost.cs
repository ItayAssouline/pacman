using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
	class Ghost : GamePiece, IMover
	{

		private int x;
		private int y;

		public double pithagoras(int PacX, int PacY)
		{
			double res = Math.Sqrt(PacX * PacX + PacY * PacY);
			return res;
		}
		public void PithagorianCheck(Pacman PacmanOBJ)
		{
			int PacX = PacmanOBJ.getX();
			int PacY = PacmanOBJ.getY();
			/*
			int PacXDistance = Math.Abs(PacX-x);
			int PacYDistance = Math.Abs(PacY-y);
			*/
			if(pithagoras(Math.Abs(PacX-(x-1)), Math.Abs(PacY - y)) < pithagoras(Math.Abs(PacX - (x + 1)), Math.Abs(PacY - y)))
			{

			}
			else if(pithagoras(Math.Abs(PacX - (x - 1)), Math.Abs(PacY - y)) == pithagoras(Math.Abs(PacX - (x + 1)), Math.Abs(PacY - y)))
			{
				if (pithagoras(Math.Abs(PacY - (y - 1)), Math.Abs(PacX - x)) < pithagoras(Math.Abs(PacY - (y + 1)), Math.Abs(PacX - x)))
				{

				}
				else
				{

				}
			}
			else if(pithagoras(Math.Abs(PacX - (x - 1)), Math.Abs(PacY - y)) > pithagoras(Math.Abs(PacX - (x + 1)), Math.Abs(PacY - y)))
			{

			}
		}
		 
		public void CheckWhereToGo() {
					
		}
		public void ChangeLocation(int xGot, int yGot)
		{
			x = xGot;
			y = yGot;

		}
		public int getX() {
			return x;
		}

		public int getY()
		{
			return y;
		}

		public override string ToString()
		{
			return "X";
		}
	}
}
