using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    class MoveOption
    {
        int x;
        int y;
        double distance;

        public void setX(int x)
        {
            this.x = x;
        }
        public void setY(int y)
        {
            this.y = y;
        }
        public void setDistance(double distance)
        {
            this.distance = distance;
        }
        public double getDistance()
        {
            return this.distance;
        }
    }
}
