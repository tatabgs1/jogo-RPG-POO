using System;
using jogo_RPG_POO.src.Entities;

namespace jogo_RPG_POO
{
    class Program
    {
        static void Main(string[] args)
        {    
            // Desafio: vc vai criar as outras classes: do ninja e do black wizard 
            // e vai representar o HP e o MP com tudo
            Knight arus = new Knight("Arus", 23, "Knight", 749, 72);
            Wizard jenica = new Wizard("Jenica", 30, "White Wizard", 601, 482);
            BlackWizard topapa = new BlackWizard("Topapa", 33, "Black Wizard", 385, 641);
            Ninja wedge = new Ninja("Wedge", 28, "Ninja", 574, 89);
            

            //Console.WriteLine(arus.Attack());
            Console.WriteLine($"Personagem: {jenica}");
            Console.WriteLine(jenica.Attack(1));
            Console.WriteLine(jenica.Attack(7));
            Console.WriteLine(); 

            Console.WriteLine($"Personagem: {wedge}");
            Console.WriteLine(wedge.Attack(3));
            Console.WriteLine(wedge.Attack(6));
            Console.WriteLine(); 

            Console.WriteLine($"Personagem: {topapa}");
            Console.WriteLine(topapa.Attack(4));
            Console.WriteLine(topapa.Attack(5));
            Console.WriteLine(); 

            Console.WriteLine($"Personagem: {arus}");
            Console.WriteLine(arus.Attack(4));
            Console.WriteLine(arus.Attack(5));
            Console.WriteLine(); 

        }
    }
}