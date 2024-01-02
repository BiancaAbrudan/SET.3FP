namespace Ex_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 64, 25, 12, 22, 11 };

            Console.WriteLine("Array inainte de sortare:");
            PrintArray(array);

            InsertionSortFunction(array);

            Console.WriteLine("\nArray dupa sortare:");
            PrintArray(array);
        }

        static void InsertionSortFunction(int[] arr)
        {
            int n = arr.Length;

            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                arr[j + 1] = key;
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}