using System;

class Program
{
    static void Main()
    {
        int tamanho = 100;
        int[] vetor = new int[tamanho];

        Random random = new Random();

        // Preenchendo o vetor com valores aleatórios e exibindo
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = random.Next(1000);
            Console.Write(vetor[i] + " ");
        }
        Console.WriteLine();

        // Ordenando o vetor usando Array.Sort em uma linha
        Array.Sort(vetor); //Array.Sort(vetor, (a, b) => b.CompareTo(a)); - ordem decrescente 

        // Exibindo o vetor ordenado
        Console.WriteLine();
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " ");
        }
        Console.WriteLine();
    }
}
