using System;
using System.Collections.Generic;
using System.Text;

namespace ModelDriver.Classes
{
    class SimpleMapObjectF : IFactory
    {
        int Count = 0;
        public IMapObject GetByJson(string json)
        {
            Count++;
            return new SimpleMapObject(Count - 1);
        }

        public IMapObject GetByTemplate(string template)
        {
            Count++;
            return new SimpleMapObject(Count - 1);
        }
    }
}
