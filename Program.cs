using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello this is a test");

            adding_two_nums();
            adding_users_nums();
            Console.ReadLine();
        }

        static void adding_two_nums()
        {
            int number_4 = 234;
            int number_5 = 549;
            int number_6 = 0;

            number_6 = number_4 + number_5;

            Console.WriteLine(number_6);
        }

        static void adding_users_nums() 
        {
            int final_num = 0;

            Console.WriteLine("Enter your first number:");
            int usersNum_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number:");
            int usersNum_2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your first number is: " + usersNum_1 + " & your second number is: " + usersNum_2);
            Console.WriteLine("CALCULATING ADDING NUMBERS TOGETHER CALCULATING ADDITION");
            final_num = usersNum_1 + usersNum_2;
            Console.WriteLine("CALCULATING COMPLETE FINAL NUMBER IS: " + final_num);
            Console.WriteLine("CALCULATING COMPLETE FINAL NUMBER IS: ");


        }
    }
}
