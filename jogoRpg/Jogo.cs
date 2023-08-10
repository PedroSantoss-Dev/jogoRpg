using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoRpg
{
    public class Jogo
    {
        public void Iniciar()
        {
            Console.WriteLine("Digite seu nome:");
            Console.ReadLine();
            Menu();
        }
        internal void Menu()
        {
            Console.Clear();
            Console.WriteLine("Escolha qual monstro você deseja lutar");
            Console.WriteLine("1 - ORC ");
            Console.WriteLine("2 - TROLL");
            Console.WriteLine("3 - GLOBIN");

            switch(Console.ReadLine().ToLower())
            {
                case "1":
                case "orc":
                    Console.WriteLine("Esta lutando com ORC");
                    break;
                case "2":
                case "troll":
                    Console.WriteLine("Esta lutando com Troll");
                    break;
                case "3":
                case "globin":
                    Console.WriteLine("Esta lutando com GLOBIN");
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opção inválida");
                    break;

            }
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();

        }
    }
}
