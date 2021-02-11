using System;
using System.Linq;
using System.Windows.Forms;

namespace CharacterCount
{
    public partial class charCount : Form
    {
        public charCount()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int count_v = 0, count_c = 0, count_n = 0, count_x = 0;
            char[] vowels = "aeiouAEIOU".ToCharArray();
            char[] cons = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ".ToCharArray();
            char[] numbers = "0123456789".ToCharArray();

            string text_in = txtText.Text;

            for (int i = 0; i < text_in.Length; i++)
            {
                if (vowels.Contains(text_in[i]))
                {
                    ++count_v;
                }
                else
                {
                    if (cons.Contains(text_in[i]))
                    {
                        ++count_c;
                    }
                    else
                    {
                        if (numbers.Contains(text_in[i]))
                        {
                            ++count_n;
                        }
                        else
                        {
                            ++count_x;
                        }
                    }
                }
            }

            lblVowels.Text += $" {count_v}";
            lblConsonants.Text += $" {count_c}";
            lblNumbers.Text += $" {count_n}";
            if (count_x > 0)
            {
                lblOthers.Text = $"Others: {count_x}";
            }

        }
    }
}
