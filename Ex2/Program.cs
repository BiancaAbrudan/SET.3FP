
namespace Ex2
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

            Console.Write("Introduceti valoarea k: ");
            int k = Convert.ToInt32(Console.ReadLine());

            int pozitie = GasestePozitie(vector, k);

            if (pozitie != -1)
                Console.WriteLine($"Prima pozitie a valorii {k} in vector este: {pozitie + 1}");
            else
                Console.WriteLine($"Valoarea {k} nu apare in vector.");

            Console.ReadKey();
        }

        static int GasestePozitie(int[] vector, int k)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == k)
                {
                    return i;
                }
            }
          
            return -1;
        }
    }
}