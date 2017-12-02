using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperBiblioteca.DataAccess;
using Microsoft.EntityFrameworkCore;
using SuperBiblioteca.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SuperBiblioteca.Controllers
{
    public class LibroController : Controller
    {
        private AppDbContext _context;

        public LibroController(AppDbContext context)
        {
            _context = context;
        }

        
        // GET: /<controller>/
        public ViewResult Index()
        {

            var model = _context.Libro
                .Include(x => x.Biblioteca)
                .Include(x=> x.Autore)
                .ToList();
                


            return View(model);
        }



        public ViewResult Edit(int id)
        {
            
            LibroViewModel modelBiblio = new LibroViewModel();

            
            if (id == 0)
                modelBiblio.Libro = new Libro();
            else
                modelBiblio.Libro = _context.Libro
                    .Include(x => x.Biblioteca)
                    .Single(x => x.Id == id);

            modelBiblio.ListaBiblioteche = _context.Biblioteca
                .Select(x => new SelectListItem { Text = x.Nome, Value = x.Id.ToString() })
                .ToList();

            modelBiblio.ListaAutori = _context.Autore
                .Select(x => new SelectListItem { Text = x.Nome, Value = x.Id.ToString() })
                .ToList();


            return View(modelBiblio);
        }


        [HttpPost]
        public IActionResult Edit(LibroViewModel model)
        {

            //if (!ModelState.IsValid)
            //    return View(model);

            
            
           
            //_context.Autore.Add(autore);

            //model.Libro.Autore = autore;



            if (model.Libro.Id == 0)
                _context.Libro.Add(model.Libro);
            else
                _context.Libro.Update(model.Libro);

            _context.SaveChanges();


            return RedirectToAction(nameof(Index));


            
        }

        public IActionResult Delete(int id)
        {

            

           var model = _context.Libro
                        .Where(t => t.Id == id)
                        .Single();

            _context.Libro.Remove(model);

            _context.SaveChanges();

            return RedirectToAction(nameof(Index));  //ti rimanda a IActionResult Index e poi fa la procedura : poco più sopra.
        }
    }
}
