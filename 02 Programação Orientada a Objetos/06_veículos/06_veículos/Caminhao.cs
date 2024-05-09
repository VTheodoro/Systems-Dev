using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_veículos
{
    class Caminhao : Veiculo
    {
        private string carga;

        public void setCarga(string carga)
        {
            this.carga = carga;
        }

        public string getCarga()
        {
            return this.carga;
        }

        public override string getInfoAdicional()
        {
            return getCarga();
        }
    }

}
