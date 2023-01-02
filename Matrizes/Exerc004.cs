/*Exerc066 - Faça um programa que preencha uma matriz 3x3 com números digitados pelo teclado. Depois analisa a matriz
 * inteira prourando o maior vlaor sorteado. Mostre esse valor e depois mostre em que posições ele aparece dentro da matriz.
 */
using System;

class program
{
    static void Main(string[] args)
    {
        int[,] matriz = new int[3, 3];

        for (int linha = 0; linha < matriz.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
            {
                Console.Write($"Digite o valor para a posição [{linha + "][" + coluna}]: ");
                matriz[linha, coluna] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Procurando pelo maior valor. . .");
        Thread.Sleep(300);
        int maior = 0;
        for (int linha = 0; linha < matriz.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
            {
                
                Console.Write($"{matriz[linha, coluna]}");
                Console.Write(" -> ");
                maior = matriz[linha, coluna];
            }
            Console.WriteLine("...");
            Console.WriteLine();
        }

        Console.WriteLine("ANALISADO!");
        Console.WriteLine("--------------------------------");
        Console.WriteLine($"O maior valor é {maior}");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Maior valor encontrado nas posições: ");
        
        for (int linha = 0; linha < matriz.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
            {
                if(maior == matriz[linha, coluna])
                {
                    Console.Write($"[{linha}][{coluna}] -> ");
                }
            }
        }
        Console.Write("FIM!");
    }
}
