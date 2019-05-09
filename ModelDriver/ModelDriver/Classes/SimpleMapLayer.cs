using System;
using System.Collections.Generic;
using System.Text;

namespace ModelDriver.Classes
{
    class SimpleMapLayer : ILayer
    {
        IMapObject[][] objects;
        private string name;
        public string Name { get { return name; } }
        public SimpleMapLayer(string name, MapSize ms)
        {
            this.name = name;
            int x = ms.GetX();
            int y = ms.GetY();
            objects = new IMapObject[x][];
            for (int i = 0; i < x; ++i)
            {
                objects[i] = new IMapObject[y];
            }
        }
        public void AddObject(IMapObject obj, Coordinates coor)
        {
            objects[coor.GetX()][coor.GetY()] = obj;
        }
    }
}
