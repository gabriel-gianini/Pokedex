using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokedex
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Pokedex pokedex = new Pokedex();
            int resp = 100;
            while(resp !=0)
            {
                resp = Menu();
                if(resp == 1)
                {
                    pokedex.ListarPokemons();
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        static int Menu()

        {
            Console.WriteLine("Pokédex----Agenda Pokemon");
            Console.WriteLine("1----Listar todos os Pokemons");
            Console.WriteLine("0---- Sair da Pokédex");
            Console.WriteLine("Oque deseja Fazer??");
            int resp= Convert.ToInt32(Console.ReadLine());
            return resp;
        }

    }
}
