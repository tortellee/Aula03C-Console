using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Elaborar um programa que leia dois valores numéricos reais desconhecidos representados pelas variáveis A e B. Calcular e apresentar os resultados das quatro operações aritméticas básicas.
namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            long a, b, mais,menos,vezes,dividir;

            //Pede para o usuario informar o primeiro numero
            Console.WriteLine("Informe o primeiro numero");
            a = Convert.ToInt64(Console.ReadLine());

            //Pede para o usuario informar o segundo numero
            Console.WriteLine("Informe o segundo numero");
            b = Convert.ToInt64(Console.ReadLine());

            //operações aritméticas
            mais = (a + b);
            menos = (a - b);
            vezes = (a * b);
            dividir = (a / b);

            //mostrar resultado final
            Console.WriteLine(+mais + " Adição");
            Console.WriteLine(+menos + " Subtração");
            Console.WriteLine(+vezes + " Multiplicação");
            Console.WriteLine(+dividir + " Divisão");

            //precionar a tecla para sair
            Console.ReadKey();







        }
    }
}
