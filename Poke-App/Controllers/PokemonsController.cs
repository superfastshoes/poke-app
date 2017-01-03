using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Poke_App.Models;
using Poke_App.ViewModels;
using System.Data.Entity;


namespace Poke_App.Controllers
{
    public class PokemonsController : Controller
    {
        private ApplicationDbContext _context;

        public PokemonsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // For the pokemon index page, displays a list of all pokemons
        public ViewResult Index()
         {
             var pokemons = _context.Pokemon.Include(p => p.PokemonType).ToList();
 
             return View(pokemons);    
         }

        public ActionResult Details(int id)
        {
            var pokemon = _context.Pokemon.Include(path => path.PokemonType).SingleOrDefault(p => p.Id == id);

            if (pokemon == null)
                return HttpNotFound();

            return View(pokemon);
        }
        
    }
}