namespace Ex_5
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

            Console.Write("Introduceti valoarea de inserat: ");
            int e = int.Parse(Console.ReadLine());

            Console.Write("Introduceti pozitia de inserat (index): ");
            int k = int.Parse(Console.ReadLine());

            if (k < 0 || k > n)
            {
                Console.WriteLine("Pozitia introdusa nu este valida.");
            }
            else
            {
                Array.Resize(ref vector, n + 1);

                for (int i = n; i > k; i--)
                {
                    vector[i] = vector[i - 1];
                }

                vector[k] = e;

                Console.WriteLine("\nVectorul cu valoarea inserata:");
                for (int i = 0; i < vector.Length; i++)
                {
                    Console.WriteLine($"Elementul {i}: {vector[i]}");
                }
            }
        }
    }
}