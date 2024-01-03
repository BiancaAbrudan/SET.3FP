namespace Ex_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vector = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };

            Console.WriteLine("Vectorul initial: " + string.Join(", ", vector));

            QuickSort(vector, 0, vector.Length - 1);

            Console.WriteLine("Vectorul sortat: " + string.Join(", ", vector));
        }

        static void QuickSort(int[] vector, int stanga, int dreapta)
        {
            if (stanga < dreapta)
            {
                int pivotIndex = Partitioneaza(vector, stanga, dreapta);

                QuickSort(vector, stanga, pivotIndex - 1);
                QuickSort(vector, pivotIndex + 1, dreapta);
            }
        }

        static int Partitioneaza(int[] vector, int stanga, int dreapta)
        {
            int pivot = vector[dreapta];
            int i = stanga - 1;

            for (int j = stanga; j < dreapta; j++)
            {
                if (vector[j] < pivot)
                {
                    i++;

                    int temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;
                }
            }

            int tempSwap = vector[i + 1];
            vector[i + 1] = vector[dreapta];
            vector[dreapta] = tempSwap;

            return i + 1;
        }
    }
}