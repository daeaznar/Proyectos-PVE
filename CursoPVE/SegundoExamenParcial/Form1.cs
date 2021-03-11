using SegundoExamenParcial.DataOperations;
using System;
using System.Windows.Forms;

namespace SegundoExamenParcial
{
    public partial class Form1 : Form
    {
        private ChampionshipManager manager;
        private long currentRegister;
        public Form1()
        {
            manager = new ChampionshipManager();
            InitializeComponent();
            dtgChampionship.DataSource = manager.Read();
            currentRegister = 0;
            tmrUpdate.Start();
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Validates Name isn´t empt or above 100 characters
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name can't be empty", "Error");
                return;
            }
            int name_chars = txtName.Text.Length;
            if (name_chars > 100)
            {
                MessageBox.Show("Character limit exceeded", "Error");
                return;
            }

            //checks if score is number and validates it's between 0 and 100
            int check_score = 0;
            bool result = int.TryParse(txtScore.Text, out check_score);
           
            if (result == false)
            {
                MessageBox.Show("Score values must be a number", "Error");
                return;
            }
            if (check_score < 0 || check_score>100)
            {
                MessageBox.Show("Score must be a number between 0 and 100", "Error");
                return;
            }

            //Inser Register to DB
            try
            {
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    MessageBox.Show("Please enter a Name");
                    return;
                }

                var registerCreated = new Data.DanceChampionship()
                {
                    Name = txtName.Text,
                    City = (string)cmbCity.SelectedItem,
                    Gender = (string)cmbGender.SelectedItem,
                    Category = (string)cmbCategory.SelectedItem,
                    Dance = (string)cmbDance.SelectedItem,
                    Score = short.Parse(txtScore.Text)
                };
                //RegisterCreated
                if (manager.Create(registerCreated))
                {
                    MessageBox.Show("Register saved", "Success");
                    dtgChampionship.DataSource = manager.Read();
                    tmrUpdate.Stop();
                    tmrUpdate.Start();
                }
                else
                {
                    MessageBox.Show("Register couldn't be saved. Please try again later", "Error");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("An error occure while saving data", "Error");
            }
        }
    
        //Update DB fields
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentRegister == 0)
                {
                    MessageBox.Show("Please select a record to update from the table");
                }
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    MessageBox.Show("Please enter a Name");
                    return;
                }

                var registerUpdated = new Data.DanceChampionship()
                {
                    Name = txtName.Text,
                    City = (string)cmbCity.SelectedItem,
                    Gender = (string)cmbGender.SelectedItem,
                    Category = (string)cmbCategory.SelectedItem,
                    Dance = (string)cmbDance.SelectedItem,
                    Score = short.Parse(txtScore.Text)
                };

                //RegisterUpdate
                if (manager.Update(registerUpdated))
                {
                    MessageBox.Show("Register saved", "Success");
                    dtgChampionship.DataSource = manager.Read();
                }
                else
                {
                    MessageBox.Show("Register couldn't be saved. Please try again later", "Error");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("An error occure while saving data", "Error");
            }
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            dtgChampionship.DataSource = manager.Read();
        }
    }
}
