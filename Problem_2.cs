namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int m, n, k;
            m = number / 100;
            n = number / 10 % 10;
            k = number % 10;
            if (m == n && n == k)
            {
                Console.WriteLine("Butun reqemler beraberdir");
            }
            else
            {
                Console.WriteLine("Butun reqemler beraber deyil");
            }
        }
    }
}