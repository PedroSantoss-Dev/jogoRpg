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
                    Lutar(new Monstro("Orc", heroi.Nivel * 8, heroi.Nivel));
                    break;
                case "2":
                case "troll":
                    Lutar(new Monstro("Troll", heroi.Nivel * 10, heroi.Nivel * 12));
                    break;
                case "3":
                case "globin":
                    Lutar(new Monstro("Globin", heroi.Nivel * 15, heroi.Nivel * 8));
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
        void Lutar(Monstro monstro)
        {
            Console.Clear();
            MostrarInfo();
            Console.WriteLine(
                "Oponente encontrado:" +
                " \n Nome: {0}" +
                " \n Ataque: {1} " +
                "\n Vida: {2} " +
                "\n Xp: {3}",
                monstro.Nome, monstro.Ataque, monstro.vida, monstro.Xp);
            Console.WriteLine("[ 1 ] - Atacar\n [ 2 ] - Fugir\n[ 3 ] - Trocar Monstro ");
            switch(Console .ReadLine().ToLower())
            {
                case "1":
                case "atacar":
                    monstro.vida -= heroi.Ataque;
                    if (monstro.vida <= 0)
                    {
                        heroi.GanharXp(monstro.Ataque);
                        Console.WriteLine("Seu golpe atingiu em cheio o seu oponente {0} \n Parabéns você derrotou {1}", monstro.Nome, monstro.Nome);

                    }
                    else
                    {
                        heroi.Vida -= monstro.Ataque;
                        if (heroi.Vida <= 0)
                        {
                            Console.WriteLine(
                                "Seu golpe não foi bom e seu oponente revidou \n " +
                                "Poder do Golpe recebido foi : {0} \n" +
                                "Você não resistiu ao golpe"
                                );
                            FimDeJogo();
                        }
                        else 
                        { 
                            Console.WriteLine("Seu golpe não foi bom e seu oponente revidou mas não foi o suficiente para te matar"); 
                        }
                    }
                    break;
                case "2":
                case "fugir":
                    if (heroi.Vida <= 0)
                    {
                        Console.WriteLine("Você não conseguiu fugir");
                        FimDeJogo();

                    }
                    heroi.Vida -= 2;
                    monstro.Ataque += 10;
                    Console.WriteLine("\nVocê é um covarde e fugiu da batalha!");

                    break;
                case "3":
                case "menu":
                    Menu();
                    return;
            }
            Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Lutar(monstro);
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


        void FimDeJogo()
        {
            Console.Clear(); 
             Console.WriteLine("Fim de jogo você foi derrotado");
            Console.ReadKey();
             Iniciar();
           
        }
    }
}
