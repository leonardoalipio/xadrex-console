﻿using System;
using tabuleiro;

namespace xadrex_console
{
    class Program
    {
        static void Main(string[] args)
        {
            var tab = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);


            Console.ReadKey();
        }
    }
}
