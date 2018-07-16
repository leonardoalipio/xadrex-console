using System;
using tabuleiro;
using xadrex;

namespace xadrex_console
{
    class Program
    {
        static void Main(string[] args)
        {

            var pos = new PosicaoXadrex('a', 1);
            var pos1 = new PosicaoXadrex('c', 7);

            Console.WriteLine(pos1);

            Console.WriteLine(pos1.toPosicao());

            Console.ReadKey();
        }
    }
}
