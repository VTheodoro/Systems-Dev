using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_game
{
    public class Inimigo
    {
        public int Life { get; set; } = 100;

        public void ReceberAtaque()
        {
            Life--;
        }
    }

    public class Jogador
    {
        public void AtacarInimigo(Inimigo inimigo)
        {
            inimigo.ReceberAtaque();
        }
    }

}
