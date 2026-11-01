namespace FinalProject
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtPW = new TextBox();
            btnlogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(129, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 65);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(12, 92);
            label2.Name = "label2";
            label2.Size = new Size(147, 38);
            label2.TabIndex = 0;
            label2.Text = "UserName";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(12, 173);
            label3.Name = "label3";
            label3.Size = new Size(132, 38);
            label3.TabIndex = 0;
            label3.Text = "Password";
            label3.Click += label1_Click;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(186, 92);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(234, 45);
            txtUsername.TabIndex = 1;
            // 
            // txtPW
            // 
            txtPW.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPW.Location = new Point(186, 166);
            txtPW.Name = "txtPW";
            txtPW.PasswordChar = '*';
            txtPW.Size = new Size(234, 45);
            txtPW.TabIndex = 1;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(143, 258);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(172, 34);
            btnlogin.TabIndex = 2;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 336);
            Controls.Add(btnlogin);
            Controls.Add(txtPW);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login System";
            WindowState = FormWindowState.Minimized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPW;
        private Button btnlogin;
    }
}
