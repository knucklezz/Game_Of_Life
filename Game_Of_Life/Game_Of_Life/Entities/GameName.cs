using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Life.Entities
{
    [Table("GameName")]
    public class GameName
    {
        public GameName()
        {
            generations = new List<Generation>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Generation> generations { get; set; }
    }
}
