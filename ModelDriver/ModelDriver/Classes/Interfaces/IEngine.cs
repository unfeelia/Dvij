using System;
using System.Collections.Generic;
using System.Text;

namespace ModelDriver.Classes.Interfaces
{
    interface IEngine
    {
        void SwitchTurn();
        void BeforeTurn();
        void AfterTurn();
        void MoveObject(int obj_id, Coordinates to);
        void MoveObject(string obj_name, Coordinates to);
        void MoveObject(IMapObject obj, Coordinates to);
        void Interract(int obj_id);
        void Interract(string obj_name);
        void Interract(IMapObject obj);
        void AddObject(string template);
        void RemoveObject(IMapObject obj);
    }
}
