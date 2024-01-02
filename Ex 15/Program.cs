namespace Ex_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 2, 3, 1, 4, 2, 8, 3 };

            Console.WriteLine("Array inainte de eliminarea duplicatelor:");
            PrintArray(array);
            RemoveDuplicates(array);

            Console.WriteLine("\nArray dupa eliminarea duplicatelor:");
            PrintArray(array);
        }

        static void RemoveDuplicates(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] != -1)
                {
                   
                    for (int j = i + 1; j < n; j++)
                    {
                        if (arr[j] == arr[i])
                        {
                            arr[j] = -1;
                        }
                    }
                }
            }

            int nonDuplicateIndex = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] != -1)
                {
                    arr[nonDuplicateIndex] = arr[i];
                    nonDuplicateIndex++;
                }
            }

 
            Array.Resize(ref arr, nonDuplicateIndex);
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