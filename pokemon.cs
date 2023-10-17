using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokedex
{
    public class pokemon
    {
        public pokemon()
        {
            this.Nome = "";
            this.Descricao = "";
        }

        public pokemon(string nome,String descricao)
        {
            this.Nome = nome;
            this.Descricao = descricao;
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set {
                String texto = value.ToUpper();
                nome = texto; }
        }

        private string descricao; //amarzena o valor da prpriedade descricao

        public string Descricao // representa a caracteristica descricao do meu pokemon
        {
            get { return this.descricao; }
            set { 

               this.descricao = value.ToUpper(); }
        }

        public void ExibirDadosPokemon()
        {
            Console.WriteLine("nome do Pokémon: " + this.Nome);
            Console.WriteLine("Descrição do Pokémon: " + this.Descricao);
        }

        public void ExibirDadosPokemon(Boolean formatado)
        {
            if(formatado==true)
            {
                Console.WriteLine("nome do Pokémon" + this.Nome + " : " + this.Descricao.ToLower());
                
            }
            else
            {
                Console.WriteLine("nome do Pokémon: " + this.Nome) ;
                Console.WriteLine("Descrição do Pokémon: " + this.Descricao);
            }
          
        }
    }
}
