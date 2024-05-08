using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_veículos
{
    class Carro:Veiculo
    {

        private int portas;

        //número de portas do carro
        public void setPortas(int portas)
        {
            this.portas = portas;
        }

        public int getPortas()
        {
            return this.portas;
        }

    }

}
