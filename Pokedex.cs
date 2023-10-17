using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokedex
{
    public class Pokedex
    {
        public Pokedex()
        {
            this.InicializaLista();
        }
        private List<pokemon> pokemons;

        public List<pokemon> Pokemons
        {
            get { return pokemons; }
        }

        private void InicializaLista()
        {
            //instanciar a lista
            this.pokemons = new List<pokemon>();
            pokemon p = new pokemon("Bulbassauro", "pokemon planta");
            this.pokemons.Add(p);
            p=new pokemon("Mew", "lendario psiquico");
            this.pokemons.Add(p);
            p = new pokemon("muk", "pokemon toxico");
            this.pokemons.Add(p);
            p = new pokemon("Fligon", "pokemon dragão");
            this.pokemons.Add(p);
            p = new pokemon("metagross", "pokémon de metal");
            this.pokemons.Add(p);
            p = new pokemon("mewTwo", "lendario psiquico");
            this.pokemons.Add(p);
            p = new pokemon("Charizard", "pokemon de fogo");
            this.pokemons.Add(p);
            p = new pokemon("kyogre", "lendario de agua");
        }

        public void ListarPokemons()
        {
            for (int i = 0; i < this.pokemons.Count; i++)
            {
                pokemon p = this.pokemons[i];
                p.ExibirDadosPokemon();
            }
        }
    }
}
