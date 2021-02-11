
namespace ImagesWindow
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
            this.tmrSequence = new System.Windows.Forms.Timer(this.components);
            this.pctQuestion = new System.Windows.Forms.PictureBox();
            this.pctNewWindow = new System.Windows.Forms.PictureBox();
            this.pctPlay = new System.Windows.Forms.PictureBox();
            this.pctSchedule = new System.Windows.Forms.PictureBox();
            this.pctPause = new System.Windows.Forms.PictureBox();
            this.pctThird = new System.Windows.Forms.PictureBox();
            this.pctSecond = new System.Windows.Forms.PictureBox();
            this.pctFirst = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNewWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctThird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFirst)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrSequence
            // 
            this.tmrSequence.Enabled = true;
            this.tmrSequence.Interval = 1000;
            this.tmrSequence.Tick += new System.EventHandler(this.tmrSequence_Tick);
            // 
            // pctQuestion
            // 
            this.pctQuestion.Image = global::ImagesWindow.Properties.Resources.question;
            this.pctQuestion.Location = new System.Drawing.Point(742, 34);
            this.pctQuestion.Name = "pctQuestion";
            this.pctQuestion.Size = new System.Drawing.Size(159, 145);
            this.pctQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctQuestion.TabIndex = 7;
            this.pctQuestion.TabStop = false;
            this.pctQuestion.Click += new System.EventHandler(this.pctQuestion_Click);
            // 
            // pctNewWindow
            // 
            this.pctNewWindow.Image = global::ImagesWindow.Properties.Resources._new;
            this.pctNewWindow.Location = new System.Drawing.Point(430, 374);
            this.pctNewWindow.Name = "pctNewWindow";
            this.pctNewWindow.Size = new System.Drawing.Size(119, 86);
            this.pctNewWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctNewWindow.TabIndex = 6;
            this.pctNewWindow.TabStop = false;
            this.pctNewWindow.Click += new System.EventHandler(this.pctNewWindow_Click);
            // 
            // pctPlay
            // 
            this.pctPlay.Image = global::ImagesWindow.Properties.Resources.play;
            this.pctPlay.Location = new System.Drawing.Point(410, 208);
            this.pctPlay.Name = "pctPlay";
            this.pctPlay.Size = new System.Drawing.Size(139, 111);
            this.pctPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctPlay.TabIndex = 5;
            this.pctPlay.TabStop = false;
            this.pctPlay.Click += new System.EventHandler(this.pctPlay_Click);
            // 
            // pctSchedule
            // 
            this.pctSchedule.Image = global::ImagesWindow.Properties.Resources.schedule;
            this.pctSchedule.Location = new System.Drawing.Point(169, 372);
            this.pctSchedule.Name = "pctSchedule";
            this.pctSchedule.Size = new System.Drawing.Size(119, 88);
            this.pctSchedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctSchedule.TabIndex = 4;
            this.pctSchedule.TabStop = false;
            this.pctSchedule.Click += new System.EventHandler(this.pctSchedule_Click);
            // 
            // pctPause
            // 
            this.pctPause.Image = global::ImagesWindow.Properties.Resources.pause;
            this.pctPause.Location = new System.Drawing.Point(169, 208);
            this.pctPause.Name = "pctPause";
            this.pctPause.Size = new System.Drawing.Size(139, 111);
            this.pctPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctPause.TabIndex = 3;
            this.pctPause.TabStop = false;
            this.pctPause.Click += new System.EventHandler(this.pctPause_Click);
            // 
            // pctThird
            // 
            this.pctThird.Image = global::ImagesWindow.Properties.Resources.Yoshi;
            this.pctThird.Location = new System.Drawing.Point(494, 34);
            this.pctThird.Name = "pctThird";
            this.pctThird.Size = new System.Drawing.Size(159, 145);
            this.pctThird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctThird.TabIndex = 2;
            this.pctThird.TabStop = false;
            this.pctThird.Tag = "3";
            // 
            // pctSecond
            // 
            this.pctSecond.Image = global::ImagesWindow.Properties.Resources.Luigi;
            this.pctSecond.Location = new System.Drawing.Point(279, 34);
            this.pctSecond.Name = "pctSecond";
            this.pctSecond.Size = new System.Drawing.Size(159, 145);
            this.pctSecond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctSecond.TabIndex = 1;
            this.pctSecond.TabStop = false;
            this.pctSecond.Tag = "2";
            // 
            // pctFirst
            // 
            this.pctFirst.Image = global::ImagesWindow.Properties.Resources.Mario;
            this.pctFirst.Location = new System.Drawing.Point(66, 34);
            this.pctFirst.Name = "pctFirst";
            this.pctFirst.Size = new System.Drawing.Size(159, 145);
            this.pctFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctFirst.TabIndex = 0;
            this.pctFirst.TabStop = false;
            this.pctFirst.Tag = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(956, 514);
            this.Controls.Add(this.pctQuestion);
            this.Controls.Add(this.pctNewWindow);
            this.Controls.Add(this.pctPlay);
            this.Controls.Add(this.pctSchedule);
            this.Controls.Add(this.pctPause);
            this.Controls.Add(this.pctThird);
            this.Controls.Add(this.pctSecond);
            this.Controls.Add(this.pctFirst);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Images";
            ((System.ComponentModel.ISupportInitialize)(this.pctQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNewWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctThird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFirst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctFirst;
        private System.Windows.Forms.PictureBox pctSecond;
        private System.Windows.Forms.PictureBox pctThird;
        private System.Windows.Forms.PictureBox pctPlay;
        private System.Windows.Forms.PictureBox pctSchedule;
        private System.Windows.Forms.PictureBox pctPause;
        private System.Windows.Forms.PictureBox pctNewWindow;
        private System.Windows.Forms.Timer tmrSequence;
        private System.Windows.Forms.PictureBox pctQuestion;
    }
}

