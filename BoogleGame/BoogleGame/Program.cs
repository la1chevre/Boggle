﻿namespace BoogleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Dictionnaire dico = new Dictionnaire("fr");
            for (int i = 0; i < dico.dictionnaire.Length; i++)
            {
                Console.WriteLine(dico.dictionnaire[i]);

            }
            Plateau plato = new Plateau(4);
            Console.WriteLine(plato.toString());
            string mot = Console.ReadLine();
            Console.WriteLine(mot);
            Console.WriteLine(plato.Test_Plateau(mot, dico));
            Console.WriteLine("azr");
        }
    }
}