using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_pessoal_printh3d
{
    class Calculos_Matematicos
    {
        private double valorKG;
        private double peso;
        private double kwh;
        private double consumo;
        private double tempo;
        private double depreHora;

        public double cMaterial()
        {
            double custMaterial = (valorKG / 1000) * peso;
            return custMaterial;
        }


        public double cEnergia()
        {
            return ((kwh / 1000) * consumo) * (tempo / 60);
        }

    

        public double cManutencao()
        {
            return (tempo * depreHora);
        }


        public double cFalhas()
        {
            return ();
        }



    }
}
