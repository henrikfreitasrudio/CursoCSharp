using System;

namespace CursoCSharp.ClassesEMetodos {
    internal class Membros {
        public static void Executar() {
            Pessoa siclano = new Pessoa();
            siclano.Nome = "Pedro";
            siclano.Idade = 22;

            //Console.WriteLine($"{siclano.Nome} tem {siclano.Idade} anos.");

            siclano.ApresentarNoConsole();
            siclano.Zerar();
            siclano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Henrik";
            fulano.Idade = 23;

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano.Length);
            Console.WriteLine(apresentacaoDoFulano);
        }
    }
}
