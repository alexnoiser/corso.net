using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova5
{
    internal class Lamp
    {

        internal string roomName;
        internal bool isOn;
        public Lamp(string name) 
        {
            roomName = name;
                       

        }
        internal string LampState()
        {
            if (isOn) return "ON"; else return "OFF";
        }
        internal void Switch()
        {
            isOn = !isOn;
        }



    }
}
