using System;

namespace exe06a2
{
    class Program
    {
        static int[] vetor; // Apenas declarado

        static void Main(string[] args)
        {
            Random r = new Random();
            vetor = new int[5]; // Inicialização correta do vetor

            // PREENCHIMENTO DO ARRAY COM NÚMEROS ALEATÓRIOS
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = r.Next(1, 20);
            }

            // IMPRIMIR SEM ORDENAÇÃO
            Console.WriteLine("\n---- SEM ORDENAÇÃO ----");
            Imprimir();

            // IMPRIMIR ORDENADO CRESCENTE
            Console.WriteLine("\n---- ORDENADO CRESCENTE ----");
            OrdenarCrescente();
            Imprimir();

            // IMPRIMIR ORDENADO DECRESCENTE
            Console.WriteLine("\n---- ORDENADO DECRESCENTE ----");
            OrdenarDecrescente();
            Imprimir();
        }

        //=================================== MÉTODOS ==========================================

        private static void Imprimir()
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + " ");
            }
        }

        private static void OrdenarCrescente()
        {
            Array.Sort(vetor); // Usa a função nativa para simplificar
        }

        private static void OrdenarDecrescente()
        {
            Array.Sort(vetor); // Ordena crescente primeiro
            Array.Reverse(vetor); // Depois inverte para decrescente
        }
    }
}
