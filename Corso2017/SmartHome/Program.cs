using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    class Program
    {
        

        enum InputResult { Number, Exit, Error, AddLamp, DelLamp, Print, Switch }
        //enum MenuNumber { AddLamp, DelLamp, Print, Switch, Exit}

        static void Main(string[] args)
        {
            Lamp salonLamp = new Lamp("Salon");
            string input = Console.ReadLine();
            bool loop = true;
            while (loop)
            {
                //InputResult result = VerifyInput(input, out int number);

                Console.WriteLine("Menu configurazione centralina SmartHome");
                Console.WriteLine("[1] Aggiungi Lampadina");
                Console.WriteLine("[2] Togli Lampadina");
                Console.WriteLine("[3] Stampa il numero di Lampadine nelle varie stanze");
                Console.WriteLine("[4] Accendi Spegni lampadine");
                Console.WriteLine("[5] Esci dal programma");
                Console.ReadLine();

                InputResult result = VerifyInput(input, out int number);
                if (result == InputResult.AddLamp)
                    Console.WriteLine("In quale stanza vuoi aggiungere la lampadina? scrivi il nome della stanza.");
                    AddLamp();

                if (result == InputResult.DelLamp)
                    Console.WriteLine("In quale stanza vuoi rimuovere la lampadina? scrivi il nome della stanza.");

                //GetMenuNumber(int selection);
                AddLamp();

            }

            //salon.Room = "Salon";
            //string status = salon.IsOn ? "on" : "off";

            WriteStatus(salonLamp);
            salonLamp.TurnOn();
            WriteStatus(salonLamp);

            Lamp kitchenLamp = new Lamp("Kitchen");
            WriteStatus(kitchenLamp);

            Lamp kitchenBackup = kitchenLamp;
            kitchenLamp = salonLamp;
            kitchenLamp.TurnOff();

            WriteStatus(salonLamp);

            Console.ReadLine();
        }

        private static void AddLamp()
        {
            //Console.WriteLine("In quale stanza vuoi aggiungere la lampadina? scrivi il nome della stanza.");
            ArrayList roomList = new ArrayList();
            string input = Console.ReadLine();
            
            
            foreach (string item in roomList)
            {
                roomList.Add(input += 1);
                //if (roomList.Contains(input))
                //{

                Console.WriteLine(string.Format("aggiunto 1 lampadina nella stanza {}" ,input));
                //}
            }
           

        }

        private static InputResult VerifyInput(string input, out int number)
        {
            input = Console.ReadLine();
            InputResult result = InputResult.Error;
            number = 0;
            
            if (input == "1")
            {
                result = InputResult.AddLamp;
            }
            if (input == "2")
            {
                result = InputResult.DelLamp;
            }
            if (input == "3")
            {
                result = InputResult.Print;
            }
            if (input == "4")
            {
                result = InputResult.Switch;
            }
            if (input == "5")
            {
                result = InputResult.Exit;
            }
            return result;
            
        } 
            
            
        

        private static void WriteStatus(Lamp lamp)
        {
            Console.WriteLine($"{ lamp.Room } lamp is { lamp.Status }");
        }

       
        
       


    }    

    
}
