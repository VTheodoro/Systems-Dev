using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_veículos
{
    class Carro : Veiculo
    {
        private string portas;

        public void setPortas(string portas)
        {
            this.portas = portas;
        }

        public string getPortas()
        {
            return this.portas;
        }

        public override string getInfoAdicional()
        {
            return getPortas();
        }
    }

}
