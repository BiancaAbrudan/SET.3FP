namespace Ex_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti gradul polinomului: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double[] coefficients = new double[n + 1];

            Console.WriteLine("Introduceti coeficientii polinomului, incepand cu cel mai putin semnificativ:");
            for (int i = 0; i <= n; i++)
            {
                Console.Write($"Coeficientul x^{i}: ");
                coefficients[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Introduceti valoarea pentru x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double result = EvaluatePolynomial(coefficients, x);
            Console.WriteLine($"Valoarea polinomului in punctul {x} este: {result}");
        }

        static double EvaluatePolynomial(double[] coefficients, double x)
        {
            double result = 0;

            for (int i = 0; i < coefficients.Length; i++)
            {
                result += coefficients[i] * Math.Pow(x, i);
            }

            return result;
        }
    }
}