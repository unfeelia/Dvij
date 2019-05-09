using System;
using System.Collections.Generic;
using System.Text;

namespace ModelDriver.Classes
{
    class SimpleMap: IMap
    {
        MapSize ms;
        Dictionary<string, ILayer> layers;
        public SimpleMap(MapSize ms)
        {
            this.ms = ms;
            layers = new Dictionary<string, ILayer>();
        }

        public void AddObject(IMapObject mapObject, string layerName, Coordinates coor)
        {
            layers[layerName].AddObject(mapObject, coor);
        }
        public void AddLayer(string layerName)
        {
            layers.Add(layerName, new SimpleMapLayer(layerName, ms));
        }
        public void RemoveObject(IMapObject mapObject)
        {
            throw new NotImplementedException();
        }
    }
}
