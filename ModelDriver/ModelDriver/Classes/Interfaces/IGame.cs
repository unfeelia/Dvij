namespace ModelDriver.Classes
{
    internal interface IGame
    {
        void MoveObject(int obj_id, Coordinates to);
        void MoveObject(string obj_name, Coordinates to);
        void MoveObject(IMapObject obj, Coordinates to);
        void Interract(int obj_id);
        void Interract(string obj_name);
        void Interract(IMapObject obj);
    }
}