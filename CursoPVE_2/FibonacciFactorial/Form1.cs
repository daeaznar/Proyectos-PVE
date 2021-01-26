using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            int i = 0;
            string number = txtNumber.Text;
            bool result = int.TryParse(number, out i);
            if (result == true)
            {
                //operaciones
            }
            else
            {
                MessageBox.Show("El dato ingresado NO es válido");
            }
        }
    }
}
