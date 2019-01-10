﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Of_Life
{
    public partial class Form1 : Form
    {
        Timer timer1 = new Timer();
        GameLogic gamelogic = new GameLogic();

        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
            gamelogic.GetNewGame(12, 12);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {

        }

        private void LoadSaveButton_Click(object sender, EventArgs e)
        {
            Form LoadSaveForm = new Form();
            LoadSaveForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 2000;
            timer1.Enabled = true;
        }
    }
}
