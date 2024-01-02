namespace Ex_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 0, 5, 0, 0, 8, 0, 2, 0, 1 };

            Console.WriteLine("Array inainte de interschimbare:");
            PrintArray(array);

            SwapZerosToEnd(array);

            Console.WriteLine("\nArray dupa interschimbare:");
            PrintArray(array);
        }

        static void SwapZerosToEnd(int[] arr)
        {
            int n = arr.Length;
            int nonZeroIndex = 0;

            for (int i = 0; i < n; i++)
            {

                if (arr[i] != 0)
                {
                    int temp = arr[i];
                    arr[i] = arr[nonZeroIndex];
                    arr[nonZeroIndex] = temp;

                    nonZeroIndex++;
                }
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