namespace Ex_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numar1 = { 9, 9, 9, 9, 9 };
            int[] numar2 = { 1, 0, 0, 0, 0 };

            int[] suma = Aduna(numar1, numar2);
            Console.WriteLine("Suma: " + string.Join(", ", suma));

            int[] diferenta = Scade(numar1, numar2);
            Console.WriteLine("Diferenta: " + string.Join(", ", diferenta));

            int[] produs = Inmulteste(numar1, numar2);
            Console.WriteLine("Produsul: " + string.Join(", ", produs));
        }

        static int[] Aduna(int[] numar1, int[] numar2)
        {
            List<int> rezultat = new List<int>();
            int carry = 0;

            for (int i = 0; i < Math.Max(numar1.Length, numar2.Length); i++)
            {
                int digit1 = i < numar1.Length ? numar1[i] : 0;
                int digit2 = i < numar2.Length ? numar2[i] : 0;

                int sumaCifrelor = digit1 + digit2 + carry;
                carry = sumaCifrelor / 10;
                rezultat.Add(sumaCifrelor % 10);
            }

            if (carry > 0)
            {
                rezultat.Add(carry);
            }

            return rezultat.ToArray();
        }

        static int[] Scade(int[] numar1, int[] numar2)
        {
            List<int> rezultat = new List<int>();
            int borrow = 0;

            for (int i = 0; i < numar1.Length; i++)
            {
                int digit1 = numar1[i];
                int digit2 = i < numar2.Length ? numar2[i] : 0;

                int diferentaCifrelor = digit1 - digit2 - borrow;

                if (diferentaCifrelor < 0)
                {
                    diferentaCifrelor += 10;
                    borrow = 1;
                }
                else
                {
                    borrow = 0;
                }

                rezultat.Add(diferentaCifrelor);
            }

            return rezultat.ToArray();
        }

        static int[] Inmulteste(int[] numar1, int[] numar2)
        {
            int m = numar1.Length;
            int n = numar2.Length;
            int[] produs = new int[m + n];

            for (int i = m - 1; i >= 0; i--)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    int cifraProdus = numar1[i] * numar2[j] + produs[i + j + 1];
                    produs[i + j] += cifraProdus / 10;
                    produs[i + j + 1] = cifraProdus % 10;
                }
            }

            return produs;
        }
    }
}