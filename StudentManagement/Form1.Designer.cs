namespace StudentManagement_
{
    partial class frmStudent : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblStudentId = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new Point(35, 36);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(94, 20);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Mã sinh viên:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(145, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // frmStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1594, 453);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(lblStudentId);
            Name = "frmStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm quản lý sinh viên";
      
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentId;
        private TextBox textBox1;
        private Label label1;
    }
}
