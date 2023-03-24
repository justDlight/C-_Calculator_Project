namespace Calculator_Logic
{
    public class Class1
    {
        //The way we will need to use the methods returning the value of 5 here
        public static float addition_return(float x, float y)
        {
            return x + y;
        }

        public static float subtraction_return(float x, float y)
        {
            return x - y;
        }

        public static float division_return(float x, float y)
        {
            return x / y;
        }

        public static float multiplication_return(float x, float y)
        {
            return x * y;
        }

        //Reason that I need these as ints is because the ^ Operator does not work on floats only ints.
        //So I have them as ints here
        public static int to_the_power_of_return(int x, int y)
        {
            return x ^ y;
        }
    }
}