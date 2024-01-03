namespace Ex_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vector = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };
            int index = 7;

            int valoareDupaSortare = ValoareDupaSortare(vector, index);

            Console.WriteLine($"Valoarea de pe pozitia {index} dupa sortare este: {valoareDupaSortare}");
        }

        static int ValoareDupaSortare(int[] vector, int index)
        {
            int[] copieVector = new int[vector.Length];
            Array.Copy(vector, copieVector, vector.Length);

            Array.Sort(copieVector);

            int valoareDupaSortare = copieVector[index];

            return valoareDupaSortare;
        }
    }
}