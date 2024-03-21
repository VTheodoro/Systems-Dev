using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_01_lerIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade,meses,dias;

            Console.WriteLine("Digite sua idade : ");
            idade = int.Parse(Console.ReadLine());

            dias = idade * 365;
            meses = idade * 12;

            Console.WriteLine("\n------------------------------------------------\nSua idade em \nAnos: "+idade+"\nMeses: "+meses+"\nDias: "+dias);

            Console.ReadKey();
        }
    }
}
