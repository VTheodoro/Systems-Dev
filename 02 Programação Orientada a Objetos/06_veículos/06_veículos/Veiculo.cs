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
            private string ano;

            public void setModelo(string modelo)
            {
                this.modelo = modelo;
            }

            public string getModelo()
            {
                return this.modelo;
            }

            public void setCor(string cor)
            {
                this.cor = cor;
            }

            public string getCor()
            {
                return this.cor;
            }

            public void setAno(string ano)
            {
                this.ano = ano;
            }

            public string getAno()
            {
                return this.ano;
            }

            public virtual string getInfoAdicional()
            {
                return "";
            }
        }
    }

