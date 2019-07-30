namespace WindowsFormsApp
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtRgsPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRgsEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRgsName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRgsSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRgsRepeatPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(150, 279);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(136, 30);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtRgsPass
            // 
            this.txtRgsPass.Location = new System.Drawing.Point(243, 119);
            this.txtRgsPass.Name = "txtRgsPass";
            this.txtRgsPass.Size = new System.Drawing.Size(136, 20);
            this.txtRgsPass.TabIndex = 9;
            this.txtRgsPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password :";
            // 
            // txtRgsEmail
            // 
            this.txtRgsEmail.Location = new System.Drawing.Point(39, 54);
            this.txtRgsEmail.Name = "txtRgsEmail";
            this.txtRgsEmail.Size = new System.Drawing.Size(136, 20);
            this.txtRgsEmail.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "User Email :";
            // 
            // txtRgsName
            // 
            this.txtRgsName.Location = new System.Drawing.Point(39, 119);
            this.txtRgsName.Name = "txtRgsName";
            this.txtRgsName.Size = new System.Drawing.Size(136, 20);
            this.txtRgsName.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Name :";
            // 
            // txtRgsSurname
            // 
            this.txtRgsSurname.Location = new System.Drawing.Point(243, 54);
            this.txtRgsSurname.Name = "txtRgsSurname";
            this.txtRgsSurname.Size = new System.Drawing.Size(136, 20);
            this.txtRgsSurname.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Surname :";
            // 
            // txtRgsRepeatPass
            // 
            this.txtRgsRepeatPass.Location = new System.Drawing.Point(150, 199);
            this.txtRgsRepeatPass.Name = "txtRgsRepeatPass";
            this.txtRgsRepeatPass.Size = new System.Drawing.Size(136, 20);
            this.txtRgsRepeatPass.TabIndex = 16;
            this.txtRgsRepeatPass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Repeat Password :";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 347);
            this.Controls.Add(this.txtRgsRepeatPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRgsSurname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRgsName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtRgsPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRgsEmail);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtRgsPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRgsEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRgsName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRgsSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRgsRepeatPass;
        private System.Windows.Forms.Label label5;
    }
}