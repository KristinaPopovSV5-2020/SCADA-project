
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
            this.SuspendLayout();
            // 
            // addTag
            // 
            this.addTag.Location = new System.Drawing.Point(22, 311);
            this.addTag.Margin = new System.Windows.Forms.Padding(2);
            this.addTag.Name = "addTag";
            this.addTag.Size = new System.Drawing.Size(101, 27);
            this.addTag.TabIndex = 1;
            this.addTag.Text = "New Tag";
            this.addTag.UseVisualStyleBackColor = true;
            this.addTag.Click += new System.EventHandler(this.addTag_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tags";
            // 
            // listViewTags
            // 
            this.listViewTags.HideSelection = false;
            this.listViewTags.Location = new System.Drawing.Point(22, 37);
            this.listViewTags.Name = "listViewTags";
            this.listViewTags.Size = new System.Drawing.Size(308, 269);
            this.listViewTags.TabIndex = 3;
            this.listViewTags.UseCompatibleStateImageBehavior = false;
            // 
            // DbManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 360);
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
    }
}