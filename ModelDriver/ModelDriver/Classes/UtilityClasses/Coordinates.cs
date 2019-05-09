using System;
using System.Collections.Generic;
using System.Text;

namespace ModelDriver.Classes
{
    class Coordinates
    {
        int x;
        int y;
        public Coordinates(int x, int y)
        { this.x = x; this.y = y; }
        public int GetX()
        { return x; }
        public int GetY()
        { return y; }
    }
}
