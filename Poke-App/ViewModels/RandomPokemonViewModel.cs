using Poke_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Poke_App.ViewModels
{
    public class RandomPokemonViewModel
    {
        public Pokemon Pokemon { get; set; }
        public List<Owner> Owners { get; set; }
    }
}