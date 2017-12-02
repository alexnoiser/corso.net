using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperBiblioteca.DataAccess;
using Microsoft.EntityFrameworkCore;
using SuperBiblioteca.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SuperBiblioteca.Controllers
{
    public class AutoreController : Controller
    {

        private AppDbContext _context;

        public AutoreController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {


            var model = _context.Autore
                .Include(x => x.CollezioneLibri)
                .ToList();

            return View(model);
        }

        public IActionResult Edit(int id)
        {
            Autore model;

            if (id == 0)
                model = new Autore();
            else
                model = _context.Autore
                        .Where(t => t.Id == id)
                        .Single();

                

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Autore model)
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

            _context.Autore.Update(model);
            _context.SaveChanges();
            
            return RedirectToAction(nameof(Index));  //ti rimanda a IActionResult Index e poi fa la procedura : poco più sopra.
        }

        
        public IActionResult Delete(int id)
        {

            Autore model;

            model = _context.Autore
                        .Where(t => t.Id == id)
                        .Single();

            _context.Autore.Remove(model);
            
            _context.SaveChanges();
            
            return RedirectToAction(nameof(Index));  //ti rimanda a IActionResult Index e poi fa la procedura : poco più sopra.
        }

        public IActionResult LibriPerAutore(int id)
        {
            var model = _context.Autore
                     .Include(x => x.CollezioneLibri)
                     .ThenInclude(x => x.Biblioteca)
                     .Single(x => x.Id == id);

            return View(model);
        }


    }
}
