using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionaleAcciaieria.Models
{
    public class Tubo
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Lunghezza tubo in Metri")]
        public int LunghezzaTubo { get; set; }

        public int MaterialeId { get; set; }
        public Materiale Materiale { get; set; }
        public int PosatoreId { get; set; }
        public Posatore Posatore { get; set; }
    }
}
