using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Declaração de Bibliotecas

    //Declaração da Classe - "Program"
    //Classe Program responsavel pela execuçã do Algoritimo
namespace exemplo_revisao
{
    class Program
    {
        //Composição de uma classe: Nome, Atributos e Metodos

            //Static void main é um método

            //Um metodo possui argumentos
        static void Main(string[] args)
        {
            double n1, n2, soma;
            Console.WriteLine("Digite o primeiro numero:");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero:");
            n2 = double.Parse(Console.ReadLine());

            soma = n1 + n2;

            Console.WriteLine("O resultado da soma é: " + soma);
            Console.ReadKey(); //pressone algum botão para continuar. Seria um especie de pausa

        }
    }
}
