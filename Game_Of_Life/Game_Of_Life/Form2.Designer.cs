﻿namespace Game_Of_Life
{
    partial class Form2
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxSavedGames = new System.Windows.Forms.ListBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.GameNameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(7, 103);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save Game";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Saved Games";
            // 
            // listBoxSavedGames
            // 
            this.listBoxSavedGames.FormattingEnabled = true;
            this.listBoxSavedGames.Location = new System.Drawing.Point(118, 22);
            this.listBoxSavedGames.Name = "listBoxSavedGames";
            this.listBoxSavedGames.Size = new System.Drawing.Size(120, 134);
            this.listBoxSavedGames.TabIndex = 4;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(7, 51);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(100, 23);
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.Text = "Remove Game";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(7, 22);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(100, 23);
            this.LoadButton.TabIndex = 6;
            this.LoadButton.Text = "Load Game";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // GameNameBox
            // 
            this.GameNameBox.Location = new System.Drawing.Point(7, 132);
            this.GameNameBox.Name = "GameNameBox";
            this.GameNameBox.Size = new System.Drawing.Size(100, 20);
            this.GameNameBox.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 193);
            this.Controls.Add(this.GameNameBox);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.listBoxSavedGames);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveButton);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxSavedGames;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.TextBox GameNameBox;
    }
}