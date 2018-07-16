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
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    var origem = Tela.lerPosicaoXadrex().toPosicao();

                    Console.Write("Destino: ");
                    var destino = Tela.lerPosicaoXadrex().toPosicao();

                    partida.executaMovimento(origem, destino);
                }
                

            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            

            Console.ReadKey();
        }
    }
}
