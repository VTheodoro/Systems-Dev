using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_exemplo_polimorfismo
{
    class assalariado:empregado
    {
        private double salario;

        public void setSalario(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return this.salario;
        }

        public override Double vencimento(double valor)
        {
            valor = 1000;
            return valor;
        }

    }
}
