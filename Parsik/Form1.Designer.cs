namespace Parsik
{
    partial class Parser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parser));
            this.buttonGetInitials = new System.Windows.Forms.Button();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.comboBoxGroups = new System.Windows.Forms.ComboBox();
            this.checkedListBoxInitials = new System.Windows.Forms.CheckedListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonGetInitials
            // 
            resources.ApplyResources(this.buttonGetInitials, "buttonGetInitials");
            this.buttonGetInitials.Name = "buttonGetInitials";
            this.buttonGetInitials.UseVisualStyleBackColor = true;
            this.buttonGetInitials.Click += new System.EventHandler(this.buttonGetInitials_Click);
            // 
            // buttonCompare
            // 
            resources.ApplyResources(this.buttonCompare, "buttonCompare");
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // comboBoxGroups
            // 
            this.comboBoxGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroups.FormattingEnabled = true;
            this.comboBoxGroups.Items.AddRange(new object[] {
            resources.GetString("comboBoxGroups.Items"),
            resources.GetString("comboBoxGroups.Items1"),
            resources.GetString("comboBoxGroups.Items2"),
            resources.GetString("comboBoxGroups.Items3")});
            resources.ApplyResources(this.comboBoxGroups, "comboBoxGroups");
            this.comboBoxGroups.Name = "comboBoxGroups";
            this.comboBoxGroups.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroups_SelectedIndexChanged);
            // 
            // checkedListBoxInitials
            // 
            resources.ApplyResources(this.checkedListBoxInitials, "checkedListBoxInitials");
            this.checkedListBoxInitials.FormattingEnabled = true;
            this.checkedListBoxInitials.Name = "checkedListBoxInitials";
            this.checkedListBoxInitials.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxInitials_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            // 
            // Parser
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkedListBoxInitials);
            this.Controls.Add(this.comboBoxGroups);
            this.Controls.Add(this.buttonCompare);
            this.Controls.Add(this.buttonGetInitials);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Parser";
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

