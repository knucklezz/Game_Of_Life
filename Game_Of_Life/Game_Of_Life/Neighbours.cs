using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Life
{
    class Neighbours : List<Cell>
    {
        public Cell[] GetNeighbours(Cell cell)
        {
            List<Cell> neighbours = new List<Cell>();

            foreach (Cell entry in this)
            {
                //Top row
                if (entry.point.Y.Equals(cell.point.Y - 10))
                {
                    if (entry.point.X.Equals(cell.point.X - 10) || entry.point.X.Equals(cell.point.X) || entry.point.X.Equals(cell.point.X + 10))
                    {
                        if (entry.IsAlive)
                        {
                            neighbours.Add(entry);
                        }
                    }
                }
                // Middle row
                if (entry.point.Y.Equals(cell.point.Y))
                {
                    if (entry.point.X.Equals(cell.point.X - 10) || entry.point.X.Equals(cell.point.X + 10))
                    {
                        if (entry.IsAlive)
                        {
                            neighbours.Add(entry);
                        }
                    }
                }
                //Bottom row
                if (entry.point.Y.Equals(cell.point.Y + 10))
                {
                    if (entry.point.X.Equals(cell.point.X - 10) || entry.point.X.Equals(cell.point.X) || entry.point.X.Equals(cell.point.X + 10))
                    {
                        if (entry.IsAlive)
                        {
                            neighbours.Add(entry);
                        }
                    }
                }
            }

            return neighbours.ToArray();
        }
    }
}
