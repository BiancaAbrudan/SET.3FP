namespace Ex_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vector1 = { 1, 2, 3, 4 };
            int[] vector2 = { 1, 2, 3, 5 };

            string ordineLexicografica = DeterminaOrdineLexicografica(vector1, vector2);

            Console.WriteLine($"Ordinea lexicografica a vectorilor este: {ordineLexicografica}");
        }

        static string DeterminaOrdineLexicografica(int[] vector1, int[] vector2)
        {
            string str1 = ConvertVectorToString(vector1);
            string str2 = ConvertVectorToString(vector2);

            return str1.CompareTo(str2) < 0 ? "Primul vector" : "Al doilea vector";
        }

        static string ConvertVectorToString(int[] vector)
        {
            return string.Join(",", vector);
        }
    }
}