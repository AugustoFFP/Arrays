/*Ex068 - Faça um programa que crie um jogo de campo minado em uma matriz 5x5.
 */
using System;

class program
{
    static void Main(string[] args)
    {
        char[,] matriz = new char[5, 5];

        for (int linh = 0; linh < matriz.GetLength(0); linh++)
        {
            for (int colun = 0; colun < matriz.GetLength(1); colun++)
            {
                matriz[linh, colun] = '-'; 
            }
        }

        //Sorteando as bombas
        int quantidade = 3;
        int posicaoLinha, PosicaoColuna;
        int jogada = 0;
        int bomba = 0;
        Random sorte = new Random();

        while (bomba < quantidade)
        {
            posicaoLinha = sorte.Next(0, matriz.GetLength(0) - 1);
            PosicaoColuna = sorte.Next(0, matriz.GetLength(1) - 1);
            if (matriz[posicaoLinha, PosicaoColuna] == '-')
            {
                matriz[posicaoLinha, PosicaoColuna] = 'O';
                bomba++;
            }
        }

        //Iniciar o jogo
        int total = 3, tentativas = 1, pontos = 0, linha, coluna;
        bool bum = false;
        while (tentativas < total || pontos < total * 2)
        {
            //Mostrar o tabuleiro com ???
            for (int linh = 0; linh < matriz.GetLength(0); linh++)
            {
                for (int colun = 0; colun < matriz.GetLength(1); colun++)
                {
                    if(matriz[linh, colun] == '-' || matriz[linh, colun] == 'O')
                    {
                        Console.Write(" ? \t");
                    } else
                    {
                        Console.Write($" {matriz[linh, colun]} \t");
                    }
                }
                Console.Write("\n");
            }

            //Jogador faz a jogada
            Console.Write("----------------------------------\n");


            Console.WriteLine($"Faça sua jogada! {tentativas}" );
            do
            {
                Console.Write("LINHA = ");
                linha = int.Parse(Console.ReadLine());
            } while (linha >= matriz.GetLength(0));

            do
            {
                Console.Write("COLUNA = ");
                coluna = int.Parse(Console.ReadLine());
            } while (coluna >= matriz.GetLength(1));

            //Verificar a jogada
            if (matriz[linha, coluna] == 'O')
            {
                Console.Write("--> TIRO ERRADO! Você acertou uma Bomba!\n");
                bum = true;
                matriz[linha, coluna] = '*';
                break;
            } else if (matriz[linha, coluna] == '-')
            {
                Console.Write("--TIRO CERTO! Parabéns!\n");
                
                matriz[linha, coluna] = 'V';
                tentativas++;
                pontos += 2;
            }
            else if (matriz[linha, coluna] == 'V')
            {
                Console.Write("--> Você já atirou nessa posição! Tente novamente!\n");
            }
            Thread.Sleep(500);
        }
        //FIM DO JOGO
        Console.WriteLine("==================================");
        Console.WriteLine("GAME OVER!");
        Console.WriteLine("==================================");
        //Mostrar tabuleiro completo
        for (int linh = 0; linh < matriz.GetLength(0); linh++)
        {
            for (int colun = 0; colun < matriz.GetLength(1); colun++)
            {
                Console.Write($" {matriz[linh, colun]} \t");
            }
            Console.WriteLine();
        }

        Console.Write("----------------------------------\n");
        if (bum)
        {
            Console.Write("Você não ganhou! :( ");
        }else
        {
            Console.Write("VITÓRIA! Você ganhou! :D");
        }
        Thread.Sleep(500);
        Console.WriteLine();
        Console.WriteLine($"Você fez {pontos} pontos em {tentativas - 1} tentativas.");

    }
}
