using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoRpg
{
    public class Heroi
    {
        public String Nome { get; set; }
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public int Nivel { get; set; }
        public int Xp { get; set; }
        public int AtaqueBase { get; set; }

        public Heroi(string nome)
        {
            Random Aleatorio = new Random();
            this.Nome = nome;
            this.Nivel = 1;
            this.Vida = 10;
            this.AtaqueBase = Aleatorio.Next(1, 50) + Nivel;
            this.Ataque = AtaqueBase;
            this.Xp = 0;

        }
        public void GanharXp(int experiencia)
        {
            Xp += experiencia;
            int novoNivel = (Xp / 10) + 1;
            if (novoNivel > Nivel)
            {
                Console.WriteLine("\nVocê aumentou de nível!");
                Vida = novoNivel * 10;
            }
            Nivel = novoNivel;
            AtaqueBase = AtaqueBase + Nivel;
        }


    }
}
