using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace _2048
{
    public partial class Game 
    {
        private void drawTable(int xWidth, int yHeigh)
        {
            gameTableLayout.SuspendLayout();
            gameTableLayout.BackColor = ColorTranslator.FromHtml("#6C6060");

            gameTableLayout.Location = new Point(18, 200);

            gameTableLayout.Size = new Size((xCells * xWidth), (yCells * yHeigh));

            gameTableLayout.ColumnCount = xCells;
            gameTableLayout.RowCount = yCells;


            for (int i = 0; i < xCells - 1; i++)
            {
                gameTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, xWidth));
            }
            for (int i = 0; i < yCells - 1; i++)
            {
                gameTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, yHeigh));
            }
            Controls.Add(gameTableLayout);
            gameTableLayout.AutoSize = true;
        }
        private void fillCells()
        {
            for (int i = 0; i < yCells; i++)
            {
                for (int j = 0; j < xCells; j++)
                {
                    cell[j, i] = new Cell();
                    gameTableLayout.Controls.Add(cell[j, i].cellLabel, j, i);
                    cell[j, i].defaultSet();
                }
            }
        }
    }
}
