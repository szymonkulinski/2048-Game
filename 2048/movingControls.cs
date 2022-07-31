using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Media;


namespace _2048
{
    public partial class Game
    {
        SoundPlayer moveSound = new SoundPlayer(Properties.Resources.movingSound);
        SoundPlayer winSound = new SoundPlayer(Properties.Resources.victorySound);
        private void moveRight()
        {
            gameTableLayout.SuspendLayout();
            bool somethingMoved = true;
            while (somethingMoved)
            {
                somethingMoved = false;
                for (int x = xCells - 1; x > 0; x--)
                {
                    for (int y = 0; y < yCells; y++)
                    {
                        if (cell[x, y].value != 0 && cell[x - 1, y].value == cell[x, y].value && !cell[x, y].merged && !cell[x - 1, y].merged)
                        {
                            cell[x, y].value *= 2;         
                            somethingMoved = true;
                            cell[x - 1, y].defaultSet();
                            cell[x, y].colorFill();
                            cell[x, y].cellLabel.Text = cell[x, y].value.ToString();
                            cell[x, y].merged = true;
                            currentPlayer.score += cell[x, y].value;
                        }
                        else if (cell[x, y].value == 0 && cell[x - 1, y].value != 0)
                        {
                            cell[x, y].value = cell[x - 1, y].value;
                            somethingMoved = true;
                            cell[x - 1, y].defaultSet();
                            cell[x, y].colorFill();
                            cell[x, y].cellLabel.Text = cell[x, y].value.ToString();
                        }
                    }
                }
            }
            scoreNumber.Text = currentPlayer.score.ToString();
            if (somethingMoved)
            {
                generateRandomCell();
                moveSound.Play();
            }
            clearCellsMerge();

            if (isGameDone())
                gameOver();
            gameTableLayout.ResumeLayout();
        }
        private void moveLeft()
        {
            gameTableLayout.SuspendLayout();
            bool somethingMoved = true;
            bool spawnNewCell = false;
            while (somethingMoved)
            {
                somethingMoved = false;
                for (int x = 0; x < xCells - 1; x++)
                {
                    for (int y = 0; y < yCells; y++)
                    {
                        if (cell[x, y].value != 0 && cell[x, y].value == cell[(x + 1), y].value && !cell[x, y].merged && !cell[x + 1, y].merged)
                        {
                            cell[x, y].value *= 2;
                            somethingMoved = true;
                            spawnNewCell = true;
                            cell[x + 1, y].defaultSet();
                            cell[x, y].colorFill();
                            cell[x, y].cellLabel.Text = cell[x, y].value.ToString();
                            cell[x, y].merged = true;
                            currentPlayer.score += cell[x, y].value;
                        }
                        else if (cell[x, y].value == 0 && cell[(x + 1), y].value != 0)
                        {
                            cell[x, y].value = cell[x + 1, y].value;
                            somethingMoved = true;
                            spawnNewCell = true;
                            cell[x + 1, y].defaultSet();
                            cell[x, y].colorFill();
                            cell[x, y].cellLabel.Text = cell[x, y].value.ToString();
                        }
                    }
                }
            }
            scoreNumber.Text = currentPlayer.score.ToString();
            clearCellsMerge();
            if (spawnNewCell)
            {
                generateRandomCell();
                moveSound.Play();
            }

            if (isGameDone())
                gameOver();
            gameTableLayout.ResumeLayout();
        }

        private void moveDown()
        {
            gameTableLayout.SuspendLayout();
            bool somethingMoved = true;
            bool spawnNewCell = false;
            while (somethingMoved)
            {
                somethingMoved = false;
                for (int y = yCells - 1; y > 0; y--)
                {
                    for (int x = 0; x < xCells; x++)
                    {
                        if (cell[x, y].value != 0 && cell[x, y].value == cell[x, y - 1].value && !cell[x, y].merged && !cell[x, y - 1].merged)
                        {
                            cell[x, y].value *= 2;
                            somethingMoved = true;
                            spawnNewCell = true;
                            cell[x, y - 1].defaultSet();
                            cell[x, y].colorFill();
                            cell[x, y].cellLabel.Text = cell[x, y].value.ToString();
                            cell[x, y].merged = true;
                            currentPlayer.score += cell[x, y].value;
                        }
                        else if (cell[x, y].value == 0 && cell[x, y - 1].value != 0)
                        {
                            cell[x, y].value = cell[x, y - 1].value;
                            somethingMoved = true;
                            spawnNewCell = true;
                            cell[x, y - 1].defaultSet();
                            cell[x, y].colorFill();
                            cell[x, y].cellLabel.Text = cell[x, y].value.ToString();
                        }
                    }
                }
            }
            scoreNumber.Text = currentPlayer.score.ToString();
            clearCellsMerge();
            if (spawnNewCell)
            {
                generateRandomCell();
                moveSound.Play();
            }

            if (isGameDone())
                gameOver();
            gameTableLayout.ResumeLayout();
        }

        private void moveUp()
        {
            gameTableLayout.SuspendLayout();
            bool somethingMoved = true;
            bool spawnNewCell = false;
            while (somethingMoved)
            {
                somethingMoved = false;
                for (int y = 0; y < yCells - 1; y++)
                {
                    for (int x = 0; x < xCells; x++)
                    {
                        if (cell[x, y].value != 0 && cell[x, y].value == cell[x, y + 1].value && !cell[x, y].merged && !cell[x, y + 1].merged)
                        {
                            cell[x, y].value *= 2;
                            somethingMoved = true;
                            spawnNewCell = true;
                            cell[x, y + 1].defaultSet();
                            cell[x, y].colorFill();
                            cell[x, y].cellLabel.Text = cell[x, y].value.ToString();
                            cell[x, y].merged = true;
                            currentPlayer.score += cell[x, y].value;
                            if (cell[x, y].value == 2048)
                                winSound.Play();
                        }
                        else if (cell[x, y].value == 0 && cell[x, y + 1].value != 0)
                        {
                            cell[x, y].value = cell[x, y + 1].value;
                            somethingMoved = true;
                            spawnNewCell = true;
                            cell[x, y + 1].defaultSet();
                            cell[x, y].colorFill();
                            cell[x, y].cellLabel.Text = cell[x, y].value.ToString();
                        }
                    }
                }
            }
            scoreNumber.Text = currentPlayer.score.ToString();
            clearCellsMerge();
            if (spawnNewCell)
            {
                generateRandomCell();
                moveSound.Play();
            }

            if (isGameDone())
                gameOver();
            gameTableLayout.ResumeLayout();
        }
    }
}
