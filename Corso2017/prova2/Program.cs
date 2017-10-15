using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> roomList = new List<string>();
            while (true)
            {

                //Console.WriteLine($"Inserisci l'addendo ('=' per effettuare la somma)");
                Console.WriteLine("");
                Console.WriteLine("Menu configurazione centralina SmartHome");
                Console.WriteLine("[1] Aggiungi Lampadina");
                Console.WriteLine("[2] Togli Lampadina");
                Console.WriteLine("[3] Stampa le stanze dove è presente la lampadina e se sono ON o OFF");
                Console.WriteLine("[4] Accendi Spegni lampadine");
                Console.WriteLine("[5] Esci dal programma");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("In quale stanza vuoi inserire la lampadina? Scrivi nome es: Bagno o Camera");

                    string room = Console.ReadLine();
                    if (room != string.Empty)
                    {
                        if (!roomList.Contains(room))
                        {
                            roomList.Add(room);
                            int lampState = false ? 0 : 1;
                            Console.WriteLine($"Hai aggiunto una lampadina nella stanza {room} + {lampState}");

                        }
                        else
                        {

                            Console.WriteLine("Attenzione è già presente una lampadina in questa stanza");

                        }


                    }
                    else
                    {
                        Console.WriteLine("Attenzione Nome vuoto:  non è possibile aggiungere una stanza senza nome");
                    }
                }
                if (input == "2")
                {
                    Console.WriteLine("Da quale stanza vuoi togliere la lampadina?");
                    string room = Console.ReadLine();
                    if (room != string.Empty)
                    {
                        if (roomList.Contains(room))
                        {
                            Console.WriteLine($"Hai tolto la lampadina dalla stanza {room}");
                            roomList.Remove(room);

                        }
                        else
                        {
                            Console.WriteLine($"Attenzione la stanza inserita non è presente nell'elenco. Premi [3] per vedere la lista");

                        }


                    }
                    else
                    {
                        Console.WriteLine("Attenzione Nome vuoto:  non è possibile aggiungere una stanza senza nome");
                    }

                }
                if (input == "3")
                {
                    if (roomList.Count == 0)
                    {
                        Console.WriteLine("Non vi sono lampadine in nessuna stanza");
                    }
                    else
                    {

                        bool lampState = false;
                        string stato = "OFF";
                        if (lampState == false) stato = "OFF"; else stato = "ON";
                        Console.WriteLine("Attualmente è presente la lampadina nelle seguenti stanze:" + "" + "");
                        for (int i = 0; i < roomList.Count; i++)
                        {
                            Console.WriteLine($"{roomList.ElementAt(i)} + {stato}");
                            //Console.WriteLine(stato);
                        }

                    }


                }
                if (input == "4")
                {
                    Console.WriteLine("Quale stanza vuoi gestire ?");
                    string room = Console.ReadLine();
                    bool IsOn;
                    if (room != string.Empty)
                    {
                        if (roomList.Contains(room))
                        {
                            Console.WriteLine($"Premi [+] per accendere [-] per spegnere la lampadina della stanza {room}");
                            string input_ = Console.ReadLine();
                            if (input_ == "+")
                            {
                                IsOn = true;
                            }
                            if (input_ == "-")
                            {
                                IsOn = false;
                            }
                            
                            
                        }
                        else
                        {
                            Console.WriteLine($"Attenzione la stanza inserita non è presente nell'elenco. Premi [3] per vedere la lista");

                        }

                    }
                    

                }



            }
        }
    }
}
