using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    
	class Ghost : GamePiece, IMover
	{
        public Ghost() : base(PieceType.Ghost)
        {
        }

        private int x;
		private int y;

        public static double CalcDistance(int x1, int y1, int x2, int y2)
        {
            double distance;
            int disX = x1 - x2;
            int disY = y1 - y2;
            distance = Math.Sqrt(
                Math.Pow(disX, 2) + Math.Pow(disY, 2)
                );
            
            return distance;
        }

       public MoveOption[] PointsAvailable(int x2, int y2)
        {
            int ghostX = this.getX();
            int ghostY = this.getY();

            MoveOption[] points = new MoveOption[4];
            
            points[0].setDistance(CalcDistance(ghostX+1,ghostY,x2,y2));
            points[1].setDistance(CalcDistance(ghostX-1,ghostY,x2,y2));
            points[2].setDistance(CalcDistance(ghostX,ghostY+1,x2,y2));
            points[3].setDistance(CalcDistance(ghostX,ghostY-1,x2,y2));
            //Array.Sort(points);
            MoveOption[] sorted = points.OrderBy(MoveOption => MoveOption.getDistance()).ToArray();
            Array.Reverse(sorted);
            return sorted;
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
