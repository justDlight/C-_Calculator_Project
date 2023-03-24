using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator_App
{
    public partial class Form1 : Form
    {
        // Store the current calculation as a string
        private string currentCalculation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            // This adds the number or operator to the string calculation
            currentCalculation += (sender as Button).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }

        private void button_Equals_Click(object sender, EventArgs e)
        {
            // Replacing X with * and ÷ with / for calculations
            string expression = currentCalculation.Replace("X", "*").Replace("&divide;", "/");

            try
            {
                // Check if the expression is valid before calculating the result
                //Compute method computes the given expression on the current rows that pass the filter criteria. 
                var result = new DataTable().Compute(expression, null);

                //NaN(Not a Number) is a numeric data type that means an undefined value or value that cannot be represented, especially results of floating-point calculations.
                // Check if the result is NaN aka Not a Number, as DataTable.Compute can sometimes return NaN for invalid expressions
                if (result is double && double.IsNaN((double)result))
                {
                    textBoxOutput.Text = "NaN";
                }
                else
                {
                    // Display the result to the user and store it as the new calculation
                    textBoxOutput.Text = result.ToString();

                    //HELP why is textBoxOutput saying it may not be null I know that this is true because the user may not click anything so it is null but why does it highlight it green and pop up with warning??
                    currentCalculation = textBoxOutput.Text;
                }
            }
            catch (Exception)
            {
                // If there's an error, display "Error" and reset the calculation
                textBoxOutput.Text = "Error";
                currentCalculation = "";
            }

        }
        //The clear button method for the C button the calculator
        private void button_Clear_Click(object sender, EventArgs e)
        {
            // Reset the calculation and empty the textbox
            textBoxOutput.Text = "0";
            currentCalculation = "";
        }

        //The Clear Entry method for the CE button on the calculator
        private void button_ClearEntry_Click(object sender, EventArgs e)
        {
            // If the calculation is not empty, remove the last number/operator entered
            if (currentCalculation.Length > 0)
            {
                currentCalculation = currentCalculation.Remove(currentCalculation.Length - 1, 1);
            }

            // Re-display the calculation onto the screen
            textBoxOutput.Text = currentCalculation;
        }
    }
}

