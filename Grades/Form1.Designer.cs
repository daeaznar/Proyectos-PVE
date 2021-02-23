
namespace Grades
{
    partial class Grades
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblExercises = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblExam = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtExercises = new System.Windows.Forms.TextBox();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.txtExam = new System.Windows.Forms.TextBox();
            this.lstSecondPeriod = new System.Windows.Forms.ListBox();
            this.lstThirdPeriod = new System.Windows.Forms.ListBox();
            this.lstApproved = new System.Windows.Forms.ListBox();
            this.lstNotApproved = new System.Windows.Forms.ListBox();
            this.lblFirstAverage = new System.Windows.Forms.Label();
            this.lblSecondAverage = new System.Windows.Forms.Label();
            this.lblThirdAverage = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblFailed = new System.Windows.Forms.Label();
            this.lblApproved = new System.Windows.Forms.Label();
            this.lstFirstPeriod = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(43, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblExercises
            // 
            this.lblExercises.AutoSize = true;
            this.lblExercises.Location = new System.Drawing.Point(43, 83);
            this.lblExercises.Name = "lblExercises";
            this.lblExercises.Size = new System.Drawing.Size(71, 20);
            this.lblExercises.TabIndex = 1;
            this.lblExercises.Text = "Exercises:";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(43, 119);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(58, 20);
            this.lblProject.TabIndex = 2;
            this.lblProject.Text = "Project:";
            // 
            // lblExam
            // 
            this.lblExam.AutoSize = true;
            this.lblExam.Location = new System.Drawing.Point(43, 156);
            this.lblExam.Name = "lblExam";
            this.lblExam.Size = new System.Drawing.Size(48, 20);
            this.lblExam.TabIndex = 3;
            this.lblExam.Text = "Exam:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.Location = new System.Drawing.Point(131, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(390, 27);
            this.txtName.TabIndex = 4;
            // 
            // txtExercises
            // 
            this.txtExercises.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtExercises.Location = new System.Drawing.Point(131, 83);
            this.txtExercises.Name = "txtExercises";
            this.txtExercises.Size = new System.Drawing.Size(80, 27);
            this.txtExercises.TabIndex = 5;
            // 
            // txtProject
            // 
            this.txtProject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtProject.Location = new System.Drawing.Point(131, 119);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(80, 27);
            this.txtProject.TabIndex = 6;
            // 
            // txtExam
            // 
            this.txtExam.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtExam.Location = new System.Drawing.Point(131, 156);
            this.txtExam.Name = "txtExam";
            this.txtExam.Size = new System.Drawing.Size(80, 27);
            this.txtExam.TabIndex = 7;
            // 
            // lstSecondPeriod
            // 
            this.lstSecondPeriod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lstSecondPeriod.FormattingEnabled = true;
            this.lstSecondPeriod.ItemHeight = 20;
            this.lstSecondPeriod.Location = new System.Drawing.Point(30, 387);
            this.lstSecondPeriod.Name = "lstSecondPeriod";
            this.lstSecondPeriod.Size = new System.Drawing.Size(491, 124);
            this.lstSecondPeriod.TabIndex = 9;
            // 
            // lstThirdPeriod
            // 
            this.lstThirdPeriod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lstThirdPeriod.FormattingEnabled = true;
            this.lstThirdPeriod.ItemHeight = 20;
            this.lstThirdPeriod.Location = new System.Drawing.Point(30, 552);
            this.lstThirdPeriod.Name = "lstThirdPeriod";
            this.lstThirdPeriod.Size = new System.Drawing.Size(491, 124);
            this.lstThirdPeriod.TabIndex = 10;
            // 
            // lstApproved
            // 
            this.lstApproved.BackColor = System.Drawing.Color.PaleGreen;
            this.lstApproved.FormattingEnabled = true;
            this.lstApproved.ItemHeight = 20;
            this.lstApproved.Location = new System.Drawing.Point(565, 147);
            this.lstApproved.Name = "lstApproved";
            this.lstApproved.Size = new System.Drawing.Size(358, 244);
            this.lstApproved.TabIndex = 11;
            // 
            // lstNotApproved
            // 
            this.lstNotApproved.BackColor = System.Drawing.Color.LightCoral;
            this.lstNotApproved.FormattingEnabled = true;
            this.lstNotApproved.ItemHeight = 20;
            this.lstNotApproved.Location = new System.Drawing.Point(565, 432);
            this.lstNotApproved.Name = "lstNotApproved";
            this.lstNotApproved.Size = new System.Drawing.Size(358, 244);
            this.lstNotApproved.TabIndex = 12;
            // 
            // lblFirstAverage
            // 
            this.lblFirstAverage.AutoSize = true;
            this.lblFirstAverage.Location = new System.Drawing.Point(26, 351);
            this.lblFirstAverage.Name = "lblFirstAverage";
            this.lblFirstAverage.Size = new System.Drawing.Size(144, 20);
            this.lblFirstAverage.TabIndex = 13;
            this.lblFirstAverage.Text = "First Period Average:";
            // 
            // lblSecondAverage
            // 
            this.lblSecondAverage.AutoSize = true;
            this.lblSecondAverage.Location = new System.Drawing.Point(26, 514);
            this.lblSecondAverage.Name = "lblSecondAverage";
            this.lblSecondAverage.Size = new System.Drawing.Size(166, 20);
            this.lblSecondAverage.TabIndex = 14;
            this.lblSecondAverage.Text = "Second Period Average:";
            // 
            // lblThirdAverage
            // 
            this.lblThirdAverage.AutoSize = true;
            this.lblThirdAverage.Location = new System.Drawing.Point(26, 679);
            this.lblThirdAverage.Name = "lblThirdAverage";
            this.lblThirdAverage.Size = new System.Drawing.Size(151, 20);
            this.lblThirdAverage.TabIndex = 15;
            this.lblThirdAverage.Text = "Third Period Average:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(239, 138);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(164, 45);
            this.btnCalculate.TabIndex = 16;
            this.btnCalculate.Text = "Calculate Grade";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblFailed
            // 
            this.lblFailed.AutoSize = true;
            this.lblFailed.Location = new System.Drawing.Point(678, 679);
            this.lblFailed.Name = "lblFailed";
            this.lblFailed.Size = new System.Drawing.Size(116, 20);
            this.lblFailed.TabIndex = 17;
            this.lblFailed.Text = "NOT APPROVED";
            // 
            // lblApproved
            // 
            this.lblApproved.AutoSize = true;
            this.lblApproved.Location = new System.Drawing.Point(712, 392);
            this.lblApproved.Name = "lblApproved";
            this.lblApproved.Size = new System.Drawing.Size(83, 20);
            this.lblApproved.TabIndex = 18;
            this.lblApproved.Text = "APPROVED";
            // 
            // lstFirstPeriod
            // 
            this.lstFirstPeriod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lstFirstPeriod.FormattingEnabled = true;
            this.lstFirstPeriod.ItemHeight = 20;
            this.lstFirstPeriod.Location = new System.Drawing.Point(30, 224);
            this.lstFirstPeriod.Name = "lstFirstPeriod";
            this.lstFirstPeriod.Size = new System.Drawing.Size(491, 124);
            this.lstFirstPeriod.TabIndex = 19;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(428, 138);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 45);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Grades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(947, 717);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstFirstPeriod);
            this.Controls.Add(this.lblApproved);
            this.Controls.Add(this.lblFailed);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblThirdAverage);
            this.Controls.Add(this.lblSecondAverage);
            this.Controls.Add(this.lblFirstAverage);
            this.Controls.Add(this.lstNotApproved);
            this.Controls.Add(this.lstApproved);
            this.Controls.Add(this.lstThirdPeriod);
            this.Controls.Add(this.lstSecondPeriod);
            this.Controls.Add(this.txtExam);
            this.Controls.Add(this.txtProject);
            this.Controls.Add(this.txtExercises);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblExam);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.lblExercises);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Grades";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblExercises;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblExam;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtExercises;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.TextBox txtExam;
        private System.Windows.Forms.ListBox lstSecondPeriod;
        private System.Windows.Forms.ListBox lstThirdPeriod;
        private System.Windows.Forms.ListBox lstApproved;
        private System.Windows.Forms.ListBox lstNotApproved;
        private System.Windows.Forms.Label lblFirstAverage;
        private System.Windows.Forms.Label lblSecondAverage;
        private System.Windows.Forms.Label lblThirdAverage;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblFailed;
        private System.Windows.Forms.Label lblApproved;
        private System.Windows.Forms.ListBox lstFirstPeriod;
        private System.Windows.Forms.Button btnClear;
    }
}

