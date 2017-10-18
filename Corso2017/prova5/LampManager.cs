using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova5
{
    class LampManager
    {
        List<Lamp> lampList = new List<Lamp>();

        //internal LampManager()
        //{
         
        //}
        internal void AddLamp(Lamp lampadina)
        {
            lampList.Add(lampadina);
        
        }
        

       
        internal void RemoveLamp(string lampadina)
        {
            foreach(Lamp item in lampList)
            {
                
                if (item.roomName == lampadina)
                {
                    lampList.Remove(item);
                    break;
                }
                else
                {
                    NotExistingError();
                }
            }
        }

        internal void NotExistingError()
        {
            Console.WriteLine("La lampadina non è presente in elenco");
        }

        internal void AlreadyExistingError()
        {
            Console.WriteLine("La lampadina è già presente in elenco");
        }

        internal bool CheckLamp(string lampadina)
        {
            bool result = false;
            foreach (Lamp item in lampList)
            {
                if (item.roomName == lampadina)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }

        internal void PrintList()
        {
            if (lampList.Count == 0)
            {
                Console.WriteLine("Attenzione non ci sono lampadine");
            }
            else
            {
                foreach(Lamp item in lampList)
                {
                    Console.WriteLine($"Le stanze in cui è presente la lampadina sono: {item.roomName}, e la lampadina è {item.LampState()}");
                }
            }
        }

        internal void SwitchLamp(string lampadina)
        {
            foreach(Lamp item in lampList)
            {
                if (item.roomName == lampadina)
                {
                    item.Switch();
                }
            }
        }
    }
    
}
