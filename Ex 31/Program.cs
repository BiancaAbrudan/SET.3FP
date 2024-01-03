namespace Ex_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vector = { 3, 1, 3, 3, 2, 3, 5, 3, 6 };

            int rezultat = GasesteElementMajoritar(vector);

            if (rezultat != -1)
            {
                Console.WriteLine("Elementul majoritar este: " + rezultat);
            }
            else
            {
                Console.WriteLine("Nu există element majoritar în vector.");
            }
        }

        static int GasesteElementMajoritar(int[] vector)
        {
            int candidat = -1;
            int count = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                if (count == 0)
                {
                    candidat = vector[i];
                    count = 1;
                }
                else
                {
                    if (vector[i] == candidat)
                    {
                        count++;
                    }
                    else
                    {
                        count--;
                    }
                }
            }

            count = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == candidat)
                {
                    count++;
                }
            }

            if (count > vector.Length / 2)
            {
                return candidat;
            }

            return -1;
        }
    }
}