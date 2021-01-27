
namespace CharacterCount
{
    partial class charCount
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
            this.lblText = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblVowels = new System.Windows.Forms.Label();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.lblConsonants = new System.Windows.Forms.Label();
            this.lblOthers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(30, 26);
            this.lblText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(39, 20);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Text:";
            // 
            // txtText
            // 
            this.txtText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtText.Location = new System.Drawing.Point(76, 23);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(263, 27);
            this.txtText.TabIndex = 1;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(253, 70);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(86, 34);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblVowels
            // 
            this.lblVowels.AutoSize = true;
            this.lblVowels.Location = new System.Drawing.Point(30, 136);
            this.lblVowels.Name = "lblVowels";
            this.lblVowels.Size = new System.Drawing.Size(64, 20);
            this.lblVowels.TabIndex = 3;
            this.lblVowels.Text = "-Vowels:";
            this.lblVowels.UseMnemonic = false;
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Location = new System.Drawing.Point(30, 222);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(78, 20);
            this.lblNumbers.TabIndex = 4;
            this.lblNumbers.Text = "-Numbers:";
            this.lblNumbers.UseMnemonic = false;
            // 
            // lblConsonants
            // 
            this.lblConsonants.AutoSize = true;
            this.lblConsonants.Location = new System.Drawing.Point(30, 180);
            this.lblConsonants.Name = "lblConsonants";
            this.lblConsonants.Size = new System.Drawing.Size(94, 20);
            this.lblConsonants.TabIndex = 5;
            this.lblConsonants.Text = "-Consonants:";
            this.lblConsonants.UseMnemonic = false;
            // 
            // lblOthers
            // 
            this.lblOthers.AutoSize = true;
            this.lblOthers.Location = new System.Drawing.Point(249, 222);
            this.lblOthers.Name = "lblOthers";
            this.lblOthers.Size = new System.Drawing.Size(0, 20);
            this.lblOthers.TabIndex = 6;
            // 
            // charCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(376, 268);
            this.Controls.Add(this.lblOthers);
            this.Controls.Add(this.lblConsonants);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.lblVowels);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.lblText);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "charCount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character Count";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblVowels;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Label lblConsonants;
        private System.Windows.Forms.Label lblOthers;
    }
}

