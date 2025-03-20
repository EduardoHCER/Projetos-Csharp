using System;

namespace Exe06a
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Conceitos para resolução

            1 - Definir um vetor de 1k posições
            2 - Preencher o vetor com valores aleatórios
            3 - Imprimir os valores do vetor
            4 - Ordenar o vetor com o bubble sort

            Info - dotnet run --project Exe06a
            */

            // Definir vetor
            int[] vetor = new int[5];
            Random r = new Random(); // Gerar um valor aleatório

            // Estrutura For para preencher vetor
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = r.Next(1, 10); // Preenchendo com valores aleatórios entre 1 e 9
            }

            // Imprimir valores do vetor
            Console.WriteLine("\n----VALORES DO VETOR----");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + " ");
            }

            // Organizar valores em ordem crescente
            Console.WriteLine("\n----ORDEM CRESCENTE----");

            for (int i = 0; i < vetor.Length - 1; i++)
            {
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[i] > vetor[j])
                    {
                        // Trocar os valores
                        int aux = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = aux;
                    }
                }
            }

            // Imprimir ordem crescente
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + " ");
            }

            // Organizar de forma decrescente
            Console.WriteLine("\n----ORDEM DECRESCENTE----");

            for (int i = 0; i < vetor.Length - 1; i++)
            {
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[i] < vetor[j])
                    {
                        // Trocar os valores
                        int aux = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = aux;
                    }
                }
            }

            // Imprimir ordem decrescente
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + " ");
            }
        }
    }
}
