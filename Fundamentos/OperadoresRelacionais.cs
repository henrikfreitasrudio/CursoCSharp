using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresRelacionais {
        public static void Executar() {
            Console.Write("Informe sua nota: ");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDeCorte = 7.0;

            Console.WriteLine($"Nota inválida? {nota > 10}");
            Console.WriteLine($"Nota inválida? {nota < 0}");
            Console.WriteLine($"Perfeito? {nota == 10}");
            Console.WriteLine($"Tem como melhorar? {nota != 10}");
            Console.WriteLine($"Passou por média? {nota >= notaDeCorte}");
            Console.WriteLine($"Recuperação? {nota < notaDeCorte}");
            Console.WriteLine($"Reprovado? {nota < notaDeCorte}");
        }
    }
}
