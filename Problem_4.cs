namespace Problem_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            switch (month)
            {
                case "February":
                    Console.WriteLine(28);
                    break;
                case "April": 
                case "June":
                case "September":
                case "November":
                    Console.WriteLine(30);
                    break;
                case "January":
                case "March":
                case "May":
                case "July":
                case "August":
                case "October":
                case "December":
                    Console.WriteLine(31);
                    break;

                default:
                    Console.WriteLine("Please enter a month");
                    break;
                
            }
        }
    }
}