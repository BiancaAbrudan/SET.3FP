namespace Ex__29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vector = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };

            Console.WriteLine("Vectorul initial: " + string.Join(", ", vector));

            MergeSort(vector, 0, vector.Length - 1);

            Console.WriteLine("Vectorul sortat: " + string.Join(", ", vector));
        }

        static void MergeSort(int[] vector, int stanga, int dreapta)
        {
            if (stanga < dreapta)
            {
                int mijloc = (stanga + dreapta) / 2;

           
                MergeSort(vector, stanga, mijloc);
                MergeSort(vector, mijloc + 1, dreapta);

                Merge(vector, stanga, mijloc, dreapta);
            }
        }

        static void Merge(int[] vector, int stanga, int mijloc, int dreapta)
        {
            int lungimeStanga = mijloc - stanga + 1;
            int lungimeDreapta = dreapta - mijloc;

            int[] stangaTemp = new int[lungimeStanga];
            int[] dreaptaTemp = new int[lungimeDreapta];

            for (int i = 0; i < lungimeStanga; i++)
            {
                stangaTemp[i] = vector[stanga + i];
            }

            for (int j = 0; j < lungimeDreapta; j++)
            {
                dreaptaTemp[j] = vector[mijloc + 1 + j];
            }


            int indexStanga = 0, indexDreapta = 0;

            int indexVector = stanga;

            while (indexStanga < lungimeStanga && indexDreapta < lungimeDreapta)
            {
                if (stangaTemp[indexStanga] <= dreaptaTemp[indexDreapta])
                {
                    vector[indexVector] = stangaTemp[indexStanga];
                    indexStanga++;
                }
                else
                {
                    vector[indexVector] = dreaptaTemp[indexDreapta];
                    indexDreapta++;
                }
                indexVector++;
            }

            while (indexStanga < lungimeStanga)
            {
                vector[indexVector] = stangaTemp[indexStanga];
                indexStanga++;
                indexVector++;
            }

            while (indexDreapta < lungimeDreapta)
            {
                vector[indexVector] = dreaptaTemp[indexDreapta];
                indexDreapta++;
                indexVector++;
            }
        }
    }
}