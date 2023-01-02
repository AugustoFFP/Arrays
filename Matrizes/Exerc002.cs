/* Ex064 - Faça um programa que preencha uma matriz 4x4 com números sorteados pelo computador. No final, mostre a matriz na tela
 * e mostre também o somatorio dos valores de cada linha.
 */
using System;

class program
{
    static void Main(string[] args)
    {
        int[,] matriz = new int[4, 3];
        Random sorte = new Random();

        int colun = 0;
        int soma = 0;

        for (int linha = 0; linha < matriz.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
            {
                matriz[linha, coluna] = sorte.Next(0, 10);
                Console.Write($"{matriz[linha, coluna]} \t ");
            }
             

            for (int linh = 0; linh < matriz.GetLength(1); linh++)
            {
                soma += matriz[colun, linh]; 
                
            }
            Console.Write($" = {soma}  \n");
            soma = 0;
            colun++;

        }

        Console.WriteLine(matriz.GetLength(1) + "coluna"); // numero de coluna
        Console.WriteLine(matriz.GetLength(0) + "linha"); // número de linha

        //Soma com Caracteres
        
        for (int linha = 0; linha < matriz.GetLength(0); linha++)
        {
            soma = 0;
            Console.WriteLine($"Somando a linha {linha}: ");
            for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
            {
                soma += matriz[linha, coluna];
                Console.Write(matriz[linha, coluna]);
                if(coluna != matriz.GetLength(1) - 1)
                {
                    Console.Write(" + ");
                } else
                {
                    Console.Write(" = ");
                }
            }
            Console.WriteLine(soma);
        }


    }
}
