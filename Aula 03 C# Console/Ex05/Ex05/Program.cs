using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Efetuar a leitura de um valor numérico inteiro e apresentar o resultado do valor lido elevado ao quadrado.

namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            //variavel
            int nd,total;

            //pergunta ao usuario um numero inteiro
            Console.WriteLine("Informe um numero inteiro:");
            nd = Convert.ToInt32(Console.ReadLine());

            //calculo para somar o quadrado
            total = nd * nd;

            //mostra resultado na tela
            Console.WriteLine("O Quadrado de " + nd + " é: " + total);

            //precionar para sair do programa
            Console.ReadKey();
       
        }
    }
}
