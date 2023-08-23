
namespace DatabaseManager
{
    partial class DbManagerForm
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
            this.addTag = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewTags = new System.Windows.Forms.ListView();
            this.deleteTagBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewInputTags = new System.Windows.Forms.ListView();
            this.onOffBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tagNameAlarm = new System.Windows.Forms.Label();
            this.listViewAlarms = new System.Windows.Forms.ListView();
            this.buttonNewAlarm = new System.Windows.Forms.Button();
            this.buttonDeleteAlarm = new System.Windows.Forms.Button();
            this.deleteInputTag = new System.Windows.Forms.Button();
            this.buttonAlarms = new System.Windows.Forms.Button();
            this.buttonNewTag2 = new System.Windows.Forms.Button();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addTag
            // 
            this.addTag.Location = new System.Drawing.Point(332, 46);
            this.addTag.Margin = new System.Windows.Forms.Padding(2);
            this.addTag.Name = "addTag";
            this.addTag.Size = new System.Drawing.Size(164, 36);
            this.addTag.TabIndex = 1;
            this.addTag.Text = "+ New Tag";
            this.addTag.UseVisualStyleBackColor = true;
            this.addTag.Click += new System.EventHandler(this.addTag_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Output Tags";
            // 
            // listViewTags
            // 
            this.listViewTags.HideSelection = false;
            this.listViewTags.Location = new System.Drawing.Point(51, 87);
            this.listViewTags.Name = "listViewTags";
            this.listViewTags.Size = new System.Drawing.Size(445, 229);
            this.listViewTags.TabIndex = 3;
            this.listViewTags.UseCompatibleStateImageBehavior = false;
            // 
            // deleteTagBtn
            // 
            this.deleteTagBtn.Location = new System.Drawing.Point(332, 322);
            this.deleteTagBtn.Name = "deleteTagBtn";
            this.deleteTagBtn.Size = new System.Drawing.Size(164, 36);
            this.deleteTagBtn.TabIndex = 4;
            this.deleteTagBtn.Text = "x Delete Tag";
            this.deleteTagBtn.UseVisualStyleBackColor = true;
            this.deleteTagBtn.Click += new System.EventHandler(this.deleteTagBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Input Tags";
            // 
            // listViewInputTags
            // 
            this.listViewInputTags.HideSelection = false;
            this.listViewInputTags.Location = new System.Drawing.Point(556, 87);
            this.listViewInputTags.Name = "listViewInputTags";
            this.listViewInputTags.Size = new System.Drawing.Size(458, 229);
            this.listViewInputTags.TabIndex = 6;
            this.listViewInputTags.UseCompatibleStateImageBehavior = false;
            this.listViewInputTags.SelectedIndexChanged += new System.EventHandler(this.listViewInputTags_SelectedIndexChanged_1);
            // 
            // onOffBtn
            // 
            this.onOffBtn.Location = new System.Drawing.Point(556, 322);
            this.onOffBtn.Margin = new System.Windows.Forms.Padding(2);
            this.onOffBtn.Name = "onOffBtn";
            this.onOffBtn.Size = new System.Drawing.Size(134, 40);
            this.onOffBtn.TabIndex = 7;
            this.onOffBtn.Text = "ON/OFF";
            this.onOffBtn.UseVisualStyleBackColor = true;
            this.onOffBtn.Click += new System.EventHandler(this.onOffBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(51, 321);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(128, 37);
            this.updateBtn.TabIndex = 8;
            this.updateBtn.Text = "Update Value";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "ALARMS for tag:";
            // 
            // tagNameAlarm
            // 
            this.tagNameAlarm.AutoSize = true;
            this.tagNameAlarm.Location = new System.Drawing.Point(183, 415);
            this.tagNameAlarm.Name = "tagNameAlarm";
            this.tagNameAlarm.Size = new System.Drawing.Size(124, 20);
            this.tagNameAlarm.TabIndex = 13;
            this.tagNameAlarm.Text = "No tag selected.";
            // 
            // listViewAlarms
            // 
            this.listViewAlarms.HideSelection = false;
            this.listViewAlarms.Location = new System.Drawing.Point(51, 443);
            this.listViewAlarms.Name = "listViewAlarms";
            this.listViewAlarms.Size = new System.Drawing.Size(586, 165);
            this.listViewAlarms.TabIndex = 14;
            this.listViewAlarms.UseCompatibleStateImageBehavior = false;
            this.listViewAlarms.SelectedIndexChanged += new System.EventHandler(this.listViewAlarms_SelectedIndexChanged);
            // 
            // buttonNewAlarm
            // 
            this.buttonNewAlarm.Location = new System.Drawing.Point(656, 443);
            this.buttonNewAlarm.Name = "buttonNewAlarm";
            this.buttonNewAlarm.Size = new System.Drawing.Size(134, 40);
            this.buttonNewAlarm.TabIndex = 15;
            this.buttonNewAlarm.Text = "+ New Alarm";
            this.buttonNewAlarm.UseVisualStyleBackColor = true;
            this.buttonNewAlarm.Click += new System.EventHandler(this.buttonNewAlarm_Click);
            // 
            // buttonDeleteAlarm
            // 
            this.buttonDeleteAlarm.Location = new System.Drawing.Point(656, 498);
            this.buttonDeleteAlarm.Name = "buttonDeleteAlarm";
            this.buttonDeleteAlarm.Size = new System.Drawing.Size(134, 40);
            this.buttonDeleteAlarm.TabIndex = 16;
            this.buttonDeleteAlarm.Text = "x Delete Alarm";
            this.buttonDeleteAlarm.UseVisualStyleBackColor = true;
            this.buttonDeleteAlarm.Click += new System.EventHandler(this.buttonDeleteAlarm_Click);
            // 
            // deleteInputTag
            // 
            this.deleteInputTag.Location = new System.Drawing.Point(850, 321);
            this.deleteInputTag.Name = "deleteInputTag";
            this.deleteInputTag.Size = new System.Drawing.Size(164, 40);
            this.deleteInputTag.TabIndex = 11;
            this.deleteInputTag.Text = "x Delete Tag";
            this.deleteInputTag.UseVisualStyleBackColor = true;
            this.deleteInputTag.Click += new System.EventHandler(this.deleteInputTag_Click);
            // 
            // buttonAlarms
            // 
            this.buttonAlarms.Location = new System.Drawing.Point(701, 322);
            this.buttonAlarms.Name = "buttonAlarms";
            this.buttonAlarms.Size = new System.Drawing.Size(143, 40);
            this.buttonAlarms.TabIndex = 17;
            this.buttonAlarms.Text = "Alarms";
            this.buttonAlarms.UseVisualStyleBackColor = true;
            this.buttonAlarms.Click += new System.EventHandler(this.buttonAlarms_Click);
            // 
            // buttonNewTag2
            // 
            this.buttonNewTag2.Location = new System.Drawing.Point(850, 46);
            this.buttonNewTag2.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNewTag2.Name = "buttonNewTag2";
            this.buttonNewTag2.Size = new System.Drawing.Size(164, 36);
            this.buttonNewTag2.TabIndex = 18;
            this.buttonNewTag2.Text = "+ New Tag";
            this.buttonNewTag2.UseVisualStyleBackColor = true;
            this.buttonNewTag2.Click += new System.EventHandler(this.buttonNewTag2_Click);
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(185, 326);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(139, 26);
            this.textBoxValue.TabIndex = 19;
            // 
            // DbManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 643);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.buttonNewTag2);
            this.Controls.Add(this.buttonAlarms);
            this.Controls.Add(this.buttonDeleteAlarm);
            this.Controls.Add(this.buttonNewAlarm);
            this.Controls.Add(this.listViewAlarms);
            this.Controls.Add(this.tagNameAlarm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deleteInputTag);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.onOffBtn);
            this.Controls.Add(this.listViewInputTags);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteTagBtn);
            this.Controls.Add(this.listViewTags);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addTag);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DbManagerForm";
            this.Text = "DbManagerForm";
            this.Load += new System.EventHandler(this.DbManagerForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addTag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewTags;
        private System.Windows.Forms.Button deleteTagBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewInputTags;
        private System.Windows.Forms.Button onOffBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tagNameAlarm;
        private System.Windows.Forms.ListView listViewAlarms;
        private System.Windows.Forms.Button buttonNewAlarm;
        private System.Windows.Forms.Button buttonDeleteAlarm;
        private System.Windows.Forms.Button deleteInputTag;
        private System.Windows.Forms.Button buttonAlarms;
        private System.Windows.Forms.Button buttonNewTag2;
        private System.Windows.Forms.TextBox textBoxValue;
    }
}