using Game_Of_Life.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Life
{
    class GameLogic
    {
        private List<bool[][]> allGenerationsCurrentGame;
        private bool[][] currentBoard;
        private GameName currentGame;

        // Generate and return a random starting board for a new game
        public bool[][] GetNewGame(int nrRows, int nrColumns)
        {
            currentGame = new GameName();
            // ////// Needs at least a couple of cells that will survive and at least one that will be born in the next generation
            currentBoard = new bool[nrRows][];
            Random random = new Random();

            for (int i = 0; i < nrRows; i++)
            {
                for (int j = 0; j < nrColumns; j++)
                {
                    // Generate a random number to determine whether a cell will be alive or not at the beginning of the game
                    // Odd numbers are alive, even are not
                    int nr = random.Next(0, 2);
                    if (nr % 2 == 0)
                        currentBoard[i][j] = false;
                    else
                        currentBoard[i][j] = true;
                }
            }

            Generation gen = new Generation
            {
                Board = currentBoard,
                GameId = currentGame
            };

            currentGame.generations.Add(gen);

            return currentBoard;
        }


        // Check how many cells are alive next to each cell, kill and birth new ones accordingly
        // Return the new generation
        public bool[][] GetNextGeneration(int nrRows, int nrColumns)
        {
            bool[][] newBoard = new bool[nrRows][];
            int nrNeighbours = 0;

            // Check all cells
            for (int i = 0; i < nrRows; i++)
            {
                for (int j = 0; j < nrColumns; j++)
                {
                    nrNeighbours = NrOfLivingNeighbours(i, j, currentBoard);
                    // If cell is alive, it survives with two or three neighbours
                    if (currentBoard[i][j])
                    {
                        if (nrNeighbours == 2 || nrNeighbours == 3)
                            newBoard[i][j] = true;
                    }
                    // A new cell is born if an empty one has exactly three neighbours
                    else
                    {
                        if (nrNeighbours == 3)
                            newBoard[i][j] = true;
                    }
                }
            }

            // Return new generation
            currentBoard = new bool[nrRows][];
            currentBoard = newBoard;

            Generation gen = new Generation
            {
                Board = currentBoard,
                GameId = currentGame
            };
            currentGame.generations.Add(gen);
            return newBoard;
        }


        // Return all generations of the specified game
        public void GetSavedGame(string gameToLoad)
        {
            // crud read method
            // Generate a list of boards from database data
            // Return list?
        }

        // Return names of all saved games
        public List<GameName> GetGameNames()
        {
            List<GameName> names = new List<GameName>();

            return names;
        }

        // Save the game + generations with the specified name
        // ////// Would saving a GameName also save its generations, or will they need to be saved separately?
        public void SaveGame(string nameOfSave)
        {
            // Call crud save method
        }


        // Delete a saved game and all linked generations
        public void DeleteSavedGame(string nameOfSave)
        {

        }

        
        // Check the number of living cells neighbouring a cell located on the board coordinates (x,y)
        private int NrOfLivingNeighbours(int x, int y, bool[][] currentBoard)
        {
            int nrLivingNeighbours = 0;

            // For the cells around (x,y), add one to nrLivingNeighbours if the cell is alive
            for (int i = x - 1; i <= x + 1; i++)
            {
                // Make sure index not out of bounds
                if (i < 0)
                {
                    ;
                }
                else
                {
                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        // Make sure index not out of bounds
                        if (j < 0)
                        {
                            ;
                        }
                        else
                        {
                            if (i == x && j == y)
                                ;
                            else if (currentBoard[i][j] == true)
                                nrLivingNeighbours++;
                        }
                    }
                }

            }

            return nrLivingNeighbours;
        }

    }
}
