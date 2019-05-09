using System;
using System.Collections.Generic;
using System.Text;

namespace ModelDriver.Classes
{
    class MapSize
    {
        private int xSize;
        private int ySize;
        public int GetX()
        {
            return xSize;
        }
        public int GetY()
        {
            return ySize;
        }
        public MapSize(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                xSize = x;
                ySize = y;
            }
            else
            {
                throw new Exception("Bad arguments.");
            }
        }
    }
}
