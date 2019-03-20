using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Desenvolva um algoritmo que: 
Leia 4 (quatro) números 
Calcule o quadrado para cada um 
Somem todos e 
Mostre o resultado*/
namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {

            //variaveis
            double lado1, lado2, lado3, lado4, valortotal;

            //pergunta os 4 valores
            Console.WriteLine("Informe o primeiro lado");
            lado1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o segundo lado");
            lado2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o terceiro lado");
            lado3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o quarto lado");
            lado4 = Convert.ToDouble(Console.ReadLine());

            //formula de calculo
            valortotal = (lado1+lado2+lado3+lado4);

            //mostra ao usuario valor dos 4 lados
            Console.WriteLine("O resultado da soma de quatro lados é: "+valortotal+"Cm");

            //precionar para sair
            Console.ReadKey();


        }
    }
}
