using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperBiblioteca.DataAccess;
using SuperBiblioteca.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SuperBiblioteca.Controllers
{
    public class BibliotecaController : Controller
    {
        private AppDbContext _context;

        public BibliotecaController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {


            var model = _context.Biblioteca

                .ToList();

            return View(model);
        }

        public IActionResult Edit(int id)
        {
            Biblioteca model;

            if (id == 0)
                model = new Biblioteca();
            else
                model = _context.Biblioteca
                        .Where(t => t.Id == id)
                        .Single();



            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Biblioteca model)
        {


            if (!ModelState.IsValid)
                return View(model);

            //if (model.Nome != "")
            //{
            //    var autore = new Autore();
            //    autore.Nome = model.Nome;

            //    _context.Autore.Add(autore);

            //    model = autore;
            //}

            _context.Biblioteca.Update(model);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));  //ti rimanda a IActionResult Index e poi fa la procedura : poco più sopra.
        }


        public IActionResult Delete(int id)
        {

            Biblioteca model;

            model = _context.Biblioteca
                        .Where(t => t.Id == id)
                        .Single();

            _context.Biblioteca.Remove(model);

            _context.SaveChanges();

            return RedirectToAction(nameof(Index));  //ti rimanda a IActionResult Index e poi fa la procedura : poco più sopra.
        }

        public IActionResult LibriPerBiblioteca(int id)
        {
            var model = _context.Biblioteca
                    .Include(x => x.ListaLibri)
                    .ThenInclude(x => x.Autore)
                    .Single(x => x.Id == id);

            return View(model);
        }
    }
}
