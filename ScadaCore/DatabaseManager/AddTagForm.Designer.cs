
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
            this.scanOn = new System.Windows.Forms.CheckBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.lowLimit = new System.Windows.Forms.TextBox();
            this.highLimit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.units = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.realTimeDriverOn = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tag type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Scan time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Low limit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 239);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "High limit";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(91, 154);
            this.description.Margin = new System.Windows.Forms.Padding(2);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(182, 31);
            this.description.TabIndex = 7;
            // 
            // scanTime
            // 
            this.scanTime.Location = new System.Drawing.Point(307, 154);
            this.scanTime.Margin = new System.Windows.Forms.Padding(2);
            this.scanTime.Name = "scanTime";
            this.scanTime.Size = new System.Drawing.Size(182, 31);
            this.scanTime.TabIndex = 8;
            // 
            // scanOn
            // 
            this.scanOn.AutoSize = true;
            this.scanOn.Location = new System.Drawing.Point(400, 326);
            this.scanOn.Margin = new System.Windows.Forms.Padding(2);
            this.scanOn.Name = "scanOn";
            this.scanOn.Size = new System.Drawing.Size(107, 29);
            this.scanOn.TabIndex = 9;
            this.scanOn.Text = "Scan ON";
            this.scanOn.UseVisualStyleBackColor = true;
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Digital Output",
            "Digital Input",
            "Analog Output",
            "Analog Input"});
            this.typeComboBox.Location = new System.Drawing.Point(343, 48);
            this.typeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(182, 33);
            this.typeComboBox.TabIndex = 10;
            // 
            // lowLimit
            // 
            this.lowLimit.Location = new System.Drawing.Point(92, 267);
            this.lowLimit.Margin = new System.Windows.Forms.Padding(2);
            this.lowLimit.Name = "lowLimit";
            this.lowLimit.Size = new System.Drawing.Size(182, 31);
            this.lowLimit.TabIndex = 11;
            // 
            // highLimit
            // 
            this.highLimit.Location = new System.Drawing.Point(307, 267);
            this.highLimit.Margin = new System.Windows.Forms.Padding(2);
            this.highLimit.Name = "highLimit";
            this.highLimit.Size = new System.Drawing.Size(182, 31);
            this.highLimit.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Units";
            // 
            // units
            // 
            this.units.Location = new System.Drawing.Point(525, 267);
            this.units.Margin = new System.Windows.Forms.Padding(2);
            this.units.Name = "units";
            this.units.Size = new System.Drawing.Size(182, 31);
            this.units.TabIndex = 14;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(608, 356);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(163, 72);
            this.saveBtn.TabIndex = 15;
            this.saveBtn.Text = "save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(525, 154);
            this.address.Margin = new System.Windows.Forms.Padding(2);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(182, 31);
            this.address.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(529, 125);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "I/O address";
            // 
            // realTimeDriverOn
            // 
            this.realTimeDriverOn.AutoSize = true;
            this.realTimeDriverOn.Location = new System.Drawing.Point(283, 326);
            this.realTimeDriverOn.Name = "realTimeDriverOn";
            this.realTimeDriverOn.Size = new System.Drawing.Size(101, 29);
            this.realTimeDriverOn.TabIndex = 18;
            this.realTimeDriverOn.Text = "RTU ON";
            this.realTimeDriverOn.UseVisualStyleBackColor = true;
            // 
            // AddTagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.realTimeDriverOn);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.units);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.highLimit);
            this.Controls.Add(this.lowLimit);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.scanOn);
            this.Controls.Add(this.scanTime);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.CheckBox scanOn;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox lowLimit;
        private System.Windows.Forms.TextBox highLimit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox units;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox realTimeDriverOn;
    }
}