using System;
using tabuleiro;
using xadrex;

namespace xadrex_console
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                var partida = new PartidaDeXadrex();

                while (!partida.terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab);
                        Console.WriteLine();

                        Console.WriteLine("Turno: " + partida.turno);
                        Console.WriteLine("Aguardando jogada: " + partida.jogadorAtual);

                        Console.Write("Origem: ");
                        var origem = Tela.lerPosicaoXadrex().toPosicao();
                        partida.validarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.Peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                        Console.Write("Destino: ");
                        var destino = Tela.lerPosicaoXadrex().toPosicao();
                        partida.validarPosicaoDeDestino(origem, destino);

                        partida.realizaJogada(origem, destino);

                    }catch(TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadKey();
                    }
                }
            }
            catch(TabuleiroException e){Console.WriteLine(e.Message);}            

            Console.ReadKey();
        }
    }
}
