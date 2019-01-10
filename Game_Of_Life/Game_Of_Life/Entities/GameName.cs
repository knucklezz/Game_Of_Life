using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Life.Entities
{
    public class GameName
    {
        public GameName()
        {
            generations = new List<Generation>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Generation> generations { get; set; }
    }
}
