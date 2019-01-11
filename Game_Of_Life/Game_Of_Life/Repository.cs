using Game_Of_Life.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Life
{
    public class Repository
    {
        /// <summary>
        /// Returns a saved game
        /// </summary>
        /// <param name="gameId"></param>
        /// <returns></returns>
        public GameName GetGame(int gameId)
        {
            using (GameContext context = new GameContext())
            {   
                GameName game = context.GameNames.FirstOrDefault(x => x.Id == gameId);

                var generationQuery = from gen in game.generations
                                      orderby gen.Id ascending
                                      select gen;
                game.generations = generationQuery.ToList();

                return game;
            }
        }
        
        /// <summary>
        /// Returns all saved games
        /// </summary>
        /// <returns></returns>
        public List<GameName> GetAllGames()
        {
            using (GameContext context = new GameContext())
            {
                List<GameName> games = new List<GameName>();

                var gens = context.GameNames;

                foreach (var gen in gens)
                {
                    games.Add(gen);
                }

                return games;
            }
        }


        /// <summary>
        /// Returns all generations of a saved game
        /// </summary>
        /// <param name="gameId"></param>
        /// <returns></returns>
        public List<Generation> GetGenerations(GameName game)
        {
            int gameId = game.Id;
            using (GameContext context = new GameContext())
            {
                List<Generation> generations = new List<Generation>();

                var gens = context.Generations.Where(x => x.Game.Id == gameId);

                foreach(var gen in gens)
                {
                    generations.Add(gen);
                }

                return generations;
            }
        }


        /// <summary>
        ///  Save a game and all related generations
        /// </summary>
        /// <param name="game"></param>
        public void SaveGame(GameName game)
        {
            using (GameContext context = new GameContext())
            {
                context.GameNames.Add(game);

                context.SaveChanges();
            }
            SaveGenerations(game.generations);
        }


        /// <summary>
        /// Saves a list of generations
        /// </summary>
        /// <param name="generations"></param>
        private void SaveGenerations(List<Generation> generations)
        {
            using(GameContext context = new GameContext())
            {
                foreach(var gen in generations)
                {
                    context.Generations.Add(gen);
                }
                context.SaveChanges();
            }
        }


        /// <summary>
        /// Delete a game and all related generations
        /// </summary>
        /// <param name="game"></param>
        public void DeleteGame(GameName game)
        {
            int gameId = game.Id;
            DeleteGame(gameId);
        }

        public void DeleteGame(int gameId)
        {
            using (GameContext context = new GameContext())
            {
                // Delete related generations
                var gens = context.Generations.Where(x => x.Game.Id == gameId).ToList();
                foreach (var gen in gens)
                {
                    context.Generations.Remove(gen);
                }

                // Delete game
                var gameToRemove = context.GameNames.Where(x => x.Id == gameId).FirstOrDefault();
                context.GameNames.Remove(gameToRemove);

                context.SaveChanges();
            }
        }
    }
}
