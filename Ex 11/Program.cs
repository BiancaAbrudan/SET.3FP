namespace Ex_11
{
    internal class Program
    {
      
        
            static void AfiseazaPrimePanaLaN(int n)
            {
                bool[] estePrim = new bool[n + 1];

                for (int i = 2; i <= n; i++)
                {
                    estePrim[i] = true;
                }

                for (int i = 2; i * i <= n; i++)
                {
                    if (estePrim[i])
                    {
                        for (int j = i * i; j <= n; j += i)
                        {
                            estePrim[j] = false;
                        }
                    }
                }

                Console.WriteLine($"Numere prime pana la {n}:");
                for (int i = 2; i <= n; i++)
                {
                    if (estePrim[i])
                    {
                        Console.Write($"{i} ");
                    }
                }

                Console.WriteLine();
            }

            static void Main()
            {
                Console.Write("Introduceti un numar natural n: ");
                int n = int.Parse(Console.ReadLine());

                AfiseazaPrimePanaLaN(n);
            }
        }
    }
