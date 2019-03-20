using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desenvolva um Algoritmo que lê o nome e as 4 notas bimestrais de um aluno. 
//Em seguida o Algoritmo calcula e escreve a média obtida pelo aluno escrevendo também se o aluno foi aprovado ou reprovado. Média para aprovação = 6. 
namespace Ex010
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            double n1, n2, n3, n4, media;
            string aluno;

            //Pede para o usuario o nome do aluno
            Console.WriteLine("Informe o nome do aluno(a)");
            aluno = (Console.ReadLine());

            //Pede para o usuario a primeira nota
            Console.WriteLine("Informe a primeira nota");
            n1 = Convert.ToDouble(Console.ReadLine());

            //Pede para o usuario a segunda nota
            Console.WriteLine("Informe a segunda nota");
            n2 = Convert.ToDouble(Console.ReadLine());

            //Pede para o usuario a terceira nota
            Console.WriteLine("Informe a terceira nota");
            n3 = Convert.ToDouble(Console.ReadLine());

            //Pede para o usuario a quarta nota
            Console.WriteLine("Informe a quarta nota");
            n4 = Convert.ToDouble(Console.ReadLine());

            //formula
            media = (n1 + n2 + n3 + n4) / 4;

            //informar na tela a media
            Console.WriteLine("A média de " + aluno + " é " + media);

            //Condição para saber se foi aprovado ou reprovado
            if (media>6)
            {
                Console.WriteLine(aluno+" teve a média de "+media+ " você foi APROVADO !!! ");
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