using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertPersonData
{
    class Person

    {

        //List<string> PersonList = new List<string>();
        public string Nome { get; private set; }
        public string Cognome { get; private set; }
        public string Birthday { get; private set; }
        public int Id { get; private set; }

        public Person(string nome, string cognome, string birthday, int id)
        {
            Nome = nome;
            Cognome = cognome;
            Birthday = birthday;
            Id = id;
        }

        
                    



    }
}