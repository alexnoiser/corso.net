using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperBiblioteca.Models
{
    public class Biblioteca
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Citta { get; set; }
        public IEnumerable<Libro> ListaLibri { get; set; }


    }
}
