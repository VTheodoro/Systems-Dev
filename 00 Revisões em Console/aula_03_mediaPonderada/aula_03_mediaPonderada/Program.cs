using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_03_mediaPonderada
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3,media;


            Console.WriteLine("Digite a primeira nota do aluno:");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota do aluno:");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota do aluno:");
            nota3 = double.Parse(Console.ReadLine());

            media = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5)) / 10;

            Console.WriteLine("A Média Ponderada do aluno é: "+media);
            Console.ReadKey();



        }
    }
}
