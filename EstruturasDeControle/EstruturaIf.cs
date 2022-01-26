﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaIf {
        public static void Executar() {
            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno: ");
            Double.TryParse(Console.ReadLine(), out double nota);

            Console.WriteLine("Possui bom comportamento? (S/N): ");
            entrada = Console.ReadLine();

            //if(entrada == "S" || entrada == "s") 
            //    bomComportamento = true;

            //bomComportamento = entrada == "S" || entrada == "s"; // se for verdadeiro a variável recebe true
            bomComportamento = entrada.ToLower() == "s"; // melhor opção
            
            if(nota >= 9.0 && bomComportamento) {
                Console.WriteLine("Quadro de honra!");
            }
        }  
    }
}
