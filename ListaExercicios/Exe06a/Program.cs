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

        // Ordenando o vetor usando Bubble Sort
        for (int i = 0; i < vetor.Length - 1; i++)
        {
            for (int j = 0; j < vetor.Length - 1 - i; j++)
            {
                if (vetor[j] > vetor[j + 1])
                {
                    // Troca os elementos
                    int aux = vetor[j];
                    vetor[j] = vetor[j + 1];
                    vetor[j + 1] = aux;
                }
            }
        }
    Console.Write("\n");
        // Exibindo o vetor ordenado
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " ");
        }
        Console.WriteLine();
    }
}



//bool troca;
//do{
    //	troca = false;
//for (int i = 0; i < vetor.Length - 1; i++)
      //  {
        //    for (int j = 0; j < vetor.Length - 1 - i; j++)
        //    {
          //      if (vetor[j] > vetor[j + 1])
         //       {
		//    troca = true;
       //             int aux = vetor[j];
       //             vetor[j] = vetor[j + 1];
      //              vetor[j + 1] = aux;
       //         }
   //         }
//} while(troca == true);