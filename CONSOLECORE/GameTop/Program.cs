using System;
using GameTOP.lib;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
           var jogo = new jogoFODA(
               new Jogador1(),
               new joagador3()
               );
           jogo.iniciarJogo();
        }
    }

    
}
