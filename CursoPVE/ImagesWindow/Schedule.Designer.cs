
namespace ImagesWindow
{
    partial class Schedule
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
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dttEvent = new System.Windows.Forms.DateTimePicker();
            this.dtgEvents = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(48, 38);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(58, 20);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "Subject";
            // 
            // txtSubject
            // 
            this.txtSubject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSubject.Location = new System.Drawing.Point(52, 61);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(287, 27);
            this.txtSubject.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(48, 95);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 20);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(52, 160);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(287, 42);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Event";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dttEvent
            // 
            this.dttEvent.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dttEvent.Location = new System.Drawing.Point(52, 118);
            this.dttEvent.Name = "dttEvent";
            this.dttEvent.Size = new System.Drawing.Size(287, 27);
            this.dttEvent.TabIndex = 4;
            // 
            // dtgEvents
            // 
            this.dtgEvents.AllowUserToAddRows = false;
            this.dtgEvents.AllowUserToDeleteRows = false;
            this.dtgEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEvents.Location = new System.Drawing.Point(386, 61);
            this.dtgEvents.Name = "dtgEvents";
            this.dtgEvents.ReadOnly = true;
            this.dtgEvents.Size = new System.Drawing.Size(390, 201);
            this.dtgEvents.TabIndex = 5;
            this.dtgEvents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEvents_CellClick);
            this.dtgEvents.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgEvents_MouseClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(52, 220);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(287, 42);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(828, 361);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dtgEvents);
            this.Controls.Add(this.dttEvent);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblSubject);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Schedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.dtgEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dttEvent;
        private System.Windows.Forms.DataGridView dtgEvents;
        private System.Windows.Forms.Button btnUpdate;
    }
}