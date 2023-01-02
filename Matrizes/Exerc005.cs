/*Ex067 - Faça um programa que preencha uma matriz 5x5 com números sorteados.
 * Depois mostre a matriz na tela e por fim calcule.
 * - A média entre todos os valores sorteados.
 * - Quais são os valores que estão acima da média na 2ª linha
 * - Quais são os valores que estão acima da média na 3ª coluna
 * 
 */
using System;

class program
{
    static void Main(string[] args)
    {
        int[,] matriz = new int[5, 5];
        Random sorte = new Random();
        int soma = 0;

        for (int linhas = 0; linhas < matriz.GetLength(0); linhas++)
        {
            for (int colunas = 0; colunas < matriz.GetLength(1); colunas++)
            {
                matriz[linhas, colunas] = sorte.Next(0, 10);
                Console.Write(matriz[linhas, colunas] + "\t");
                soma += matriz[linhas, colunas];
            }
            Console.WriteLine();
        }
        Console.WriteLine("-------------------------------------");
        Console.WriteLine($"A soma é {soma}");
        Console.WriteLine($"Dividido por {matriz.Length}");
        int media = soma / matriz.Length;
        Console.WriteLine($"A média dos valores é: {media}");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Na segunda linha, os valores acima da media são: ");
        for (int colunas = 0; colunas < matriz.GetLength(1); colunas++)
        {
            if (media < matriz[1, colunas])
            {
                Console.Write($"{matriz[1, colunas]} - ");
            }
        }
        Console.WriteLine("FIM!");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Na terceira coluna, os valores abaixo da média são: ");
        for (int linhas = 0; linhas < matriz.GetLength(0); linhas++)
        {
            if (media > matriz[linhas, 2])
            {
                Console.Write($"{matriz[linhas, 2]} - ");
            }
        }
        Console.WriteLine("FIM!");
        Console.WriteLine("-------------------------------------");

    }
}
