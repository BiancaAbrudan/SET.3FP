namespace Ex_4
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
                Console.Write($"Elementul {i + 1}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            int min = vector.Min();
            int max = vector.Max();

            int contorMin = vector.Count(x => x == min);
            int contorMax = vector.Count(x => x == max);

            Console.WriteLine($"\nCea mai mica valoare: {min}, apare de {contorMin} ori");
            Console.WriteLine($"Cea mai mare valoare: {max}, apare de {contorMax} ori");
        }
    }
}