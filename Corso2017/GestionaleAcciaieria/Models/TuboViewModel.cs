using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionaleAcciaieria.Models
{
    public class TuboViewModel
    {
        public Tubo Tubo { get; set; }
        public IEnumerable<SelectListItem> ListaPosatori { get; set; }
        public IEnumerable<SelectListItem> ListaTubiPosati { get; set; }
        public IEnumerable<SelectListItem> ListaMateriali { get; set; }
    }
}
