using System;
using System.Windows.Forms;

namespace FibonacciFactorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = 0;
            bool result = int.TryParse(txtNumber.Text, out number);
            if (result == true)
            { 
                if (number>=1)
                {
                    //Fibonacci
                    long[] fib = new long[number + 1];
                    fib[0] = 0;
                    fib[1] = 1;
                    for (int i = 2; i < number+1; i++)
                    {
                        fib[i] = fib[i - 1] + fib[i - 2];
                    }
                    lblFibonacci.Text = "Fibonacci: ";
                    foreach (int i in fib)
                    {
                        lblFibonacci.Text += $"{i}, ";
                    }

                    //Factorial
                    int fact = 1;
                    for (int i = number; i > 0; i--)
                    {
                        fact *= i;
                    }
                    lblFactorial.Text = $"Factorial: {fact}";
                }
                else
                {
                    MessageBox.Show("The number has to be greater than 0");

                }

            }
            else
            {
                MessageBox.Show("Invalid Value");
            }
        }
    }
}
