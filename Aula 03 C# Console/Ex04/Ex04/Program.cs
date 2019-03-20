using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desenvolva um Algoritmo que lê o nome e as 4 notas bimestrais de um aluno. Em seguida o Algoritmo calcula e escreve a média obtida.
namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            double n1, n2, n3, n4, media;
            string nome;

            //pede ao usuario informar o nome
            Console.WriteLine("Informe o nome do aluno");
            nome = Console.ReadLine();

            //pede ao usuario informar as notas 4
            Console.WriteLine("informe a primeira nota do(a) aluno(a) " + nome);
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe a segunda nota do(a) aluno(a) " + nome);
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe a terceira nota do(a) aluno(a) " + nome);
            n3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe a quarta nota do(a) aluno(a) " + nome);
            n4 = Convert.ToDouble(Console.ReadLine());

            //formula de calculo da media
            media = (n1+n2+n3+n4) / 4;

            //mostra na tela o nome e a media do aluno
            Console.WriteLine("A média do(a) aluno(a) " + nome + " foi: " + media);

            //precionar para sair do programa
            Console.ReadKey();
                                 
        }
    }
}
