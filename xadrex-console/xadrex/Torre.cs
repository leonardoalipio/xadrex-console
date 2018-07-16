using System;
using tabuleiro;
using System.Collections.Generic;
using System.Text;

namespace xadrex
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
