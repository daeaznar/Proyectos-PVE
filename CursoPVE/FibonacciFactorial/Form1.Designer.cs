
namespace FibonacciFactorial
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
            this.lblText = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblFibonacci = new System.Windows.Forms.Label();
            this.lblFactorial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(35, 29);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(70, 20);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Number: ";
            // 
            // txtNumber
            // 
            this.txtNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNumber.Location = new System.Drawing.Point(111, 26);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(187, 27);
            this.txtNumber.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(327, 25);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(85, 28);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFibonacci
            // 
            this.lblFibonacci.AutoSize = true;
            this.lblFibonacci.Location = new System.Drawing.Point(35, 87);
            this.lblFibonacci.Name = "lblFibonacci";
            this.lblFibonacci.Size = new System.Drawing.Size(0, 20);
            this.lblFibonacci.TabIndex = 3;
            // 
            // lblFactorial
            // 
            this.lblFactorial.AutoSize = true;
            this.lblFactorial.Location = new System.Drawing.Point(35, 120);
            this.lblFactorial.Name = "lblFactorial";
            this.lblFactorial.Size = new System.Drawing.Size(0, 20);
            this.lblFactorial.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(468, 156);
            this.Controls.Add(this.lblFactorial);
            this.Controls.Add(this.lblFibonacci);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblText);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fibonacci Factorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblFibonacci;
        private System.Windows.Forms.Label lblFactorial;
    }
}

