using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Algoritmo para ler um número pelo teclado e verificar se ele é negativo ou positivo. 
namespace Ex012  
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            long n1;

            //pedir o numero para o usuario
            Console.WriteLine("Informe um numero inteiro");
            n1 = Convert.ToInt64(Console.ReadLine());

            //Condição para saber se eh negativo ou positivo

            if (n1 < 0)
            {
                //Informa ao usuario a resposta
                Console.WriteLine("Numero " + n1 + " é negativo");
            }
            else if (n1 > 0)
            {
                //Informa ao usuario a resposta
                Console.WriteLine("Numero " + n1 + " é positivo");
            }
            else
            {
                //Informa ao usuario a resposta
                Console.WriteLine("Numero " + n1 + " é ZERO");
            }
            //precionar para sair do programa
            Console.ReadKey();
        }

    }
}
