namespace Parsik
{
    partial class Form1
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
            this.buttonGetInitials = new System.Windows.Forms.Button();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.comboBoxGroups = new System.Windows.Forms.ComboBox();
            this.checkedListBoxInitials = new System.Windows.Forms.CheckedListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonGetInitials
            // 
            this.buttonGetInitials.Location = new System.Drawing.Point(60, 72);
            this.buttonGetInitials.Name = "buttonGetInitials";
            this.buttonGetInitials.Size = new System.Drawing.Size(75, 23);
            this.buttonGetInitials.TabIndex = 0;
            this.buttonGetInitials.Text = "button1";
            this.buttonGetInitials.UseVisualStyleBackColor = true;
            this.buttonGetInitials.Click += new System.EventHandler(this.buttonGetInitials_Click);
            // 
            // buttonCompare
            // 
            this.buttonCompare.Location = new System.Drawing.Point(236, 72);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(75, 23);
            this.buttonCompare.TabIndex = 1;
            this.buttonCompare.Text = "button1";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // comboBoxGroups
            // 
            this.comboBoxGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroups.FormattingEnabled = true;
            this.comboBoxGroups.Items.AddRange(new object[] {
            "250504",
            "250505",
            "250701",
            "250702"});
            this.comboBoxGroups.Location = new System.Drawing.Point(483, 41);
            this.comboBoxGroups.Name = "comboBoxGroups";
            this.comboBoxGroups.Size = new System.Drawing.Size(121, 24);
            this.comboBoxGroups.TabIndex = 2;
            this.comboBoxGroups.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroups_SelectedIndexChanged);
            // 
            // checkedListBoxInitials
            // 
            this.checkedListBoxInitials.FormattingEnabled = true;
            this.checkedListBoxInitials.Location = new System.Drawing.Point(29, 153);
            this.checkedListBoxInitials.Name = "checkedListBoxInitials";
            this.checkedListBoxInitials.Size = new System.Drawing.Size(249, 225);
            this.checkedListBoxInitials.TabIndex = 3;
            this.checkedListBoxInitials.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxInitials_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(404, 137);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(323, 279);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 508);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkedListBoxInitials);
            this.Controls.Add(this.comboBoxGroups);
            this.Controls.Add(this.buttonCompare);
            this.Controls.Add(this.buttonGetInitials);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGetInitials;
        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.ComboBox comboBoxGroups;
        private System.Windows.Forms.CheckedListBox checkedListBoxInitials;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

