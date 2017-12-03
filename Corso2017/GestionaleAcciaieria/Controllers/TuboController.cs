using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GestionaleAcciaieria.DataAccess;
using Microsoft.EntityFrameworkCore;
using GestionaleAcciaieria.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GestionaleAcciaieria.Controllers
{
    public class TuboController : Controller
    {
        private AppDbContext _context;

        public TuboController(AppDbContext context)
        {
            _context = context;
        }



        public IActionResult Index()
        {
            var model = _context.Tubo
                .Include(x => x.Materiale)
                .Include(x => x.Posatore)
                .ToList();
           
            
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            TuboViewModel modelTubi = new TuboViewModel();

            if (id == 0)
                modelTubi.Tubo = new Tubo();
            else
                modelTubi.Tubo = _context.Tubo
                    .Include(x => x.Materiale)
                    .Single(x => x.Id == id);

            modelTubi.ListaPosatori = _context.Posatore
                .Select(x => new SelectListItem { Text = x.Nome+ " " +x.Cognome, Value = x.Id.ToString() })
                .ToList();

            modelTubi.ListaMateriali = _context.Materiale
                .Select(x => new SelectListItem { Text = x.Nome, Value = x.Id.ToString() })
                .ToList();
            
            return View(modelTubi);
        }

        [HttpPost]
        public IActionResult Edit(TuboViewModel model)
        {
            if (model.Tubo.Id == 0)
                _context.Tubo.Add(model.Tubo);
            else
                _context.Tubo.Update(model.Tubo);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));

            
        }

        public IActionResult Delete(int id)
        {



            var model = _context.Tubo
                         .Where(t => t.Id == id)
                         .Single();

            _context.Tubo.Remove(model);

            _context.SaveChanges();

            return RedirectToAction(nameof(Index));  //ti rimanda a IActionResult Index e poi fa la procedura : poco più sopra.
        }
    }
}
