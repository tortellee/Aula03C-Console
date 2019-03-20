using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Construa um algoritmo que : 
Leia a cotação do dólar
Leia um valor em dólares
Converta esse valor para Real
Mostre o resultado*/

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            double dolar, convertido;
            double real = 3.66;

            //pergunta para o usuario
            Console.WriteLine("Quantos dólares deseja converter em reais?");
            dolar = Convert.ToDouble(Console.ReadLine());

            //formula para converter reais em dolar
            convertido = (dolar * real);

            //informa o valor convertido para o usuario
            Console.WriteLine("Valor convertido em reais foi: R$" + convertido);
            
            //precionar para fechar o programa
            Console.ReadKey();
        }
    }
}
