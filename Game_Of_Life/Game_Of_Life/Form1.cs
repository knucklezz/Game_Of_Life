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
        // Reset every time a new game is started or loaded
        private int nrPlayedGens;
        private int nrLoadedGens;
        private bool[][] currentBoard;


        public Form1()
        {
            InitializeComponent();
            gameLogicInstance = new GameLogic();
            System.Diagnostics.Debug.Write("");
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
            nrLoadedGens = gameToLoad.generations.Count;
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
            // Every time a new generation is shown
            nrPlayedGens++;


            // After showing the last saved generation
            // Check if there is something else that should happen here, is there a timer, something else...
            // Or if there should even be a message box popping up here? Maybe not?
            // Also if nrPlayedGens is counting correctly; is it one step late?
            if (nrPlayedGens == nrLoadedGens)
            {
                string message = "This is the last saved generation of the game. \nContinue playing?";
                string title = "End of save";
                var dialogResult = MessageBox.Show(message, title, MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    // Continue running game
                }
                else
                {

                    gameRunning = false;
                }
                // Reset counter
                nrLoadedGens = -1;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (gameRunning == true)
            {
                currentBoard = gameLogicInstance.UpdateCurrentBoard();
                updateGameBoard(currentBoard);
            }
            else
            {
                MessageBox.Show("You must create a random game first!");
            }
        }
    }
}
