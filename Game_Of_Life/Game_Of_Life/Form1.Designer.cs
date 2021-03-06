﻿namespace Game_Of_Life
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.GridPanel = new System.Windows.Forms.Panel();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.LoadSaveButton = new System.Windows.Forms.Button();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BackPanel = new System.Windows.Forms.Panel();
            this.GridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.BackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // GridPanel
            // 
            this.GridPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridPanel.AutoSize = true;
            this.GridPanel.BackColor = System.Drawing.Color.DimGray;
            this.GridPanel.Controls.Add(this.GridView);
            this.GridPanel.Location = new System.Drawing.Point(135, 0);
            this.GridPanel.Margin = new System.Windows.Forms.Padding(2);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Size = new System.Drawing.Size(751, 602);
            this.GridPanel.TabIndex = 4;
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.AllowUserToResizeColumns = false;
            this.GridView.AllowUserToResizeRows = false;
            this.GridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView.BackgroundColor = System.Drawing.Color.White;
            this.GridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridView.ColumnHeadersVisible = false;
            this.GridView.Enabled = false;
            this.GridView.Location = new System.Drawing.Point(73, 0);
            this.GridView.Margin = new System.Windows.Forms.Padding(2);
            this.GridView.MultiSelect = false;
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersVisible = false;
            this.GridView.RowTemplate.Height = 24;
            this.GridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridView.ShowCellErrors = false;
            this.GridView.ShowCellToolTips = false;
            this.GridView.ShowEditingIcon = false;
            this.GridView.ShowRowErrors = false;
            this.GridView.Size = new System.Drawing.Size(600, 600);
            this.GridView.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.Location = new System.Drawing.Point(2, 2);
            this.StartButton.Margin = new System.Windows.Forms.Padding(2);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(129, 63);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.ForeColor = System.Drawing.Color.White;
            this.StopButton.Location = new System.Drawing.Point(2, 66);
            this.StopButton.Margin = new System.Windows.Forms.Padding(2);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(129, 63);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NextButton.ForeColor = System.Drawing.Color.White;
            this.NextButton.Location = new System.Drawing.Point(2, 130);
            this.NextButton.Margin = new System.Windows.Forms.Padding(2);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(129, 63);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // LoadSaveButton
            // 
            this.LoadSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadSaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.LoadSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadSaveButton.ForeColor = System.Drawing.Color.White;
            this.LoadSaveButton.Location = new System.Drawing.Point(0, 475);
            this.LoadSaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoadSaveButton.Name = "LoadSaveButton";
            this.LoadSaveButton.Size = new System.Drawing.Size(129, 63);
            this.LoadSaveButton.TabIndex = 3;
            this.LoadSaveButton.Text = "Load/Save";
            this.LoadSaveButton.UseVisualStyleBackColor = false;
            this.LoadSaveButton.Click += new System.EventHandler(this.LoadSaveButton_Click);
            // 
            // NewGameButton
            // 
            this.NewGameButton.BackColor = System.Drawing.Color.MediumBlue;
            this.NewGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NewGameButton.ForeColor = System.Drawing.Color.White;
            this.NewGameButton.Location = new System.Drawing.Point(2, 194);
            this.NewGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(129, 63);
            this.NewGameButton.TabIndex = 5;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = false;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(0, 539);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(129, 63);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BackPanel
            // 
            this.BackPanel.AutoSize = true;
            this.BackPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackPanel.BackColor = System.Drawing.Color.Black;
            this.BackPanel.Controls.Add(this.ExitButton);
            this.BackPanel.Controls.Add(this.NewGameButton);
            this.BackPanel.Controls.Add(this.LoadSaveButton);
            this.BackPanel.Controls.Add(this.NextButton);
            this.BackPanel.Controls.Add(this.StopButton);
            this.BackPanel.Controls.Add(this.StartButton);
            this.BackPanel.Controls.Add(this.GridPanel);
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Location = new System.Drawing.Point(0, 0);
            this.BackPanel.Margin = new System.Windows.Forms.Padding(2);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(886, 602);
            this.BackPanel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(886, 602);
            this.Controls.Add(this.BackPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.BackPanel.ResumeLayout(false);
            this.BackPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Panel GridPanel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button LoadSaveButton;
        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel BackPanel;
        private System.Windows.Forms.DataGridView GridView;
    }
}

