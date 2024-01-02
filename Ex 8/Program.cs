namespace Ex_8
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

            int temp = vector[0];

            for (int i = 1; i < n; i++)
            {
                vector[i - 1] = vector[i];
            }

            vector[n - 1] = temp;

            Console.WriteLine("\nVectorul rotit spre stanga:");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Elementul {i}: {vector[i]}");
            }
        }
    }
}