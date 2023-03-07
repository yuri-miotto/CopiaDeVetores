internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        int[] lista1 = new int[5];
        int[] lista2 = new int[5];
        int[] lista3 = new int[10];

        for (int i = 0; i < lista1.Length; i++)
        {
           
            Console.WriteLine("Digite um número para a primeira lista...");
            num = int.Parse(Console.ReadLine());
            lista1[i] = num;
            
        }

        for (int i = 0; i < lista2.Length; i++)
        {
            Console.WriteLine("Digite um número para a segunda lista...");
            num = int.Parse(Console.ReadLine());
            lista2[i] = num;
        }

        Console.Write("Primeira lista: ");
        for (int i = 0; i < lista1.Length; i++)
        {
            Console.Write(lista1[i] + " ");
        }

        Console.WriteLine();

        Console.Write("Segunda lista: ");
        for (int i = 0; i < lista2.Length; i++)
        {
            Console.Write(lista2[i] + " ");
        }

        Console.WriteLine();

        for (int i = 0; i<5; i++)
        {
            lista3[i] = lista1[i];
        }

        for (int i = 5; i < 10; i++)
        {
            lista3[i] = lista2[i - 5];
        }

        Console.Write("Total das duas listas: ");
        for (int i = 0; i < lista3.Length; i++)
        {
            Console.Write(lista3[i] + " ");
        }

    }
}