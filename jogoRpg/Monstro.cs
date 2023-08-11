using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoRpg
{
    public class Monstro
    {
        public String Nome { get; set; }
        public int vida { get; set; }
        public int Ataque { get; set; }
        public int Xp { get; set; }

        public Monstro(string nome, int vida, int ataque)
        {
            this.Nome = nome;
            this.vida = vida;
            this.Ataque = ataque;
            this.Xp = vida + Ataque;
        }
       
    }
}
