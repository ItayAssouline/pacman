using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
	class Pacman
	{
		public int x;
		public int y;

		public int getX()
		{
			return this.x;
		}
		public int getY()
		{
			return this.y;
		}

		public void ChangeLocation(int xGot, int yGot)
		{
			x = xGot;
			y = yGot;

		}

	}
}
