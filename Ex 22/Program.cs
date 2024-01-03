namespace Ex_22
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

        static IEnumerable<T> Intersectie<T>(T[] v1, T[] v2)
        {
            var set1 = new HashSet<T>(v1);
            var intersectieSet = new HashSet<T>(v2);

            intersectieSet.IntersectWith(set1);

            return intersectieSet;
        }

        static IEnumerable<T> Reuniune<T>(T[] v1, T[] v2)
        {
            var set1 = new HashSet<T>(v1);
            var set2 = new HashSet<T>(v2);

            set1.UnionWith(set2);

            return set1;
        }

        static IEnumerable<T> Diferenta<T>(T[] v1, T[] v2)
        {
            var set1 = new HashSet<T>(v1);
            var diferentaSet = new HashSet<T>(v1);

            diferentaSet.ExceptWith(v2);

            return diferentaSet;
        }
    }
}