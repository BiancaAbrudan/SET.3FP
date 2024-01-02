namespace Ex_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];

            Console.WriteLine("Introduceti elementele vectorului:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Introduceti pozitia de sters (index): ");
            int k = int.Parse(Console.ReadLine());

            if (k < 0 || k >= n)
            {
                Console.WriteLine("Pozitia introdusa nu este valida.");
                return;
            }

            for (int i = k; i < n - 1; i++)
            {
                vector[i] = vector[i + 1];
            }

            Array.Resize(ref vector, n - 1);

            Console.WriteLine("\nVectorul cu elementul sters:");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Elementul {i}: {vector[i]}");
            }
        }
    }
}