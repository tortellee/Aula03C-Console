using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Elaborar um programa que calcule e apresente o valor do volume de uma caixa retangular, utilizando a fórmula VOLUME = COMPRIMENTO * LARGURA * ALTURA
namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            double vol, cump, larg, alt;

            //Pede para o usuario informar o volume
            Console.WriteLine("Informe o comprimento");
            cump = Convert.ToDouble(Console.ReadLine());

            //Pede para o usuario informar a largura
            Console.WriteLine("Informe a largura");
            larg = Convert.ToDouble(Console.ReadLine());

            //Pede para o usuario informar a altura
            Console.WriteLine("Informe a altura");
            alt = Convert.ToDouble(Console.ReadLine());

            //formula
            vol = (cump * larg * alt);

            //informar na tela o volume
            Console.WriteLine("O Volume é " + vol+ "Cm³");

            //precionar a tecla para sair
            Console.ReadKey();

        }
    }
}