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
        //private bool gameRunning = false;
        private GameLogic gameLogicInstance = new GameLogic();
        private bool[][] currentBoard;

        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void LoadSaveButton_Click(object sender, EventArgs e)
        {
            Form LoadSaveForm = new Form();
            LoadSaveForm.Show();
        }

        private void GridPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            updateGameBoard(currentBoard);
        }

        private void randomGameButton_Click(object sender, EventArgs e)
        {
            currentBoard = gameLogicInstance.GetNewGame();

            for (int i = 0; i < currentBoard.GetLength(0); i++)
            {
                GridView.DataSource = currentBoard[i];

                
            }
        
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
                
        }

        private void updateGameBoard(bool[][] currentBoard)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            currentBoard = gameLogicInstance.GetNextGeneration();
        }
    }
}
