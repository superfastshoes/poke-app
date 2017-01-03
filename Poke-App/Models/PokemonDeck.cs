using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Poke_App.Models
{
    public class PokemonDeck
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Pokemons { get; set; }
        public int Trainers { get; set; }
        public int Energies { get; set; }
    }
}