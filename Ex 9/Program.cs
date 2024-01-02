namespace Ex_9
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

            Console.Write("Introduceti numarul de pozitii pentru rotirea spre stanga (k): ");
            int k = int.Parse(Console.ReadLine());

            k = k % n;

            int[] temp = new int[k];
            Array.Copy(vector, temp, k);

            for (int i = k; i < n; i++)
            {
                vector[i - k] = vector[i];
            }

            Array.Copy(temp, 0, vector, n - k, k);

            Console.WriteLine("\nVectorul rotit spre stanga:");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Elementul {i}: {vector[i]}");
            }
        }
    }
}