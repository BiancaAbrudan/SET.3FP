namespace Ex3
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

            int minIndex = 0, maxIndex = 0;

            for (int i = 1; i < n; i += 2)
            {
                if (i + 1 < n)
                {
                    if (vector[i] < vector[i + 1])
                    {
                        if (vector[i] < vector[minIndex]) minIndex = i;
                        if (vector[i + 1] > vector[maxIndex]) maxIndex = i + 1;
                    }
                    else
                    {
                        if (vector[i + 1] < vector[minIndex]) minIndex = i + 1;
                        if (vector[i] > vector[maxIndex]) maxIndex = i;
                    }
                }
                else
                {
                    if (vector[i] < vector[minIndex]) minIndex = i;
                    if (vector[i] > vector[maxIndex]) maxIndex = i;
                }
            }

            Console.WriteLine($"Pozitia celui mai mic element: {minIndex + 1}");
            Console.WriteLine($"Pozitia celui mai mare element: {maxIndex + 1}");

          
        }
    }
}