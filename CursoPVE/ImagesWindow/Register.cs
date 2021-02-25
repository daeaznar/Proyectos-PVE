using ImagesWindow.Data;
using ImagesWindow.DataOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImagesWindow
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private string GetOption()
        {
            foreach (Control control in grpConsoles.Controls)
            {
                if (control.GetType() == typeof(RadioButton))
                {
                    RadioButton radio = control as RadioButton;
                    if (radio.Checked)
                    {
                        return radio.Text;
                    }
                }
            }
            return string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GamerManager manager = new GamerManager();
            try
            {
                if (manager.Create(new Gamer()
                {
                    GamerTag = txtGamer.Text,
                    GamingConsole = GetOption()
                }))
                {
                    MessageBox.Show("Gamer created!");
                }
                else
                {
                    MessageBox.Show("Gamer couldn't be created");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("An error ocurred while saving the record");
            }
            
        }
    }
}
