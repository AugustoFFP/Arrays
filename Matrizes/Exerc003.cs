/* Ex065 - Faça um programa que preencha uma matriz 4x4 com números sorteados pelo computador. No final, mostre a matriz na tela
 * e mostre também o somatorio dos valores de cada coluna.
 */
using System;

class program
{
    static void Main(string[] args)
    {
        int[,] matriz = new int[3, 4];
        Random sorte = new Random();

        for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
        {
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                matriz[linha, coluna] = sorte.Next(0, 10);
                Console.Write($"{matriz[linha, coluna]} \t");
                Thread.Sleep(400);
            }
            Console.WriteLine();
        }

        //Somar coluna
        int somar = 0;
        Console.WriteLine();
        Console.WriteLine("===========================");

        for (int coluna = 0; coluna < matriz.GetLength(0); coluna++)
        {
            somar = 0;
            for (int linha = 0; linha < matriz.GetLength(1); linha++)
            {
                somar += matriz[coluna, linha];
                Console.Write($"{matriz[coluna, linha]} ");

                if(linha != matriz.GetLength(1) - 1)
                {
                    Console.Write(" +  ");
                } else
                {
                    Console.Write(" =  ");
                }
            }
           
            Console.WriteLine($"{somar} \t");
        }
    }
}
