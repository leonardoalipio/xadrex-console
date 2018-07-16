using System;
using tabuleiro;

namespace xadrex_console
{
    class Program
    {
        static void Main(string[] args)
        {

            var P = new Posicao(3, 4);

            Console.WriteLine("Posicao: " + P);

            Console.ReadKey();
        }
    }
}
