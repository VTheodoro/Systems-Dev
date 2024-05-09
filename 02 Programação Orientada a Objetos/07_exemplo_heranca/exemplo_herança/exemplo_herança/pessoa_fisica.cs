using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_herança
{
    class pessoa_fisica : pessoa
    {
        private string rg;
        public void setRg(string rg)
        {
            this.rg = rg;
        }
        public string getRg()
        {
            return this.rg;
        }
    }
}
