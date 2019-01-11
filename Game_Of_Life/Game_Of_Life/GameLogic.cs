﻿using Game_Of_Life.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Life
{
    class GameLogic
    {
        private int nrRows;
        private int nrColumns;

        private bool[][] currentBoard;
        public GameName currentGame;

        public GameLogic()
        {
            nrRows = 7;
            nrColumns = 7;
        }


        /// <summary>
        /// Generates and returns a new game board.
        /// </summary>
        /// <returns></returns>
        public bool[][] GetNewGame()
        {
            currentGame = new GameName();
            currentBoard = new bool[nrRows][];
            Random random = new Random();

            for (int i = 0; i < nrRows; i++)
            {
                 currentBoard[i] = new bool[nrColumns];
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
                Game = currentGame
            };

            currentGame.generations.Add(gen);

            return currentBoard;
        }


        /// <summary>
        /// Calculates and returns the next generation of the game from current board.
        /// </summary>
        /// <returns></returns>
        public bool[][] GetNextGeneration()
        {
            bool[][] newBoard = new bool[nrRows][];
            int nrNeighbours = 0;

            // Check all cells
            for (int i = 0; i < nrRows; i++)
            {
                newBoard[i] = new bool[nrColumns];
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
                Game = currentGame
            };
            currentGame.generations.Add(gen);
            return newBoard;
        }

        // Would it not have been amazing with some kind of note telling me what I was supposed to do with this...
        /// <summary>
        /// Sets current game to parameter game, and current board to the first generation of that game
        /// </summary>
        /// <param name="game"></param>
        public void SetLoadedGame(GameName game)
        {
            currentGame = game;
            currentBoard = currentGame.generations[0].Board;
        }






        /// <summary>
        /// Returns the generation of the current game specified by the parameter
        /// </summary>
        /// <returns></returns>
        public bool[][] GetLoadedGameBoard(int boardNr)
        {
            if (boardNr >= currentGame.generations.Count)
            {
                return null;
            }
            else
            {
                // Get the i:th board of the current game
                currentBoard = currentGame.generations[boardNr].Board;

                return currentBoard;
            }
        }


        // Check the number of living cells neighbouring a cell located on the board coordinates (x,y)
        /// <summary>
        /// Returns the number of cells neighbouring the cell on board location [x][y] that are alive.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="currentBoard"></param>
        /// <returns></returns>
        private int NrOfLivingNeighbours(int x, int y, bool[][] currentBoard)
        {
            int nrLivingNeighbours = 0;

            // For the cells around (x,y), add one to nrLivingNeighbours if the cell is alive
            for (int i = x - 1; i <= x + 1; i++)
            {
                // Make sure index not out of bounds
                if (i < 0 || i == currentBoard.GetLength(0))
                {
                    ;
                }
                else
                {
                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        System.Diagnostics.Debug.WriteLine("x " + x + " i " + i + " ; y " + y + " j " + j);
                        // Make sure index not out of bounds
                        if (j < 0 || j == currentBoard[i].Length)
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
