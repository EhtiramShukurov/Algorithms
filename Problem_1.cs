namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, a, b, c, d;
            number = Convert.ToInt32(Console.ReadLine());
            a = number / 1000;
            b = number / 100 % 10;
            c = number / 10 % 10;
            d = number % 10;
            Console.WriteLine(a + b + c + d);
        }
    }
}