using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game_Of_Life
{
    class Cell
    {
        public bool IsAlive { get; set; }
        public Rectangle rectangle { get; set; }
        public Point point;

        public Cell(Rectangle rectangle, Point point)
        {
            this.rectangle = rectangle;
            this.point = point;
        }

        public void Alive()
        {
            IsAlive = true;
        }
        public void Dead()
        {
            IsAlive = false;
        }
    }
}
