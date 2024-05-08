using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_veículos
{
    class Caminhao
    {

        private int carga;

        //capacidade de carga do caminhão
        public void setCarga(int carga)
        {
            this.carga = carga;
        }

        public int getCarga()
        {
            return this.carga;
        }

    }
}
