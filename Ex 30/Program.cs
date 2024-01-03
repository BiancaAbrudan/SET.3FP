namespace Ex_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] E = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };
            int[] W = { 10, 5, 8, 2, 7, 4, 1, 6, 3, 9, 2 };

            Console.WriteLine("Vectorul E initial: " + string.Join(", ", E));
            Console.WriteLine("Vectorul W initial: " + string.Join(", ", W));

            SortareBicriteriala(E, W);

            Console.WriteLine("Vectorul E sortat: " + string.Join(", ", E));
            Console.WriteLine("Vectorul W sortat: " + string.Join(", ", W));
        }

        static void SortareBicriteriala(int[] E, int[] W)
        {
            Comparer<int> comparer = Comparer<int>.Create((a, b) =>
            {
                int comparareE = a.CompareTo(b);
                if (comparareE != 0)
                {
                    return comparareE;
                }

                return W[b].CompareTo(W[a]);
            });

            Array.Sort(E, comparer);
            Array.Sort(W, E, comparer);
        }
    }
}