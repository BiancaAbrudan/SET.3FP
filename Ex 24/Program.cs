namespace Ex_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v1 = { 0, 1, 1, 1, 1, 1 };  // 0b011111
            int[] v2 = { 0, 0, 1, 1, 1, 1, 1 };  // 0b0011111

            // Intersectia
            IEnumerable<int> intersectie = Intersectie(v1, v2);
            Console.WriteLine("Intersectia: " + string.Join(", ", intersectie));

            // Reuniunea
            IEnumerable<int> reuniune = Reuniune(v1, v2);
            Console.WriteLine("Reuniunea: " + string.Join(", ", reuniune));

            // Diferenta v1 - v2
            IEnumerable<int> diferentaV1V2 = Diferenta(v1, v2);
            Console.WriteLine("Diferenta v1 - v2: " + string.Join(", ", diferentaV1V2));

            // Diferenta v2 - v1
            IEnumerable<int> diferentaV2V1 = Diferenta(v2, v1);
            Console.WriteLine("Diferenta v2 - v1: " + string.Join(", ", diferentaV2V1));
        }

        static IEnumerable<int> Intersectie(int[] v1, int[] v2)
        {
            var intersectieList = new List<int>();

            int i = 0, j = 0;

            while (i < v1.Length && j < v2.Length)
            {
                if (v1[i] == v2[j] && v1[i] == 1)
                {
                    intersectieList.Add(1);
                    i++;
                    j++;
                }
                else if (v1[i] < v2[j])
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

        static IEnumerable<int> Reuniune(int[] v1, int[] v2)
        {
            var reuniuneList = new List<int>();

            int i = 0, j = 0;

            while (i < v1.Length && j < v2.Length)
            {
                if (v1[i] == v2[j])
                {
                    reuniuneList.Add(v1[i]);
                    i++;
                    j++;
                }
                else if (v1[i] < v2[j])
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

        static IEnumerable<int> Diferenta(int[] v1, int[] v2)
        {
            var diferentaList = new List<int>();

            int i = 0, j = 0;

            while (i < v1.Length && j < v2.Length)
            {
                if (v1[i] == v2[j] && v1[i] == 0)
                {
                    diferentaList.Add(0);
                    i++;
                    j++;
                }
                else if (v1[i] < v2[j])
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