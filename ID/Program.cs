using System;
using Models.Tabuleiro;

namespace ID
{
    static class Program
    {
        static Program(){}
        static void Main(string[] args)
        {
            Tabuleiro inicial = new Tabuleiro(true);
            Console.WriteLine($"quantidade de pontos = {inicial.pontosFavor()}");
            Console.WriteLine();

            Tabuleiro inter = inicial.Movimentar(0,0);
            inter.Desenhar();

            inter = inicial.Movimentar(0,1);
            inter.Desenhar();

        }
    }
}