using GameTOP.Interface;

namespace GameTop
{
    public class jogoFODA
    {
        private readonly iJogador _jogadorA;

        private readonly iJogador _jogadorB;

        public jogoFODA(iJogador jogadorA, iJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }
        public void iniciarJogo()
        {
           System.Console.WriteLine(_jogadorA.Corre());
           System.Console.WriteLine(_jogadorA.Chuta());
           System.Console.WriteLine(_jogadorA.Passe());
           //
            System.Console.Write("\n proximo jogador \n");
           //
           System.Console.WriteLine(_jogadorB.Corre());
           System.Console.WriteLine(_jogadorB.Chuta());
           System.Console.WriteLine(_jogadorB.Passe());
        }
    }
}