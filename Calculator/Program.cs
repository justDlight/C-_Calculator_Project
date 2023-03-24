using System.Reflection;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(Assembly.GetExecutingAssembly().Location);
        }
    }
}