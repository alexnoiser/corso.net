using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova5
{
    class Program
    {
        static void Main(string[] args)
        {

            LampManager lista = new LampManager();//istanzio un oggetto di tipo LampManager
            Menu();
            //Console.ReadLine();

            bool loop = true;
            while(loop)
            {
                string input = Console.ReadLine();
                string lampadina;
                bool isPresent;
                switch (input)
                {
                    case "1":
                        lampadina = AcquisisciLampadina();
                        isPresent = lista.CheckLamp(lampadina);
                        if (!isPresent)
                        {
                            Lamp l = new Lamp(lampadina);
                            lista.AddLamp(l);
                            Console.WriteLine("ok aggiunta");
                            Menu();
                            
                        }
                        else
                        {
                            lista.AlreadyExistingError();
                            Menu();
                            
                        }
                        break;
                        
                        
                    case "2":
                        lampadina = AcquisisciLampadina();
                        isPresent = lista.CheckLamp(lampadina);
                        if (isPresent)
                        {
                            lista.RemoveLamp(lampadina);
                            Menu();
                        }
                        else
                        {
                            lista.NotExistingError();
                            Menu();
                        }
                        
                        break;

                    case "3":
                        lista.PrintList();
                        Menu();
                        break;

                    case "4":
                        lampadina = AcquisisciLampadina();
                        isPresent = lista.CheckLamp(lampadina);
                        if (isPresent)
                        {
                            lista.SwitchLamp(lampadina);
                            Menu();


                        }
                        else
                        {
                            lista.NotExistingError();
                            Menu();
                        }
                        break;


                    case "5":
                        loop = false;
                        break;

                }
            }
            Console.Clear();
            Console.WriteLine("");

            //list.AddLamp(input);
            //chiamo un metodo void
            // oggetto.Metodo(inputMetodo)
            //string cheneso = list.SayLamp(); //chiamo un metodo che restituisce una stringa
        }

        

        private static string AcquisisciLampadina()
        {
            Console.WriteLine("Scrivi il nome della stanza");
            string lamp = Console.ReadLine();
            /*
             * Lamp l = new Lamp(lamp);
             */
            return lamp;
        }

        

        private static void Menu()
        {
            //Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Menu configurazione centralina SmartHome");
            Console.WriteLine("[1] Aggiungi Lampadina");
            Console.WriteLine("[2] Togli Lampadina");
            Console.WriteLine("[3] Stampa le stanze dove è presente la lampadina e se sono ON o OFF");
            Console.WriteLine("[4] Accendi Spegni lampadine");
            Console.WriteLine("[5] Esci dal programma");
            //Console.ReadLine();
        }
    }
}
