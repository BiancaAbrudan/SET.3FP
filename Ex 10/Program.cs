namespace Ex_10
{
    internal class Program
    {
       
        
            static int CautareBinara(int[] vector, int k)
            {
                int stanga = 0;
                int dreapta = vector.Length - 1;

                while (stanga <= dreapta)
                {
                    int mijloc = stanga + (dreapta - stanga) / 2;

                    if (vector[mijloc] == k)
                        return mijloc; 

                    if (vector[mijloc] < k)
                        stanga = mijloc + 1;
                    else
                        dreapta = mijloc - 1;
                }

                return -1; 
            }

            static void Main()
            {
                Console.Write("Introduceti lungimea vectorului: ");
                int n = int.Parse(Console.ReadLine());

                int[] vector = new int[n];

                Console.WriteLine("Introduceti elementele vectorului (sortate in ordine crescatoare):");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Elementul {i}: ");
                    vector[i] = int.Parse(Console.ReadLine());
                }

                Console.Write("Introduceti elementul cautat (k): ");
                int k = int.Parse(Console.ReadLine());

                int pozitie = CautareBinara(vector, k);

                if (pozitie != -1)
                    Console.WriteLine($"Elementul {k} se afla la pozitia {pozitie} in vector.");
                else
                    Console.WriteLine($"Elementul {k} nu a fost gasit in vector.");
            }
    }
}