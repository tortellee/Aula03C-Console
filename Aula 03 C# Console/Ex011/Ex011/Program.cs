using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desenvolva um Algoritmo que lê 3 números e escreve o maior. 
namespace Ex011
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            double n1, n2, n3, maior;

            //Pede para o usuario a primeiro numero
            Console.WriteLine("Informe o primeiro numero");
            n1 = Convert.ToDouble(Console.ReadLine());

            //Pede para o usuario a segundo numero
            Console.WriteLine("Informe o segundo numero");
            n2 = Convert.ToDouble(Console.ReadLine());

            //Pede para o usuario a terceiro numero
            Console.WriteLine("Informe o terceiro numero");
            n3 = Convert.ToDouble(Console.ReadLine());

            //Condição para saber qual é o maior
            if (n1 > n2 && n1 > n3)
                maior = n1;
            {
                
            }
            else
            {
                Console.WriteLine(aluno + " teve a média de " + media + " você foi REPROVADO !!! ");
            }

            //precionar a tecla para sair
            Console.ReadKey();

        }
    }
}
