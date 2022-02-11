using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    public class CalculadoraEstatica {
        public static int Somar(int a, int b)
        {
            return a + b;
        }

        // Método de classe ou Método estático
        public static int Multiplicar(int a, int b) 
        {
            return a * b;
        }

        //  Método de instância
        public int Dividir(int a, int b) 
        {
            return a / b;
        }
    }

    internal class MetodosEstaticos {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine($"Resultado {resultado}");

            Console.WriteLine(CalculadoraEstatica.Somar(2, 2));

            CalculadoraEstatica Div = new CalculadoraEstatica();
            Console.WriteLine(Div);
        }
    }
}
