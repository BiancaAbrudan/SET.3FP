namespace Ex_7
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

            for (int i = 0; i < n / 2; i++)
            {
                int temp = vector[i];
                vector[i] = vector[n - 1 - i];
                vector[n - 1 - i] = temp;
            }

            Console.WriteLine("\nVectorul inversat:");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Elementul {i}: {vector[i]}");
            }
        }
    }
}