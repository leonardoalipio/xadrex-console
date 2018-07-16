using System;
using tabuleiro;
using System.Collections.Generic;
using System.Text;

namespace xadrex
{
    class PartidaDeXadrex
    {
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }

        public PartidaDeXadrex()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            var p = tab.retirarPeca(origem);
            p.incrementarQteMovimentos();
            var pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }

        public void colocarPecas()
        {
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrex('c', 1).toPosicao());

        }
    }
}
