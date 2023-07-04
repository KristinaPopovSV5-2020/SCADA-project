
namespace DatabaseManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.usernameRegister = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordRegister = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmPasswordRegister = new System.Windows.Forms.TextBox();
            this.errorRegister = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // usernameRegister
            // 
            this.usernameRegister.Location = new System.Drawing.Point(207, 81);
            this.usernameRegister.Name = "usernameRegister";
            this.usernameRegister.Size = new System.Drawing.Size(251, 27);
            this.usernameRegister.TabIndex = 1;
            this.usernameRegister.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // passwordRegister
            // 
            this.passwordRegister.Location = new System.Drawing.Point(207, 147);
            this.passwordRegister.Name = "passwordRegister";
            this.passwordRegister.Size = new System.Drawing.Size(251, 27);
            this.passwordRegister.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirm password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // confirmPasswordRegister
            // 
            this.confirmPasswordRegister.Location = new System.Drawing.Point(207, 218);
            this.confirmPasswordRegister.Name = "confirmPasswordRegister";
            this.confirmPasswordRegister.Size = new System.Drawing.Size(251, 27);
            this.confirmPasswordRegister.TabIndex = 5;
            // 
            // errorRegister
            // 
            this.errorRegister.AutoSize = true;
            this.errorRegister.ForeColor = System.Drawing.Color.Red;
            this.errorRegister.Location = new System.Drawing.Point(297, 265);
            this.errorRegister.Name = "errorRegister";
            this.errorRegister.Size = new System.Drawing.Size(0, 20);
            this.errorRegister.TabIndex = 6;
            this.errorRegister.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.errorRegister);
            this.Controls.Add(this.confirmPasswordRegister);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameRegister);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confirmPasswordRegister;
        private System.Windows.Forms.Label errorRegister;
        private System.Windows.Forms.Button button1;
    }
}