﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaDoWhile {
        public static void Executar()
        {
            string entrada;

            do {
                Console.WriteLine("Qual seu nome? ");
                entrada = Console.ReadLine();

                Console.WriteLine($"Seja Bem-Vindo {entrada}");
                Console.WriteLine("Deseja continuar? [S/N] ");
                entrada = Console.ReadLine();

            } while (entrada.ToLower() != "n");
        }
    }
}
