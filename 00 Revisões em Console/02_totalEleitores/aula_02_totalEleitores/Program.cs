using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_02_totalEleitores
{
    class Program
    {
        static void Main(string[] args)
        {
            double tEleitores, vBrancos, vNulos, validos;
            double nulos, brancos, pValidos;

            Console.WriteLine("Digite o Numero Total de Eleitores do Municipio: ");
            tEleitores = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero de votos brancos: ");
            vBrancos = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o numero de votos nulos: ");
                vNulos = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o numero de votos validos: ");
                validos = int.Parse(Console.ReadLine());


            nulos = (vNulos / tEleitores) * 100;
            brancos = (vBrancos / tEleitores) * 100;
            pValidos = (validos / tEleitores) * 100;


            if (nulos + brancos + pValidos > 100)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Numeros Invalidos, tente novamente.");
            }
            else
            {
                Console.WriteLine("\nResultados:\nVotos Validos: " + pValidos + "%\nVotos Nulos: " + nulos + "%\nVotos em Branco: " + brancos + "%");
            }
            Console.ReadKey();

        }
    }
}
