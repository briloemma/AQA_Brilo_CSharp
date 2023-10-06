namespace AQA_Brilo_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Первый алгоритм");
            Console.ResetColor();
            Algorithm.Hello();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Второй алгоритм");
            Console.ResetColor();
            Algorithm.HelloPerson();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Третий алгоритм");
            Console.ResetColor();
            Algorithm.ArrayNums();
        }
    }
}
