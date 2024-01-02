namespace Ex_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 64, 25, 12, 22, 11 };

            Console.WriteLine("Array inainte de sortare:");
            PrintArray(array);

            SelectionSortFunction(array);

            Console.WriteLine("\nArray dupa sortare:");
            PrintArray(array);
        }

        static void SelectionSortFunction(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
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