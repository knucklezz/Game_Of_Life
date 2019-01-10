using Game_Of_Life.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Life
{
    public class GameContext : DbContext
    {
        public GameContext()
            : base("name=connString")
        {
            // No migrations; not code first
            Database.SetInitializer<GameContext>(null);
        }

        public DbSet<GameName> GameNames { get; set; }
        public DbSet<Generation> Generations { get; set; }
    }
        
}
