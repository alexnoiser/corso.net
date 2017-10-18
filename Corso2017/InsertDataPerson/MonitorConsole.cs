using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertPersonData
{
    class MonitorConsole
    {
        public static void PrintMenu()
        {

            Console.WriteLine("");
            Console.WriteLine("Menu Inserimento dati");
            Console.WriteLine("[1] Aggiungi Nuova Persona");
            Console.WriteLine("[2] Rimuovi Persona esistente");
            Console.WriteLine("[3] Stampa elenco di persone");
            Console.WriteLine("[4] Esci dal programma");
            //Console.ReadLine();


        }
        public static void PrintMemoryChoise()
        {

            Console.WriteLine("");
            Console.WriteLine("Dove vuoi che vengano salvati i dati? premi 'r' per memoria RAM, 'd' per Hard Disk");
            


        }
        public static void PrintNameRequest()
        {
            Console.WriteLine("Inserisci il 'Nome' della persona e premi INVIO");
        }
        public static void PrintSurnameRequest()
        {
            Console.WriteLine("Inserisci il 'Cognome' della persona e premi INVIO");
        }
        public static void PrintBirtdayRequest()
        {
            Console.WriteLine("Inserisci la data di nascita della persona nel formato DD/MM/YYYY e premi INVIO");
        }
        public static void PrintRemoveIdRequest()
        {
            Console.WriteLine("Inserisci l'Id' della persona che vuoi eliminare e premi INVIO. Per vedere l'elenco delle persone, torna al menu principare e premi [3]");
        }
        public static void PrintNotExist()
        {
            Console.WriteLine("Attenzione non ci sono Persone memorizzate nella Lista");
        }
        public static void PersonNotExist()
        {
            Console.WriteLine("Attenzione il nome da te inserito non è presente nella Lista");
        }
        public static void PersonAlreadyExist()
        {
            Console.WriteLine("Attenzione il nome da te inserito non è presente nella Lista");
        }
        public static void PersonAdded()
        {
            Console.WriteLine("Dati persona aggiunti con successo");
        }
        public static void PersonDeleted()
        {
            Console.WriteLine("Dati persona cancellati con successo");
        }

    }
}
