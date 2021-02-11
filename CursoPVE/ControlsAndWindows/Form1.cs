using System;
using System.Windows.Forms;

namespace ControlsAndWindows
{
    public partial class ControlsAndWindows : Form
    {
        public ControlsAndWindows()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Validates if the txtBox is empty or not
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                // Error MessageBox with message and caption
                MessageBox.Show("This field Name CAN'T be empty", "Error");
                return;
            }
            if (lstStudents.Items.Contains(txtName.Text.ToUpper()))
            {
                MessageBox.Show("This student is already registered", "Error");
                return;
            }
            // Counts number of items        var count = lstStudents.Items.Count;
            // Clears the list      lstStudents.Items.Clear();
            //Adds txtName (in uppercase) to list 
            if (cmbGrades.SelectedItem == null)
            {
                MessageBox.Show("Please select a Grade", "Error");
                return;
            }
            lstStudents.Items.Add($"{txtName.Text.ToUpper()} {cmbGrades.SelectedItem}");
        }
    }
}
