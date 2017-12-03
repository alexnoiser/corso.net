using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GestionaleAcciaieria.DataAccess;
using GestionaleAcciaieria.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GestionaleAcciaieria.Controllers
{
    public class PosatoreController : Controller
    {
        private AppDbContext _context;

        public PosatoreController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {


            var model = _context.Posatore
                  .ToList();

            return View(model);
        }

        public IActionResult Edit(int id)
        {
            Posatore model;

            if (id == 0)
                model = new Posatore();
            else
                model = _context.Posatore
                        .Where(t => t.Id == id)
                        .Single();



            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Posatore model)
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

            _context.Posatore.Update(model);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));  //ti rimanda a IActionResult Index e poi fa la procedura : poco più sopra.
        }


        public IActionResult Delete(int id)
        {

            Posatore model;

            model = _context.Posatore
                        .Where(t => t.Id == id)
                        .Single();

            _context.Posatore.Remove(model);

            _context.SaveChanges();

            return RedirectToAction(nameof(Index));  //ti rimanda a IActionResult Index e poi fa la procedura : poco più sopra.
        }

        public IActionResult TubiPerPosatore(int id)
        {
            var model = _context.Posatore
                     .Include(x => x.ElencoTubi)
                     .ThenInclude(x => x.Materiale)
                     .Single(x => x.Id == id);

            return View(model);
        }
    }
}
