namespace Game_Of_Life
{
    partial class LoadSaveForm
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
            this.SaveTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadListBox = new System.Windows.Forms.ListBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveTextBox
            // 
            this.SaveTextBox.Location = new System.Drawing.Point(12, 12);
            this.SaveTextBox.Name = "SaveTextBox";
            this.SaveTextBox.Size = new System.Drawing.Size(341, 22);
            this.SaveTextBox.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 40);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(98, 35);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save Game";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // LoadListBox
            // 
            this.LoadListBox.FormattingEnabled = true;
            this.LoadListBox.ItemHeight = 16;
            this.LoadListBox.Location = new System.Drawing.Point(12, 96);
            this.LoadListBox.Name = "LoadListBox";
            this.LoadListBox.Size = new System.Drawing.Size(341, 244);
            this.LoadListBox.TabIndex = 3;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(12, 348);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(98, 35);
            this.LoadButton.TabIndex = 4;
            this.LoadButton.Text = "Load Game";
            this.LoadButton.UseVisualStyleBackColor = true;
            // 
            // LoadSaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 391);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.LoadListBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SaveTextBox);
            this.Name = "LoadSaveForm";
            this.Text = "LoadSaveForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SaveTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ListBox LoadListBox;
        private System.Windows.Forms.Button LoadButton;
    }
}