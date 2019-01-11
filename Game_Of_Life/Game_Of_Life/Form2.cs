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
    public partial class Form2 : Form
    {
        private Form1 mainForm;
        private Repository Repos;

        public Form2(Form1 form1)
        {
            InitializeComponent();

            mainForm = form1;
            Repos = new Repository();

            GetSavedGameNames();
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            GameName game = mainForm.GetCurrentGame();
            if (game == null)
            {
                MessageBox.Show("No game to save");
            }
            else
            {
                if (GameNameBox.Text == "")
                {
                    MessageBox.Show("You must give your save a name!");
                }
                else
                {
                    game.Name = GameNameBox.Text;
                    Repos.SaveGame(game);
                    listBoxSavedGames.Items.Add(game.Id + ": " + game.Name);
                }
            }
        }

        // TODO
        // Call the method in Form1 that updates the game board
        // Do we want to close this form after loading a game?
        private void LoadButton_Click(object sender, EventArgs e)
        {
            GameName loadedGame = GetGameFromListBox();
            if(loadedGame == null)
            {
                
            }
            else
            {
                loadedGame.generations = Repos.GetGenerations(loadedGame);
                // Update mainForm
                mainForm.SetLoadedGame(loadedGame);
                // Update board as well?
                this.Dispose();
            }
        }


        private void RemoveButton_Click(object sender, EventArgs e)
        {
            GameName gameToRemove = GetGameFromListBox();
            if(gameToRemove == null)
            {
                ;
            }
            else
            {
                Repos.DeleteGame(gameToRemove);
                listBoxSavedGames.Items.Remove(listBoxSavedGames.SelectedItem);
            }
        }


        private GameName GetGameFromListBox()
        {
            string gameToLoad = "";
            try
            {
                gameToLoad = listBoxSavedGames.SelectedItem.ToString();
            }
            catch
            {
                return null;
            }

            string[] gameIdStr = gameToLoad.Split(':');
            if (int.TryParse(gameIdStr[0], out int gameId))
            {
                GameName game;
                try
                {
                    game = Repos.GetGame(gameId);
                    return game;
                }
                catch (Exception)
                {
                    return null;
                }

                // Call the main form update method board
            }
            else
            {
                MessageBox.Show("No game id");
                return null;
            }
        }


        private void GetSavedGameNames()
        {
            List<GameName> gameNames = Repos.GetAllGames();
            gameNames.OrderBy(x => x.Id);

            foreach (var game in gameNames)
            {
                listBoxSavedGames.Items.Add(game.Id +": " +game.Name);

                System.Diagnostics.Debug.WriteLine(game.Id + ": " + game.Name);
            }
        }
    }
}
