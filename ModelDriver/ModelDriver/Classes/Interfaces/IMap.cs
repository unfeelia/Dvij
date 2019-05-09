namespace ModelDriver.Classes
{
    internal interface IMap
    {
        void AddObject(IMapObject mapObject, string layerName, Coordinates coor);
        void RemoveObject(IMapObject mapObject);
    }
}