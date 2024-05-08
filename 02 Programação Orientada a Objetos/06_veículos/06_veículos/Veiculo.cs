using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_veículos
{
    class Veiculo //superclasse
    {

        private string modelo;
        private string cor;
        private int ano;

        //modelo do veiculo
        public void setModelo(string modelo)
        {
            this.modelo = modelo;
        }

        public string getModelo()
        {
            return this.modelo;
        }

        //cor do veiculo
        public void setCor(string cor)
        {
            this.cor = cor;
        }

        public string getCor()
        {
            return this.cor;
        }

        //ano de fabricação
        public void setAno(int ano)
        {
            this.ano = ano;
        }

        public int getAno()
        {
            return this.ano;
        }

    }
}
