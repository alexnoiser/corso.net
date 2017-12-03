using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GestionaleAcciaieria.DataAccess;
using Microsoft.EntityFrameworkCore;
using GestionaleAcciaieria.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GestionaleAcciaieria.Controllers
{
    public class MaterialeController : Controller
    {
        private AppDbContext _context;

        public MaterialeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {


            var model = _context.Materiale
                  .ToList();

            return View(model);
        }

        public IActionResult Edit(int id)
        {
            Materiale model;

            if (id == 0)
                model = new Materiale();
            else
                model = _context.Materiale
                        .Where(t => t.Id == id)
                        .Single();



            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Materiale model)
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

            _context.Materiale.Update(model);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));  //ti rimanda a IActionResult Index e poi fa la procedura : poco più sopra.
        }


        public IActionResult Delete(int id)
        {

            Materiale model;

            model = _context.Materiale
                        .Where(t => t.Id == id)
                        .Single();

            _context.Materiale.Remove(model);

            _context.SaveChanges();

            return RedirectToAction(nameof(Index));  //ti rimanda a IActionResult Index e poi fa la procedura : poco più sopra.
        }

        
    }
}
