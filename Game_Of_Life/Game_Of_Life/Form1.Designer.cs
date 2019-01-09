namespace Game_Of_Life
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
            this.BackPanel = new System.Windows.Forms.Panel();
            this.GridPanel = new System.Windows.Forms.Panel();
            this.LoadSaveButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.BackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackPanel
            // 
            this.BackPanel.AutoSize = true;
            this.BackPanel.BackColor = System.Drawing.Color.Transparent;
            this.BackPanel.Controls.Add(this.GridPanel);
            this.BackPanel.Controls.Add(this.LoadSaveButton);
            this.BackPanel.Controls.Add(this.NextButton);
            this.BackPanel.Controls.Add(this.StopButton);
            this.BackPanel.Controls.Add(this.StartButton);
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Location = new System.Drawing.Point(0, 0);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(944, 721);
            this.BackPanel.TabIndex = 0;
            // 
            // GridPanel
            // 
            this.GridPanel.BackColor = System.Drawing.Color.DimGray;
            this.GridPanel.Location = new System.Drawing.Point(141, 3);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Size = new System.Drawing.Size(800, 800);
            this.GridPanel.TabIndex = 4;
            // 
            // LoadSaveButton
            // 
            this.LoadSaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.LoadSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadSaveButton.ForeColor = System.Drawing.Color.White;
            this.LoadSaveButton.Location = new System.Drawing.Point(3, 665);
            this.LoadSaveButton.Name = "LoadSaveButton";
            this.LoadSaveButton.Size = new System.Drawing.Size(136, 53);
            this.LoadSaveButton.TabIndex = 3;
            this.LoadSaveButton.Text = "Load/Save";
            this.LoadSaveButton.UseVisualStyleBackColor = false;
            this.LoadSaveButton.Click += new System.EventHandler(this.LoadSaveButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NextButton.ForeColor = System.Drawing.Color.White;
            this.NextButton.Location = new System.Drawing.Point(3, 101);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(136, 53);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = false;
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.ForeColor = System.Drawing.Color.White;
            this.StopButton.Location = new System.Drawing.Point(3, 52);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(136, 53);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = false;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.Location = new System.Drawing.Point(3, 3);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(136, 53);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(944, 721);
            this.Controls.Add(this.BackPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.BackPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BackPanel;
        private System.Windows.Forms.Button LoadSaveButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Panel GridPanel;
    }
}

