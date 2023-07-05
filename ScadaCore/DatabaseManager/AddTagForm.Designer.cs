
namespace DatabaseManager
{
    partial class AddTagForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.scanTime = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.lowLimit = new System.Windows.Forms.TextBox();
            this.highLimit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tag type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Scan time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Low limit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 262);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "High limit";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(194, 74);
            this.description.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(146, 27);
            this.description.TabIndex = 7;
            // 
            // scanTime
            // 
            this.scanTime.Location = new System.Drawing.Point(194, 117);
            this.scanTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scanTime.Name = "scanTime";
            this.scanTime.Size = new System.Drawing.Size(146, 27);
            this.scanTime.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(218, 166);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 24);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Scan ON";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Digital",
            "Analog"});
            this.typeComboBox.Location = new System.Drawing.Point(194, 30);
            this.typeComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(146, 28);
            this.typeComboBox.TabIndex = 10;
            // 
            // lowLimit
            // 
            this.lowLimit.Location = new System.Drawing.Point(194, 218);
            this.lowLimit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lowLimit.Name = "lowLimit";
            this.lowLimit.Size = new System.Drawing.Size(146, 27);
            this.lowLimit.TabIndex = 11;
            // 
            // highLimit
            // 
            this.highLimit.Location = new System.Drawing.Point(194, 257);
            this.highLimit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.highLimit.Name = "highLimit";
            this.highLimit.Size = new System.Drawing.Size(146, 27);
            this.highLimit.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 302);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Units";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 302);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 27);
            this.textBox1.TabIndex = 14;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(446, 282);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(106, 44);
            this.saveBtn.TabIndex = 15;
            this.saveBtn.Text = "save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // AddTagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.highLimit);
            this.Controls.Add(this.lowLimit);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.scanTime);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddTagForm";
            this.Text = "AddTagForm";
            this.Load += new System.EventHandler(this.AddTagForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox scanTime;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox lowLimit;
        private System.Windows.Forms.TextBox highLimit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button saveBtn;
    }
}