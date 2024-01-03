namespace Ex_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul in baza 10: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduceti baza dorita (1 < b < 17): ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (b > 1 && b < 17)
            {
                string result = ConvertToBase(n, b);
                Console.WriteLine($"Numarul {n} in baza {b} este: {result}");
            }
            else
            {
                Console.WriteLine("Baza introdusa nu este valida. Baza trebuie sa fie intre 2 si 16.");
            }
        }

        static string ConvertToBase(int num, int targetBase)
        {
            if (num == 0)
            {
                return "0";
            }

            string result = "";
            while (num > 0)
            {
                int remainder = num % targetBase;
                char digit = (char)(remainder < 10 ? '0' + remainder : 'A' + remainder - 10);
                result = digit + result;
                num /= targetBase;
            }

            return result;
        }
    }
}