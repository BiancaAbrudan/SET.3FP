namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti dimensiunea vectorului: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] vector = new int[n];

            Console.WriteLine("Introduceti elementele vectorului:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}: ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                suma += vector[i];
            }

            Console.WriteLine($"Suma elementelor vectorului este: {suma}");
            Console.ReadKey();
        }
    }
}