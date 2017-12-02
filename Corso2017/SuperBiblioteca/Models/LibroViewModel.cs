using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperBiblioteca.Models
{
    public class LibroViewModel
    {
        public Libro Libro{ get; set; }
        public IEnumerable<SelectListItem> ListaBiblioteche { get; set; }
        public IEnumerable<SelectListItem> ListaAutori { get; set; }

        
    }
}
