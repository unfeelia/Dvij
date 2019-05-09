using System;
using System.Collections.Generic;
using System.Text;

namespace ModelDriver.Classes.Event
{
    class EventHandler
    {
        delegate void Event();
        Event beforeTurn;
        Event afterTurn;
        Event turn;
        public EventHandler()
        {

        }
    }
}
