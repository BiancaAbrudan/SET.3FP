namespace Ex_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 12, 18, 24 };

            Console.WriteLine("Cel mai mare divizor comun al elementelor vectorului este: " + FindGCD(array));
        }

        static int FindGCD(int[] arr)
        {
            int result = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                result = GetGCD(result, arr[i]);

                if (result == 1)
                {
                    break;
                }
            }

            return result;
        }

        static int GetGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
    }
}