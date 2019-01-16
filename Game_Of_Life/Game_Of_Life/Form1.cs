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
        private static int boardSize = 15;
        private bool gameRunning = false;
        private bool autoGameRunning = false;
        private GameLogic gameLogicInstance;
        // Reset every time a new game is started or loaded
        private int nrPlayedGens;
        private int nrLoadedGens;
        private bool[][] currentBoard;
        private bool[,] currentBoard2D = new bool[boardSize, boardSize];


        public Form1()
        {
            InitializeComponent();
            gameLogicInstance = new GameLogic(boardSize);
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
            nrPlayedGens = 0;

            gameRunning = true;
            GridView.Visible = true;
            currentBoard = gameLogicInstance.UpdateCurrentBoard();
            ConvertArrayTo2D();
            updateGameBoard();
        }

        private void LoadSaveButton_Click(object sender, EventArgs e)
        {
            Form2 LoadSaveForm = new Form2(this);
            LoadSaveForm.Show();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {          
            if (gameRunning == true )
            {
                InitializeTimer();
                autoGameRunning = true;
                NextButton.Enabled = false;
                LoadSaveButton.Enabled = false;
                NewGameButton.Enabled = false;
                StartButton.Enabled = false;


            }
            else
            {
                MessageBox.Show("create a game");
            }

        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            nrPlayedGens = 0;
            currentBoard = gameLogicInstance.GetNewGame();
            ConvertArrayTo2D();

            //Rita ut första spelplanen
            GridView.Visible = true;
            updateGameBoard();

            gameRunning = true;
        }

        private void InitializeTimer()
        {
            timer.Interval = 700;
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (gameRunning == true)
            {
                currentBoard = gameLogicInstance.UpdateCurrentBoard();
                updateGameBoard();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            autoGameRunning = false;
            StartButton.Enabled = true;
            NextButton.Enabled = true;
            LoadSaveButton.Enabled = true;
            NewGameButton.Enabled = true;
            StartButton.Enabled = true;

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (gameRunning == true && autoGameRunning != true)
            {
                currentBoard = gameLogicInstance.UpdateCurrentBoard();
                updateGameBoard();
            }
            else
            {
                if (autoGameRunning == false)
                {
                    MessageBox.Show("You must create a random game or load one in first!");
                }
                else
                {
                    //Do Nothing
                };
                    
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConvertArrayTo2D()
        {
            for (int i = 0; i < currentBoard.Length; i++)
            {
                bool[] innerArray = currentBoard[i];

                for (int j = 0; j < innerArray.Length; j++)
                {
                    currentBoard2D[i, j] = currentBoard[i][j];
                }
            }
        }

        private void CreateGameBoard()
        {
            this.GridView.Visible = false;
            this.GridView.ColumnCount = boardSize;

            for (int r = 0; r < boardSize; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewColumn column = this.GridView.Columns[r];


                column.MinimumWidth = GridView.Height / boardSize;
                row.MinimumHeight = GridView.Width / boardSize;
                GridView.RowTemplate.MinimumHeight = GridView.Height / boardSize;

                row.CreateCells(this.GridView);
                GridView.Rows.Add(row);
            }
            this.GridView.Left = (GridPanel.Width / 2) - (GridView.Width / 2);
        }


        private void updateGameBoard()
        {
            ConvertArrayTo2D();
            int width = currentBoard2D.GetLength(0);
            int height = currentBoard2D.GetLength(1);

            for (int r = 0; r < height; r++)
            {
                DataGridViewRow row = this.GridView.Rows[r];
                DataGridViewColumn column = GridView.Columns[r];

                for (int c = 0; c < width; c++)
                {
                    if(currentBoard2D[r,c] == true)
                    {
                        row.Cells[c].Style.BackColor = Color.FromArgb(255, 6, 60, 174);
                        row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 6, 60, 174);
                    }
                    else if(currentBoard2D[r,c] == false)
                    {                        
                        row.Cells[c].Style.BackColor = Color.FromArgb(255, 255, 255, 255);
                        row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255, 255);
                    }
                }
            }
            nrPlayedGens++;

            // After showing the last saved generation
            if (nrPlayedGens == nrLoadedGens)
            {
                string message = "This is the last saved generation of the game. \nContinue playing?";
                string title = "End of save";
                var dialogResult = MessageBox.Show(message, title, MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    // Continue running game
                }
                else
                {
                    gameRunning = false;
                    nrPlayedGens = 0;
                }
                // Reset counter
                nrLoadedGens = -1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            GridView.Height = GridPanel.Height;
            GridView.Width = GridView.Height;

            CreateGameBoard();
        }
    }
}
