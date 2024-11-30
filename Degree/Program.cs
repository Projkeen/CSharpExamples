namespace Degree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter degree:");
            int degree = Convert.ToInt32(Console.ReadLine());
            double result = Degree(number, degree);
            Console.WriteLine($"Number {number} in degree {degree} equals " + result);
        }
        static double Degree(double num, int degr)
        {
            double result = 1;
            for (int i = 0; i < degr; i++)
            {
                result = result * num;
            }
            return result;
        }
    }
}
