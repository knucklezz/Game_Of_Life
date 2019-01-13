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
            this.components = new System.ComponentModel.Container();
            this.BackPanel = new System.Windows.Forms.Panel();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.randomGameButton = new System.Windows.Forms.Button();
            this.GridPanel = new System.Windows.Forms.Panel();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.LoadSaveButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.BackPanel.SuspendLayout();
            this.GridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BackPanel
            // 
            this.BackPanel.AutoSize = true;
            this.BackPanel.BackColor = System.Drawing.Color.Transparent;
            this.BackPanel.Controls.Add(this.TimerLabel);
            this.BackPanel.Controls.Add(this.randomGameButton);
            this.BackPanel.Controls.Add(this.GridPanel);
            this.BackPanel.Controls.Add(this.LoadSaveButton);
            this.BackPanel.Controls.Add(this.NextButton);
            this.BackPanel.Controls.Add(this.StopButton);
            this.BackPanel.Controls.Add(this.StartButton);
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Location = new System.Drawing.Point(0, 0);
            this.BackPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(650, 538);
            this.BackPanel.TabIndex = 0;
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Location = new System.Drawing.Point(32, 191);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(35, 13);
            this.TimerLabel.TabIndex = 6;
            this.TimerLabel.Text = "label1";
            // 
            // randomGameButton
            // 
            this.randomGameButton.BackColor = System.Drawing.Color.MediumBlue;
            this.randomGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.randomGameButton.ForeColor = System.Drawing.Color.White;
            this.randomGameButton.Location = new System.Drawing.Point(2, 122);
            this.randomGameButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.randomGameButton.Name = "randomGameButton";
            this.randomGameButton.Size = new System.Drawing.Size(109, 42);
            this.randomGameButton.TabIndex = 5;
            this.randomGameButton.Text = "Random";
            this.randomGameButton.UseVisualStyleBackColor = false;
            this.randomGameButton.Click += new System.EventHandler(this.randomGameButton_Click);
            // 
            // GridPanel
            // 
            this.GridPanel.BackColor = System.Drawing.Color.DimGray;
            this.GridPanel.Controls.Add(this.GridView);
            this.GridPanel.Location = new System.Drawing.Point(113, 2);
            this.GridPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Size = new System.Drawing.Size(536, 536);
            this.GridPanel.TabIndex = 4;
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.AllowUserToResizeColumns = false;
            this.GridView.AllowUserToResizeRows = false;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.ColumnHeadersVisible = false;
            this.GridView.Enabled = false;
            this.GridView.Location = new System.Drawing.Point(0, 0);
            this.GridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.GridView.Size = new System.Drawing.Size(536, 536);
            this.GridView.TabIndex = 0;
            // 
            // LoadSaveButton
            // 
            this.LoadSaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.LoadSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadSaveButton.ForeColor = System.Drawing.Color.White;
            this.LoadSaveButton.Location = new System.Drawing.Point(2, 496);
            this.LoadSaveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoadSaveButton.Name = "LoadSaveButton";
            this.LoadSaveButton.Size = new System.Drawing.Size(109, 42);
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
            this.NextButton.Location = new System.Drawing.Point(2, 81);
            this.NextButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(109, 42);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.ForeColor = System.Drawing.Color.White;
            this.StopButton.Location = new System.Drawing.Point(2, 42);
            this.StopButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(109, 42);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.Location = new System.Drawing.Point(2, 2);
            this.StartButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(109, 42);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(650, 538);
            this.Controls.Add(this.BackPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.BackPanel.ResumeLayout(false);
            this.BackPanel.PerformLayout();
            this.GridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
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
        private System.Windows.Forms.Button randomGameButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.DataGridView GridView;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}

