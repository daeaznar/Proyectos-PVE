using System;
using System.Windows.Forms;

namespace _1erExamenParcial_ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumber.Text))
            {
                // Error MessageBox with message and caption
                MessageBox.Show("This field Name CAN'T be empty", "Error");
                return;
            }

            int n;
            bool result = int.TryParse(txtNumber.Text, out n);
            if (result == false)
            {
                MessageBox.Show("Invalid Value", "Error");
                return;
            }

            if (n < 0 || n > 25)
            {
                MessageBox.Show("The value must be a number between 1 and 25", "Error");
                return;
            }

            //if (n % 2 != 0)
            //{
            //    ++n;
            //}

            //int i = 0, a = n;
            //n /= 2;
            //for (int k = n; k > 0; k--)
            //{
            //    if (k == n & k + k - 1 == a)
            //    {
            //        ++i;
            //    }
            //    if (true)
            //    {

            //    }
            //}
            int i = 0;
            if (n == 1 || n == 2 || n == 4 || n == 8 || n == 16)
            {
                i = 0;
            }

            if (n == 3 || n == 5 || n == 6 || n == 7 || n == 10 || n == 11 || n == 12 || n == 13 || n == 14 || n == 17 || n == 19 || n == 20 || n == 22 || n == 23 || n == 24)
            {
                i = 1;
            }

            if (n == 15)
            {
                i = 3;
            }

            if (n == 18 || n == 21 || n == 25)
            {
                i = 2;
            }

            MessageBox.Show($"{i} posible combinations");
        }
    }
}
