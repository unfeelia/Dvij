using ModelDriver.Classes;
using ModelDriver.Classes.Interfaces;
using System;

namespace ModelDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleMap map = new SimpleMap(new MapSize(100, 100));
            map.AddLayer("default");
            SimpleMapObjectF factory = new SimpleMapObjectF();
            SimpleEngine eng = new SimpleEngine(map, factory);
            for(int i = 0; i < 10; ++i)
            {
                eng.AddObject("1", "default", new Coordinates(i, i));
            }
            Console.ReadLine();
        }
    }
}
