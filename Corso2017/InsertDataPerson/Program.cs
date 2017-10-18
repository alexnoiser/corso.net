using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertPersonData
{
    class Program
    {
        enum UserInput { AddPerson, DelPerson, PrintPersons, Exit, Error, Number }
        

        static void Main(string[] args)
        {

            bool memory;
            bool loop = false;
            MonitorConsole.PrintMemoryChoise();
            string input = Console.ReadLine();
            if (input == "r") memory = false;
            if(input == "d") memory = true; 
            Console.WriteLine("Impostazioni salvate");
            loop = true;
                        
            while (loop)
            {


                               
                MonitorConsole.PrintMenu();
                input = Console.ReadLine();
                List<Person> PersonList = new List<Person>();
                UserInput result = GetInput(input);
                //PersonManager personManager = new PersonManager();

                if (result == UserInput.Exit)
                {
                    break;
                }
                if (result == UserInput.AddPerson)
                {
                    AddDataPerson();
                }
                if (result == UserInput.DelPerson)
                {
                    DelDataPerson();
                }
                if (result == UserInput.PrintPersons)
                {
                    
                    PrintPersonList();
                }
                if (result == UserInput.Error)
                {
                    Console.WriteLine("Attenzione il comando inserito non corrisponde ad un numero");
                }
            }
            Console.WriteLine("Uscita in corso...");
        }



        private static UserInput GetInput(string input)
        {

            UserInput result = UserInput.Error;

            if (input == "4")
            {
                // number = 0;
                result = UserInput.Exit;
            }
            if (input == "1")
            {
                result = UserInput.AddPerson;
            }
            if (input == "2")
            {
                result = UserInput.DelPerson;
            }
            if (input == "3")
            {
                result = UserInput.PrintPersons;
            }

            return result;


        }

        internal void ConsoleInput()
        {
            Console.WriteLine("");
            Console.WriteLine("Menu Inserimento dati");
            Console.WriteLine("[1] Aggiungi Nuova Persona");
            Console.WriteLine("[2] Rimuovi Persona esistente");
            Console.WriteLine("[3] Stampa elenco di persone");
            Console.WriteLine("[4] Esci dal programma");

        }
        //internal static List<PersonManager> UserData (string nome, string cognome, string birthday, int id)
        //{
        //    PersonManager Anagrafica = new PersonManager();

        //    id = 0;
        //    MonitorConsole.PrintNameRequest();
        //    nome = Console.ReadLine();
        //    MonitorConsole.PrintSurnameRequest();
        //    cognome = Console.ReadLine();
        //    MonitorConsole.PrintBirtdayRequest();
        //    birthday = Console.ReadLine();
        //    id = id++;
        //    Anagrafica.AddPerson(nome, cognome, birthday, id);          

        //    return Anagrafica;

        //}
        //internal static Person UserData(string nome, string cognome, string birthday, int id)
        //{

        //    Person datiUtente = new Person(nome, cognome, birthday, id);
        //    //PersonManager Anagrafica = new PersonManager();
        //    id = 0;
        //    MonitorConsole.PrintNameRequest();
        //    nome = Console.ReadLine();
        //    MonitorConsole.PrintSurnameRequest();
        //    cognome = Console.ReadLine();
        //    MonitorConsole.PrintBirtdayRequest();
        //    birthday = Console.ReadLine();
        //    id = id++;



        //    return datiUtente;



        //}
        internal static void AddDataPerson()
        {
            PersonManager personManager = new PersonManager();
            MonitorConsole.PrintNameRequest();
            string nome = Console.ReadLine();
            MonitorConsole.PrintSurnameRequest();
            string cognome = Console.ReadLine();
            MonitorConsole.PrintBirtdayRequest();
            string birthday = Console.ReadLine();
            int id = 0;
            id = id++;
            personManager.AddPerson(nome, cognome, birthday, id);
            personManager.AddPerson();
            return;

        }
        private static void DelDataPerson()
        {
            PersonManager personManager = new PersonManager();
            MonitorConsole.PrintRemoveIdRequest();
            string _id = Console.ReadLine();
            int.TryParse(_id, out int id);
            string nome = string.Empty;
            string cognome = string.Empty;
            string birthday = string.Empty;
            personManager.DelPerson(nome, cognome, birthday, id);
            return;

        }
        private static void PrintPersonList()//(string nome, string cognome, string birthday, int id)
        {
            PersonManager personManager = new PersonManager();
            List<Person> PersonList = new List<Person>();
            //Person user = new Person(nome, cognome, birthday, id);
            
            foreach (Person item in PersonList)
            {
                Console.WriteLine($"Le persone registrate sono: {item.Id}, {item.Nome}, {item.Cognome}, {item.Birthday} ");
            }
            
            return;

        }


    }
}