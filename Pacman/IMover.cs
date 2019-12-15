using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    interface IMover
	{
		int getX();
		int getY();
        void ChangeLocation(int xGot, int yGot);
	}
}
