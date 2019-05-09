using System;
using System.Collections.Generic;
using System.Text;

namespace ModelDriver.Classes
{
    class SimpleMapObject: IMapObject
    {
        int ID;
        string Name;
        public SimpleMapObject(int id, string name = "")
        {
            ID = id;
            Name = id.ToString();
        }
    }
}
