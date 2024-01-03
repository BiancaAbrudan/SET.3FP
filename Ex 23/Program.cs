namespace Ex_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v1 = { 1, 2, 3, 4, 5 };
            int[] v2 = { 3, 4, 5, 6, 7 };

            
            IEnumerable<int> intersectie = Intersectie(v1, v2);
            Console.WriteLine("Intersectia: " + string.Join(", ", intersectie));

            IEnumerable<int> reuniune = Reuniune(v1, v2);
            Console.WriteLine("Reuniunea: " + string.Join(", ", reuniune));

            IEnumerable<int> diferentaV1V2 = Diferenta(v1, v2);
            Console.WriteLine("Diferenta v1 - v2: " + string.Join(", ", diferentaV1V2));

            IEnumerable<int> diferentaV2V1 = Diferenta(v2, v1);
            Console.WriteLine("Diferenta v2 - v1: " + string.Join(", ", diferentaV2V1));
        }

        static IEnumerable<T> Intersectie<T>(T[] v1, T[] v2) where T : IComparable<T>
        {
            var intersectieList = new List<T>();

            int i = 0, j = 0;

            while (i < v1.Length && j < v2.Length)
            {
                int comparare = v1[i].CompareTo(v2[j]);

                if (comparare == 0)
                {
                    intersectieList.Add(v1[i]);
                    i++;
                    j++;
                }
                else if (comparare < 0)
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }

            return intersectieList;
        }

        static IEnumerable<T> Reuniune<T>(T[] v1, T[] v2) where T : IComparable<T>
        {
            var reuniuneList = new List<T>();

            int i = 0, j = 0;

            while (i < v1.Length && j < v2.Length)
            {
                int comparare = v1[i].CompareTo(v2[j]);

                if (comparare == 0)
                {
                    reuniuneList.Add(v1[i]);
                    i++;
                    j++;
                }
                else if (comparare < 0)
                {
                    reuniuneList.Add(v1[i]);
                    i++;
                }
                else
                {
                    reuniuneList.Add(v2[j]);
                    j++;
                }
            }

            while (i < v1.Length)
            {
                reuniuneList.Add(v1[i]);
                i++;
            }

            while (j < v2.Length)
            {
                reuniuneList.Add(v2[j]);
                j++;
            }

            return reuniuneList;
        }

        static IEnumerable<T> Diferenta<T>(T[] v1, T[] v2) where T : IComparable<T>
        {
            var diferentaList = new List<T>();

            int i = 0, j = 0;

            while (i < v1.Length && j < v2.Length)
            {
                int comparare = v1[i].CompareTo(v2[j]);

                if (comparare == 0)
                {
                    i++;
                    j++;
                }
                else if (comparare < 0)
                {
                    diferentaList.Add(v1[i]);
                    i++;
                }
                else
                {
                    j++;
                }
            }

            while (i < v1.Length)
            {
                diferentaList.Add(v1[i]);
                i++;
            }

            return diferentaList;
        }
    }
}