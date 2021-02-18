
namespace ImagesWindow
{
    partial class Register
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
            this.lblGamer = new System.Windows.Forms.Label();
            this.txtGamer = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpConsoles = new System.Windows.Forms.GroupBox();
            this.rdbXbox = new System.Windows.Forms.RadioButton();
            this.rdbPlay = new System.Windows.Forms.RadioButton();
            this.rdbSwitch = new System.Windows.Forms.RadioButton();
            this.grpConsoles.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGamer
            // 
            this.lblGamer.AutoSize = true;
            this.lblGamer.Location = new System.Drawing.Point(65, 54);
            this.lblGamer.Name = "lblGamer";
            this.lblGamer.Size = new System.Drawing.Size(80, 20);
            this.lblGamer.TabIndex = 0;
            this.lblGamer.Text = "Gamer Tag";
            // 
            // txtGamer
            // 
            this.txtGamer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGamer.Location = new System.Drawing.Point(69, 86);
            this.txtGamer.Name = "txtGamer";
            this.txtGamer.Size = new System.Drawing.Size(406, 27);
            this.txtGamer.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(338, 359);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 48);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Register";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpConsoles
            // 
            this.grpConsoles.Controls.Add(this.rdbXbox);
            this.grpConsoles.Controls.Add(this.rdbPlay);
            this.grpConsoles.Controls.Add(this.rdbSwitch);
            this.grpConsoles.Location = new System.Drawing.Point(69, 151);
            this.grpConsoles.Name = "grpConsoles";
            this.grpConsoles.Size = new System.Drawing.Size(406, 177);
            this.grpConsoles.TabIndex = 3;
            this.grpConsoles.TabStop = false;
            this.grpConsoles.Text = "Gaming Console";
            // 
            // rdbXbox
            // 
            this.rdbXbox.AutoSize = true;
            this.rdbXbox.Location = new System.Drawing.Point(25, 130);
            this.rdbXbox.Name = "rdbXbox";
            this.rdbXbox.Size = new System.Drawing.Size(117, 24);
            this.rdbXbox.TabIndex = 2;
            this.rdbXbox.TabStop = true;
            this.rdbXbox.Text = "Xbox Series X";
            this.rdbXbox.UseVisualStyleBackColor = true;
            // 
            // rdbPlay
            // 
            this.rdbPlay.AutoSize = true;
            this.rdbPlay.Location = new System.Drawing.Point(25, 86);
            this.rdbPlay.Name = "rdbPlay";
            this.rdbPlay.Size = new System.Drawing.Size(113, 24);
            this.rdbPlay.TabIndex = 1;
            this.rdbPlay.TabStop = true;
            this.rdbPlay.Text = "PlayStation 5";
            this.rdbPlay.UseVisualStyleBackColor = true;
            // 
            // rdbSwitch
            // 
            this.rdbSwitch.AutoSize = true;
            this.rdbSwitch.Location = new System.Drawing.Point(25, 41);
            this.rdbSwitch.Name = "rdbSwitch";
            this.rdbSwitch.Size = new System.Drawing.Size(136, 24);
            this.rdbSwitch.TabIndex = 0;
            this.rdbSwitch.TabStop = true;
            this.rdbSwitch.Text = "Nintendo Switch";
            this.rdbSwitch.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(544, 435);
            this.Controls.Add(this.grpConsoles);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtGamer);
            this.Controls.Add(this.lblGamer);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.grpConsoles.ResumeLayout(false);
            this.grpConsoles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGamer;
        private System.Windows.Forms.TextBox txtGamer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpConsoles;
        private System.Windows.Forms.RadioButton rdbXbox;
        private System.Windows.Forms.RadioButton rdbPlay;
        private System.Windows.Forms.RadioButton rdbSwitch;
    }
}