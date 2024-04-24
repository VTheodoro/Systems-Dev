using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_exemplo_polimorfismo
{
    class comissionado:empregado
    {
        public double totalVenda;
        private double taxaComissao;

        public void setTotalVenda(double totalVenda)
        {
            this.totalVenda = totalVenda;
        }

        public double getTotalVenda()
        {
            return this.totalVenda;
        }

        public void setTaxaComissao(double taxaComissao)
        {
            this.taxaComissao = taxaComissao;
        }

        public double getTaxaComissao()
        {
            return this.taxaComissao;
        }

        public override Double vencimento(double valor)
        {
            valor = 10;
            return valor;
        }



    }
}
