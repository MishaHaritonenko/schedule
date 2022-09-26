namespace schedule
{
    partial class AddScheduleEntryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.udBegin = new System.Windows.Forms.NumericUpDown();
            this.udEnd = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.udBegin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teacher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "begin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "end";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(80, 107);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(210, 31);
            this.txtSubject.TabIndex = 4;
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(81, 205);
            this.txtTeacher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Size = new System.Drawing.Size(208, 31);
            this.txtTeacher.TabIndex = 4;
            // 
            // udBegin
            // 
            this.udBegin.Location = new System.Drawing.Point(401, 107);
            this.udBegin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.udBegin.Name = "udBegin";
            this.udBegin.Size = new System.Drawing.Size(100, 31);
            this.udBegin.TabIndex = 5;
            // 
            // udEnd
            // 
            this.udEnd.Location = new System.Drawing.Point(401, 205);
            this.udEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.udEnd.Name = "udEnd";
            this.udEnd.Size = new System.Drawing.Size(100, 31);
            this.udEnd.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 343);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(394, 343);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Day";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(80, 43);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(209, 31);
            this.txtDay.TabIndex = 9;
            // 
            // AddScheduleEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 432);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.udEnd);
            this.Controls.Add(this.udBegin);
            this.Controls.Add(this.txtTeacher);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddScheduleEntryForm";
            this.Text = "AddScheduleEntryForm";
            this.Load += new System.EventHandler(this.AddScheduleEntryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.udBegin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSubject;
        private TextBox txtTeacher;
        private NumericUpDown udBegin;
        private NumericUpDown udEnd;
        private Button button1;
        private Button button2;
        private Label label5;
        private TextBox txtDay;
    }
}