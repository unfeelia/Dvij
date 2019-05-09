using ModelDriver.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelDriver.Classes
{
    class SimpleEngine : IEngine
    {
        IList<IPlayer> Players;
        IMap map;
        IFactory objectFactory;

        public SimpleEngine(IMap map, IFactory factory)
        {
            this.objectFactory = factory;
            this.map = map;
            Players = new List<IPlayer>();
        }

        public void AddObject(string template, string layer, Coordinates coor)
        {
            map.AddObject(objectFactory.GetByTemplate(template), layer, coor);
        }

        public void AddObject(string template)
        {
            throw new NotImplementedException();
        }

        public void AfterTurn()
        {
            throw new NotImplementedException();
        }

        public void BeforeTurn()
        {
            throw new NotImplementedException();
        }

        public void Interract(int obj_id)
        {
            throw new NotImplementedException();
        }

        public void Interract(string obj_name)
        {
            throw new NotImplementedException();
        }

        public void Interract(IMapObject obj)
        {
            throw new NotImplementedException();
        }

        public void MoveObject(int obj_id, Coordinates to)
        {
            throw new NotImplementedException();
        }

        public void MoveObject(string obj_name, Coordinates to)
        {
            throw new NotImplementedException();
        }

        public void MoveObject(IMapObject obj, Coordinates to)
        {
            throw new NotImplementedException();
        }

        public void RemoveObject(IMapObject obj)
        {
            throw new NotImplementedException();
        }

        public void SwitchTurn()
        {
            throw new NotImplementedException();
        }
    }
}
