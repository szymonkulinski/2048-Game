using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace _2048
{
    public class Cell
    {
        public const int cellStartingValueConst = 2;
        public int cellStartingValue = cellStartingValueConst;
        public Label cellLabel = new Label();
        public int value;
        public bool merged = false;
    
        public Cell()
        {
            this.value = 0;
        }
        public void colorFill()
        {               
            if(value == cellStartingValue)
                cellLabel.BackColor = ColorTranslator.FromHtml("#eee4da");
            else if (value == cellStartingValue * 2)
                cellLabel.BackColor = ColorTranslator.FromHtml("#ede0c8");
            else if (value == cellStartingValue * 4)
                cellLabel.BackColor = ColorTranslator.FromHtml("#f2b179");
            else if (value == cellStartingValue * 8)
                cellLabel.BackColor = ColorTranslator.FromHtml("#f59563");
            else if (value == cellStartingValue * 16)
                cellLabel.BackColor = ColorTranslator.FromHtml("#f65e3b");
            else if (value == cellStartingValue * 32)
                cellLabel.BackColor = ColorTranslator.FromHtml("#edcf72");
            else if (value == cellStartingValue * 64)
                cellLabel.BackColor = ColorTranslator.FromHtml("#f6cb5a");
            else if (value == cellStartingValue * 128)
                cellLabel.BackColor = ColorTranslator.FromHtml("#f7c74b");
            else if (value == cellStartingValue * 256)
                cellLabel.BackColor = ColorTranslator.FromHtml("#f8c440");
            else if (value == cellStartingValue * 512)
                cellLabel.BackColor = ColorTranslator.FromHtml("#eec22e");
            else if (value == cellStartingValue * 1024)
                cellLabel.BackColor = ColorTranslator.FromHtml("#FFA500");
            else if (value == cellStartingValue * 2048)
                cellLabel.BackColor = ColorTranslator.FromHtml("#FF8C00");
        }
        public void defaultSet()
        {
            cellLabel.Text = "";
            value = 0;
            cellLabel.Dock = DockStyle.Fill;
            cellLabel.TextAlign = ContentAlignment.MiddleCenter;
            cellLabel.Margin = new Padding(6);
            cellLabel.BackColor = ColorTranslator.FromHtml("#ccc0b3");
            cellLabel.AutoSize = true;
        }

    }
}
