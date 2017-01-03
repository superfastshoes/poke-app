using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Poke_App.Models;
using System.Data.Entity;

namespace Poke_App.Controllers
{
    public class OwnersController : Controller
    {
        //Need to a DbContext to access the database
        private ApplicationDbContext _context;

        public OwnersController()
        {
            _context = new ApplicationDbContext();
        }

        //Properly dispose the DbContext object
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // For the index page, returns a list of Owners
        public ViewResult Index()
        {
            var owners = _context.Owner.Include(c => c.PokemonDeck).ToList();
            return View(owners);
        }

        // For the details page
        public ActionResult Details(int id)
        {
            var owner = _context.Owner.Include(c => c.PokemonDeck).SingleOrDefault(c => c.Id == id);

            if (owner == null)
                return HttpNotFound();

            return View(owner);
        }
    }
}