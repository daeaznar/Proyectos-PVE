
namespace SegundoExamenParcial
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDance = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbDance = new System.Windows.Forms.ComboBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.dtgChampionship = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgChampionship)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(48, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(48, 102);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(34, 20);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "City";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(48, 174);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(57, 20);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Gender";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(48, 244);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(69, 20);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category";
            // 
            // lblDance
            // 
            this.lblDance.AutoSize = true;
            this.lblDance.Location = new System.Drawing.Point(48, 313);
            this.lblDance.Name = "lblDance";
            this.lblDance.Size = new System.Drawing.Size(51, 20);
            this.lblDance.TabIndex = 4;
            this.lblDance.Text = "Dance";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(48, 378);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(46, 20);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Score";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.Location = new System.Drawing.Point(52, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(395, 27);
            this.txtName.TabIndex = 6;
            // 
            // cmbCity
            // 
            this.cmbCity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Items.AddRange(new object[] {
            "Queretaro",
            "Guadalajara",
            "CDMX"});
            this.cmbCity.Location = new System.Drawing.Point(52, 126);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(226, 28);
            this.cmbCity.TabIndex = 7;
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(52, 197);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(226, 28);
            this.cmbGender.TabIndex = 8;
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Beginner",
            "Novice",
            "Prizewinner",
            "Preliminary Championship",
            "Open Championship"});
            this.cmbCategory.Location = new System.Drawing.Point(52, 267);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(226, 28);
            this.cmbCategory.TabIndex = 9;
            // 
            // cmbDance
            // 
            this.cmbDance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbDance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDance.FormattingEnabled = true;
            this.cmbDance.Items.AddRange(new object[] {
            "Reel",
            "Light Jig",
            "Single Jig",
            "Slip Jig",
            "Treble Jig",
            "Hornpipe"});
            this.cmbDance.Location = new System.Drawing.Point(52, 336);
            this.cmbDance.Name = "cmbDance";
            this.cmbDance.Size = new System.Drawing.Size(226, 28);
            this.cmbDance.TabIndex = 10;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(52, 401);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(84, 27);
            this.txtScore.TabIndex = 11;
            // 
            // dtgChampionship
            // 
            this.dtgChampionship.AllowUserToAddRows = false;
            this.dtgChampionship.AllowUserToDeleteRows = false;
            this.dtgChampionship.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgChampionship.Location = new System.Drawing.Point(341, 135);
            this.dtgChampionship.Name = "dtgChampionship";
            this.dtgChampionship.ReadOnly = true;
            this.dtgChampionship.Size = new System.Drawing.Size(756, 424);
            this.dtgChampionship.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(52, 449);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(226, 43);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add Register";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(52, 516);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(226, 43);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Interval = 5000;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1159, 622);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtgChampionship);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.cmbDance);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblDance);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Championship Scores";
            ((System.ComponentModel.ISupportInitialize)(this.dtgChampionship)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDance;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbDance;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.DataGridView dtgChampionship;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Timer tmrUpdate;
    }
}

