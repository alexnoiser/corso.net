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
        static void Main(string[] args)
        {
            Lamp salonLamp = new Lamp("Salon");
            string input = Console.ReadLine();

            while (true)
            {
                createMenu();
                addLamp();

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

        private static void addLamp()
        {
            throw new NotImplementedException();
        }

        private static void createMenu()
        {
            Console.WriteLine("Menu configurazione centralina SmartHome");
            Console.WriteLine("[1] Aggiungi Lampadina");
            Console.WriteLine("[2] Togli Lampadina");
            Console.WriteLine("[3] Stampa il numero di Lampadine");
            Console.WriteLine("[4] Esci dal programma");
            Console.ReadLine();

        }

        private static void WriteStatus(Lamp lamp)
        {
            Console.WriteLine($"{ lamp.Room } lamp is { lamp.Status }");
        }

        private static int GetMenuNumber(input, int selection, int addLamp)
        {
            ArrayList lampNumber = new ArrayList();

            if (input == "1")
                selection = lampNumber.Add(addLamp);
                return selection;
        }
       


    }    

    
}
