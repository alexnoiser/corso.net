using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperBiblioteca.Models
{
    public class Libro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int BibliotecaId { get; set; }
        public int AutoreId { get; set; }
        public Biblioteca Biblioteca { get; set; }
        public string Argomento { get; set; }
        public int NumeroPagine { get; set; }
        public Autore Autore { get; set; }

    }
}
