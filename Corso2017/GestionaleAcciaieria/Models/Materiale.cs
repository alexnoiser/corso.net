using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionaleAcciaieria.Models
{
    public class Materiale
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [DisplayName("Classe di Appartenenza")]
        [Required]
        public string ClasseAppartenenza { get; set; }
        [DisplayName("Coefficente di Fragilità")]
        [Required]
        public int CoeffFragilita { get; set; }
        public IEnumerable<Tubo> ListaMateriali { get; set; }
    }
}
