using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Construa um algoritmo para pagamento de comissão de vendedores de peças automotivas, levando em consideração que a comissão do vendedor será de 5% do total da venda. 
O usuário deve inserir os seguintes dados abaixo, e ao final o sistema deve mostrar o valor total da compra e o valor da comissão do vendedor: 
Identificação do vendedor 
Código da peça 
Preço unitário da peça 
Quantidade vendida*/

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            double preco, valortotal,comissaovendedor, comissao = 0.05;
            int id,codigo, quantidade;

            //pergunta ao usuario o ID do vendedor
            Console.WriteLine("informe o ID do vendedor");
            id = Convert.ToInt32(Console.ReadLine());

            //pergunta ao usuario o codigo da peça
            Console.WriteLine("Inform o Código da peça");
            codigo = Convert.ToInt32(Console.ReadLine());

            //pergunta ao usuario o preço da peça
            Console.WriteLine("Informe o preço da peça");
            preco = Convert.ToDouble(Console.ReadLine());

            //pergunta ao usuario o quantidade da peça a ser vendida
            Console.WriteLine("Informe a quantidade de peca a ser vendida");
            quantidade = Convert.ToInt32(Console.ReadLine());

            //formula de calculo valor total da compra
            valortotal = (preco * quantidade);

            //formulado para saber a comissao do vendedor
            comissaovendedor = (valortotal*comissao);


            //mostrar na tela o valor total e a comissao do vendedor
            Console.WriteLine("Valor total da compra foi: R$" + valortotal);
            Console.WriteLine("comissão do vendedor foi: R$" + comissaovendedor);

            //precionar para sair do programa
            Console.ReadKey();
        }
    }
}
