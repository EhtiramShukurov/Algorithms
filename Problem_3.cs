namespace Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter = Convert.ToChar(Console.Read());
            if (letter == 'a' || letter == 'A')
            {
                Console.WriteLine("Azerbaycan dili sechildi");
            }
            else if (letter == 'r' || letter == 'R')
            {
                Console.WriteLine("Rus dili sechildi");
            }
            else
            {
                Console.WriteLine("Yanlish sorghu");
            }
        }
    }
}