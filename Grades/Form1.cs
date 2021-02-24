using Grades.Data;
using Grades.DataOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grades
{
    public partial class Grades : Form
    {
        private int click_btn = 0;  //stores number of times btnCalculate has been clicked
        float exercises, project, exam; //Grades
        float first_period = 0, second_period = 0, third_period = 0, final_grade =0;

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clears all values except from Approved/NotApproved List
            txtName.Text = txtExercises.Text = txtProject.Text = txtExam.Text= string.Empty;
            txtName.Enabled = true;
            btnCalculate.Enabled = true;
            lstFirstPeriod.Items.Clear();
            lstSecondPeriod.Items.Clear();
            lstThirdPeriod.Items.Clear();
            lblFirstAverage.Text = "First Period Average:";
            lblSecondAverage.Text = "Second Period Average:";
            lblThirdAverage.Text = "Third Period Average:";
        }

        public Grades()
        {
            InitializeComponent();
            this.ActiveControl = txtName;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Validates empty fields
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtExercises.Text)
                || string.IsNullOrWhiteSpace(txtProject.Text) || string.IsNullOrWhiteSpace(txtExam.Text))
            {
                MessageBox.Show("Some fields are empty", "Error");
                return;
            }
            // Validates numeric values for grade fields
            exercises = project = exam = 0;
            bool result_a = float.TryParse(txtExercises.Text, out exercises);
            bool result_b = float.TryParse(txtProject.Text, out project);
            bool result_c = float.TryParse(txtExam.Text, out exam);
            if (result_a == false || result_b == false || result_c == false)
            {
                MessageBox.Show("Grade values must be a number", "Error");
                return;
            }
            // Validates if student has already been graded
            if (lstApproved.Items.Contains(txtName.Text.ToUpper())
                || lstNotApproved.Items.Contains(txtName.Text.ToUpper()))
            {
                MessageBox.Show("This student has already been graded", "Error");
                return;
            }
            ++click_btn;

            #region Periods
            // First Period
            if (click_btn == 1)
            {
                this.ActiveControl = txtExercises;
                btnClear.Enabled = false;   //Disables btnClear

                lstFirstPeriod.Items.Add($"{txtName.Text.ToUpper()} " +
                    $"- Ex: {exercises} | Proj: {project} | Exam: {exam}"); //Add values to list
                txtName.Enabled = false;    //disable name textbox
                txtExercises.Text = string.Empty;   //empty textbox
                txtProject.Text = string.Empty;
                txtExam.Text = string.Empty;
                first_period = (exercises * 30 / 100) + (project * 20 / 100) + (exam * 50 / 100);
                lblFirstAverage.Text += $" {first_period}";
            }

            // Second Period
            if (click_btn == 2)
            {
                this.ActiveControl = txtExercises;
                lstSecondPeriod.Items.Add($"{txtName.Text.ToUpper()} " +
                    $"- Ex: {exercises} | Proj: {project} | Exam: {exam}");
                txtExercises.Text = string.Empty;
                txtProject.Text = string.Empty;
                txtExam.Text = string.Empty;
                second_period = (exercises * 40 / 100) + (project * 20 / 100) + (exam * 40 / 100);
                lblSecondAverage.Text += $" {second_period}";
            }

            //Third Period
            if (click_btn == 3)
            {
                click_btn = 0;
                lstThirdPeriod.Items.Add($"{txtName.Text.ToUpper()} " +
                    $"- Ex: {exercises} | Proj: {project} | Exam: {exam}");
                txtExercises.Text = string.Empty;
                txtProject.Text = string.Empty;
                txtExam.Text = string.Empty;
                third_period = (project * 70 / 100) + (exam * 30 / 100);
                lblThirdAverage.Text += $" {third_period}";

                //Calculate final grade and if student approved
                final_grade = (first_period * 25 / 100) + (second_period * 35 / 100) + (third_period * 40 / 100);
                if (final_grade >= 70)
                {
                    lstApproved.Items.Add(txtName.Text.ToUpper());
                }
                else
                {
                    lstNotApproved.Items.Add(txtName.Text.ToUpper());
                }

                btnCalculate.Enabled = false;
                btnClear.Enabled = true;


                //GradesManager manager = new GradesManager();
                //try
                //{
                //    if (manager.Create(new Grade()
                //    {
                //        StudentName = txtName.Text,
                //        FirstGrade = first_period,
                //        SecondGrade = second_period,
                //        ThirdGrade = third_period,
                //        TotalGrade = final_grade
                        
                //    }))
                //    {
                //        MessageBox.Show("Record Saved");
                //    }
                //    else
                //    {
                //        MessageBox.Show("Record couldn't be saved");
                //    }
                //}
                //catch (Exception ex)
                //{

                //    MessageBox.Show("An error ocurred while saving the record");
                //    return;
                //}
            }
            #endregion
        }
    }
}
