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
        Form LoadSaveForm = new Form();

        public Form1()
        {
            InitializeComponent();
            //Test
        }

        private void LoadSaveButton_Click(object sender, EventArgs e)
        {   
            LoadSaveForm.Show();
        }
    }
}
