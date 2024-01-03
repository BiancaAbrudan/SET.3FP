namespace Ex_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v1 = { 1, 3, 5, 7, 9 };
            int[] v2 = { 2, 4, 6, 8, 10 };

            int[] rezultat = Interclaseaza(v1, v2);

            Console.WriteLine("Vectorul interclasat: " + string.Join(", ", rezultat));
        }

        static int[] Interclaseaza(int[] v1, int[] v2)
        {
            int lungimeV1 = v1.Length;
            int lungimeV2 = v2.Length;
            int lungimeRezultat = lungimeV1 + lungimeV2;
            int[] rezultat = new int[lungimeRezultat];

            int i = 0, j = 0, k = 0;

            while (i < lungimeV1 && j < lungimeV2)
            {
                if (v1[i] <= v2[j])
                {
                    rezultat[k++] = v1[i++];
                }
                else
                {
                    rezultat[k++] = v2[j++];
                }
            }

            while (i < lungimeV1)
            {
                rezultat[k++] = v1[i++];
            }

            while (j < lungimeV2)
            {
                rezultat[k++] = v2[j++];
            }

            return rezultat;
        }
    }
}