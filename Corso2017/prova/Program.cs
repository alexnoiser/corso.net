using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        private const string EXIT = "5";

        enum InputResult { Number, Equals, Error }
        enum MenuNumber { AddLamp, DelLamp, Print, Switch, Exit, Number }

        static void Main(string[] args)
        {
            ArrayList addends = new ArrayList();
            //List<string> addends = new List<int>();

            int sum = 0;

            while (true)
            {
                
                //Console.WriteLine($"Inserisci l'addendo ('=' per effettuare la somma)");
                Console.WriteLine("Menu configurazione centralina SmartHome");
                Console.WriteLine("[1] Aggiungi Lampadina");
                Console.WriteLine("[2] Togli Lampadina");
                Console.WriteLine("[3] Stampa il numero di Lampadine nelle varie stanze");
                Console.WriteLine("[4] Accendi Spegni lampadine");
                Console.WriteLine("[5] Esci dal programma");
                string input = Console.ReadLine();



                InputResult result = VerifyInput(input, out int number);

                if (result == InputResult.Equals)
                {
                    break;
                }
                if (result == InputResult.Number)
                {
                   
                    AddLamp();
                    //addends.Add(number);
                    
                }
                else
                {
                    Console.WriteLine("Non hai inserito un numero intero");
                }
            }

            Console.WriteLine("uscita dal programma in corso...");
            //Console.WriteLine(string.Format("La somma è {0} e ho sommato {1} addendi", sum, addends.Count));

            //Console.WriteLine($"I numeri pari inseriti sono: { string.Join(", ", GetNumbers(NumberType.Even, addends)) }");
            //Console.WriteLine($"I numeri dispari inseriti sono: { string.Join(", ", GetNumbers(NumberType.Odd, addends)) }");

            Console.ReadLine();
        }

        //private static List<int> GetNumbers(NumberType numberType, List<int> addends)
        //{
        //    int modResult = numberType == NumberType.Even ? 0 : 1;

        //    List<int> selectedNumbers = new List<int>();

        //    //for (int i = 0; i < addends.Count; i++)
        //    //{
        //    //    if (addends[i] % 2 == modResult)
        //    //        selectedNumbers.Add(addends[i]);
        //    //}

        //    //int count = 0;
        //    foreach (int addend in addends)
        //    {
        //        //if (count < 40)
        //        //{
        //        //    count++;
        //        //    continue;
        //        //}

        //        if (Math.Abs(addend % 2) == modResult)
        //            selectedNumbers.Add(addend);
        //    }

        //    return selectedNumbers;
        //}

        private static InputResult VerifyInput(string input, out int number)
        {
            InputResult result = InputResult.Error;

           if (input == EXIT)
            {
                number = 0;
                result = InputResult.Equals;
            }
           else if (int.TryParse(input, out number))
            {
                result = InputResult.Number;
            }
            return result;
        }

        public static void AddLamp(List<string> roomList , out string list)
        {
            Console.WriteLine("In quale stanza vuoi aggiungere la lampadina? scrivi il nome della stanza.");
            //List<string> roomList = new List<string>();
            string input = Console.ReadLine();
            list = string.Empty;

            foreach (string item in roomList)
            {
                roomList.Add(input += 1);
                //if (roomList.Contains(input))
                //{

                
                //}
            }
            
            //Console.WriteLine(string.Format("aggiunto 1 lampadina nella stanza {}", roomList));
            Console.WriteLine("Aggiunto una lampadina nella stanza bagno");
            Console.WriteLine("");


        }

        private static  StampList()
        {
            Console.WriteLine("Questo è il riepilogo delle luci nelle stanze.");
            //ArrayList roomList = new ArrayList();
            //string input = Console.ReadLine();


            foreach (string item in roomList)
            {
                //roomList.Add(input += 1);
                //if (roomList.Contains(input))
                //{


                //}
            }
            //Console.WriteLine(string.Format("aggiunto 1 lampadina nella stanza {}", roomList));
            Console.WriteLine("Aggiunto una lampadina nella stanza bagno");
            Console.WriteLine("");


        }
        //private static void VerifyInput(ref int sum, out int originalValue)
        //{
        //    originalValue = sum;
        //    sum += 10;
        //}
        private static MenuNumber GetMenuNumber (string input, out int number)
        {
            MenuNumber result = new MenuNumber();
            if (input == "1")
            {
                result = MenuNumber.AddLamp;
            }
            if (input == "2")
            {
                result = MenuNumber.DelLamp;
            }
            if (input == "3")
            {
                result = MenuNumber.Print;
            }
            if (input == "4")
            {
                result = MenuNumber.Switch;
            }
            if (input == "5")
            {
                result = MenuNumber.Exit;
            }
            if (int.TryParse(input, out number))
            {
                result = MenuNumber.Number;
            }


            return result;
        }
    }
}