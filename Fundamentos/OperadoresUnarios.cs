﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresUnarios {
        public static void Executar() {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo);
            Console.WriteLine(!booleano);

            numero1++;
            Console.WriteLine(numero1);

            numero1--;
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2); // trás multa confusão, misturou muita coisa em um comando
            Console.WriteLine($"{numero1} | {numero2}");
        }

        /*
         * Focar em código limpo e correto trazendo a funcionalidade
         */
    }
}
