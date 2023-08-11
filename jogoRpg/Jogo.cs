using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoRpg
{
    public class Jogo
    {
        Heroi heroi;
        public void Iniciar()
        {
            Console.WriteLine("Digite seu nome:");
             heroi = new Heroi(Console.ReadLine());
            Menu();
        }
        internal void Menu()
        {
            Console.Clear();
            MostrarInfo();
            Console.WriteLine("Escolha qual monstro você deseja lutar");
            Console.WriteLine("1 - ORC ");
            Console.WriteLine("2 - TROLL");
            Console.WriteLine("3 - GLOBIN");
            Console.WriteLine("");
            Console.WriteLine("Digite 0 para sair do jogo");

            switch (Console.ReadLine().ToLower())
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
            if (heroi.Vida <= 0)
            {
                Console.WriteLine("Você faleceu...");
                return;
            }
            else
            {
                Menu();
            }

        }
            
       void MostrarInfo()
       {
            Console.WriteLine($"Olá {heroi.Nome}");
            Console.WriteLine($"Sua vida é: {heroi.Vida}");
            Console.WriteLine($"Seu nível é: {heroi.Nivel}");
            Console.WriteLine($"Seu ataque é: {heroi.Ataque}");
            Console.WriteLine($"Sua experiência é: {heroi.Xp}");
            Console.WriteLine($"Seu ataque base é: {heroi.AtaqueBase}");
            Console.WriteLine("");
        }
    }
}
