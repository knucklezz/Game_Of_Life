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
        ///  Save a game and all related generations
        /// </summary>
        /// <param name="game"></param>
        public void SaveGame(GameName game)
        {
            using (GameContext context = new GameContext())
            {
                context.GameNames.Add(game);

                context.SaveChanges();
                Console.WriteLine("Saved");
            }
        }

        //public void SaveGenerations(List<Generation> generations)


        /// <summary>
        /// Delete a game and all related generations
        /// </summary>
        /// <param name="game"></param>
        public void DeleteGame(GameName game)
        {

        }

    }
}
