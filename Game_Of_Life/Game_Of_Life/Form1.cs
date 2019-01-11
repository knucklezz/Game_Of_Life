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
        private GameLogic gameLogicInstance = new GameLogic();

        private bool[][] currentBoard;
        private bool[,] currentBoard2D = new bool[7, 7];

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
            updateGameBoard();
        }

        private void randomGameButton_Click(object sender, EventArgs e)
        {
            currentBoard = gameLogicInstance.GetNewGame();
            ConvertArrayTo2D();

            //Rita ut första spelplanen

            updateGameBoard();

            //_________________________


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

        private void updateGameBoard()
        {
            int width = currentBoard2D.GetLength(0);
            int height = currentBoard2D.GetLength(1);

            this.GridView.ColumnCount = width;

            for (int r = 0; r < height; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.GridView);

                for (int c = 0; c < width; c++)
                {
                    row.Cells[c].Value = currentBoard2D[r, c];
                }

                this.GridView.Rows.Add(row);

                //rita ut nästa spelplan


                //----------------------
                //currentBoard = gameLogicInstance.GetNextGeneration();
            }

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (gameRunning == true)
            {
                updateGameBoard();
            }
            else
            {
                MessageBox.Show("You must create a random game first!");
            }
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
    }
}
