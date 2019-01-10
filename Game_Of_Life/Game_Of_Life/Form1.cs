using System;
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
        private bool gameRunning = false;
        private GameLogic gameLogicInstance= new GameLogic();
        
        private bool[][] currentBoard;



        public Form1()
        {
            InitializeComponent();
        }

        private void LoadSaveButton_Click(object sender, EventArgs e)
        {
            Form2 LoadSaveForm = new Form2();
            LoadSaveForm.Show();
        }


        private void StartButton_Click(object sender, EventArgs e)
        {
            InitializeTimer();
            updateGameBoard(currentBoard);
        }

        private void randomGameButton_Click(object sender, EventArgs e)
        {
           currentBoard = gameLogicInstance.GetNewGame();
            gameRunning = true;
        }
        private void InitializeTimer()
        {
            timer.Interval = 500;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimerLabel.Text = DateTime.Now.ToString();
            
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            gameRunning = false;

        }

        private void updateGameBoard(bool[][] currentBoard)
        {

        }
        
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (gameRunning == true)
            {
                currentBoard = gameLogicInstance.GetNextGeneration();
                updateGameBoard(currentBoard);
            }
            else
            {
                MessageBox.Show("You must create a random game first!");
            }
        }

        private void GridPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
