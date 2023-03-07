internal class Program
{
    private static void Main(string[] args)
    {        
        int[] A = new int[5];
        int[] B = new int[5];
        int[] C = new int[10];

        LerVetor(A, "Vetor A");
        LerVetor(B, "Vetor B");

        C = UnirVetores(A, B);

        ImprimirVetor(A, "Vetor A");
        ImprimirVetor(B, "Vetor B");
        ImprimirVetor(C, "Vetor C");

        OrdenarVetor(C);

        ImprimirVetor(C, "Vetor C");

        void OrdenarVetor(int[] vetor)
        {
            int i, j;
            for(i = 0; i < vetor.Length - 1; i++)
            {
                for(j=i+1; j < vetor.Length; j++)
                {
                    if (vetor[i] > vetor[j])
                    {
                        int aux = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = aux;
                    }
                }
            }
        }

        void LerVetor(int[] aux, string texto)
        {
            //Leitura do vetor
            Console.WriteLine("\nDigite os valores do {0}: ", texto);
            for (int i = 0; i < aux.Length; i++)
            {
                Console.Write("\nVetor[{0}] = ", i);
                aux[i] = int.Parse(Console.ReadLine());
            }
        }

        void ImprimirVetor(int[] aux, string texto)
        {
            Console.WriteLine("\nOs valores do {0} são: ", texto);
            for (int i = 0; i < aux.Length; i++)
            {
                Console.WriteLine("\nVetor[{0}] = {1}", i, aux[i]);
            }
        }

        int[] UnirVetores(int[] A, int[] B)
        {
            int[] aux = new int[10];
            for (int i = 0; i < A.Length; i++)
                aux[i] = A[i];
            for (int i = 0; i < B.Length; i++)
                aux[i + 5] = B[i];
            return aux;
        }


    }
}