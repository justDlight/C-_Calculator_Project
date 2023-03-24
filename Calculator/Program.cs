using System.Reflection;
using Calculator_Logic;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x = 2;
            float y = 3;

            Console.WriteLine("Hello, World!");

            //Class1.addition_return(x, y); //This does nothing since your just getting 500 and not displaying it. Fixed below 
            Console.WriteLine(Class1.addition_return(x, y));//Now you are displaying the value 5 since x + y = 5
            Console.WriteLine(Class1.subtraction_return(x, y));
            Console.WriteLine(Class1.division_return(x, y));
            Console.WriteLine(Class1.multiplication_return(x, y));

            //ERROR STARTS HERE!!
            //Type casting a float into an int.
            //Trying to turn a float into an int find more details on why in the Class1 file will change that name to dont worry.
            Console.WriteLine(Class1.to_the_power_of_return((int)x, (int)y));//type cast because of ^ operator NOT WORKING PROPERLY


            Console.WriteLine(Assembly.GetExecutingAssembly().Location);
        }
        
    }
}