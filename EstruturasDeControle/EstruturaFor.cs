using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaFor {
        public static void Executar()
        {
            //for (int i = 0; i <= 10; i++) {
            //    Console.WriteLine($"O valor de i é {i}");
            //}

            double somatorio = 0;

            Console.Write("Informe o tamanho da turma: ");
            int.TryParse(Console.ReadLine(), out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++) {
                Console.Write($"Informe a nota do aluno {i}: ");
                double.TryParse(Console.ReadLine(), out double notaAtual);

                somatorio += notaAtual;
            }

            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0; // operador ternário
            Console.WriteLine($"Média da turma: {media}");
        }
    }
}
