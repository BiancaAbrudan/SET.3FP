namespace Ex_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "NNBWWBW";
            string s2 = "BWNWBWN";

            int numSuprapuneri = NumarSuprapuneri(s1, s2);

            Console.WriteLine($"Numarul de suprapuneri este: {numSuprapuneri}");
        }

        static int NumarSuprapuneri(string s1, string s2)
        {
            int numSuprapuneri = 0;
            int n = s1.Length;

            for (int i = 0; i < n; i++)
            {
                numSuprapuneri += NumarSuprapuneriRotite(s1, s2, i);
            }

            return numSuprapuneri;
        }

        static int NumarSuprapuneriRotite(string s1, string s2, int offset)
        {
            int numSuprapuneri = 0;
            int n = s1.Length;

            for (int i = 0; i < n; i++)
            {
                int j = (i + offset) % n;

                if (s1[i] == s2[j])
                {
                    numSuprapuneri++;
                }
            }

            return numSuprapuneri;
        }
    }
}