using System;
using tabuleiro;

namespace ProjetoXadrezConsole
{
    public class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            Console.WriteLine();
            for(int i = 0; i < tabuleiro.Linhas; i++)
            {
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    if (tabuleiro.Peca(i, j) == null) Console.Write("   -  ");

                    else Console.Write($"   {tabuleiro.Peca(i, j)}  ");
                }
                Console.WriteLine();
            }
        }
    }
}
