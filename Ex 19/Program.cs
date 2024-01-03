namespace Ex_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] s = { 1, 2, 1, 2, 1, 3, 1, 2, 1 };
            int[] p = { 1, 2, 1 };

            int occurrences = CountOccurrences(s, p);

            Console.WriteLine($"Vectorul p apare in vectorul s de {occurrences} ori.");
        }

        static int CountOccurrences(int[] s, int[] p)
        {
            int occurrences = 0;

            if (s.Length < p.Length)
                return occurrences;

            int basePrime = 101;  

            int hashP = ComputeHash(p, p.Length, basePrime);
            int hashS = ComputeHash(s, p.Length, basePrime);

            if (hashP == hashS)
            {
                if (CheckEquality(s, 0, p))
                {
                    occurrences++;
                }
            }

            for (int i = p.Length; i < s.Length; i++)
            {
                hashS = RecalculateHash(hashS, p.Length, s[i - p.Length], s[i], basePrime);

                if (hashP == hashS && CheckEquality(s, i - p.Length + 1, p))
                {
                    occurrences++;
                }
            }

            return occurrences;
        }

        static int ComputeHash(int[] arr, int length, int basePrime)
        {
            int hash = 0;
            for (int i = 0; i < length; i++)
            {
                hash = (hash * basePrime + arr[i]) % int.MaxValue;
            }
            return hash;
        }

        static int RecalculateHash(int oldHash, int length, int oldElement, int newElement, int basePrime)
        {
            int hash = oldHash - (int)Math.Pow(oldElement * basePrime, length - 1);
            hash = (hash * basePrime + newElement) % int.MaxValue;
            return hash;
        }

        static bool CheckEquality(int[] arr1, int startIndex, int[] arr2)
        {
            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr1[startIndex + i] != arr2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}