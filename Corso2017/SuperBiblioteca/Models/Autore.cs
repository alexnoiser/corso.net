using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperBiblioteca.Models
{
    public class Autore
    {
        public int Id { get; set; }
        [DisplayName("Nome Autore")]
        [Required]
        public string Nome { get; set; }
        [DisplayName("Indirizzo Autore")]
        [Required]
        public string Indirizzo { get; set; }
        public IEnumerable<Libro> CollezioneLibri { get; set; }
    }
}
