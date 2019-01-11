using Game_Of_Life.Entities;
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
        private GameLogic gameLogicInstance;


        private bool[][] currentBoard;


        public Form1()
        {
            InitializeComponent();
            gameLogicInstance = new GameLogic();
        }


        /// <summary>
        /// Returns the current game from the gameLogicInstance.
        /// </summary>
        /// <returns></returns>
        public GameName GetCurrentGame()
        {
            return gameLogicInstance.currentGame;
        }


        /// <summary>
        /// Sets the current game and game board in the gameLogicInstance to the parameter gameToLoad
        /// </summary>
        /// <param name="gameToLoad"></param>
        public void SetLoadedGame(GameName gameToLoad)
        {
            gameLogicInstance.SetLoadedGame(gameToLoad);
        }


        private void LoadSaveButton_Click(object sender, EventArgs e)
        {
            Form2 LoadSaveForm = new Form2(this);
            LoadSaveForm.Show();
        }

        private void GridPanel_Paint(object sender, PaintEventArgs e)
        {

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
                updateGameBoard(currentBoard);
            }
            else
            {
                MessageBox.Show("You must create a random game first!");
            }
        }
    }
}
