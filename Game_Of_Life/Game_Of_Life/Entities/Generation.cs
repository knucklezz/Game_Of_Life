using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Life.Entities
{
    public class Generation
    {
        public int Id { get; set; }
        public GameName GameId { get; set; }
        public virtual string BoardData { get; set; }

        public bool[][] Board
        {
            get
            {
                // Convert BoardData string (columns separated by ',', rows by ';' to bool array
                string[] rows = BoardData.Split(';');
                bool[][] tmpBoard = new bool[rows.Length][];

                for (int i = 0; i < rows.Length; i++)
                {
                    string[] columns = rows[i].Split(',');

                    for (int j = 0; j < columns.Length; j++)
                    {
                        if (columns[j] == "0")
                            tmpBoard[i][j] = false;
                        else
                            tmpBoard[i][j] = true;
                    }
                }
                return tmpBoard;
            }
            set
            {
                var data = value;
                if (data.GetType() == typeof(string))
                {
                    this.BoardData = data.ToString();
                }
                else
                {
                    // Convert a bool array to a string, separating columns with ',' and rows with ';'
                    BoardData = "";

                    try
                    {
                        int rowNr = 0;
                        foreach(bool[] row in data)
                        {
                            rowNr++;
                            for(int j = 0; j < row.Length; j++)
                            {
                                if (row[j] == false)
                                    BoardData += "0";
                                else
                                    BoardData += "1";

                                // Check if reached end of row and/or end of array
                                if (j <= row.Length - 1 && rowNr != data.GetLength(0)) // Not end of row
                                    BoardData += ",";
                                else if (j == row.Length - 1 && rowNr != data.GetLength(0)) // End of row, not last row
                                    BoardData += ";";
                                
                            }
                        }
                    }
                    catch
                    {
                        throw new FormatException();
                    }
                }
            }
        }
    }
}
