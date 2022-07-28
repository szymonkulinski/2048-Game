using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Media;
using System.Threading;

namespace _2048
{
    public partial class Game : Form
    {
        SoundPlayer clickSound = new SoundPlayer(Properties.Resources.mouseClick);
        private const string scoreFileName = "wyniki";
        Player currentPlayer = new Player();

        List<Player> players = new List<Player>();
        Cell[,] cell;
        Menu menu = new Menu();


        public static Random randomNumber = new Random(System.DateTime.Now.Millisecond);

        public int xCells { get; set; }
        public int yCells { get; set; }
        int xCellWidth = 100;
        int yCellWidth = 100;

        public Game()
        {
            InitializeComponent();
        }
        private void Game_Load(object sender, EventArgs e)
        {
            Font = menu.Font;
            AutoSize = true;

            if(xCells != 4 || yCells != 4)
            enterPlayerPanel.Visible = false;

            cell = new Cell[xCells, yCells];

            drawTable(xCellWidth, yCellWidth);
            fillCells();

            generateRandomCell();
            generateRandomCell();

            scoreTableLayout.BackColor = ColorTranslator.FromHtml("#ccc0b3");
            scoreNumber.Text = "0";

            gameOverTableLayout.Location = new Point(this.Width / 2 - gameOverTableLayout.Width/2, this.Height / 2);
            gameOverTableLayout.Visible = false;

            enterPlayerPanel.Location = new Point(this.Width / 6, this.Height / 2 - 90);
            acceptButtonLbl.BackColor = scoreTableLayout.BackColor;

            scorePanel.BackColor = ColorTranslator.FromHtml("#6C6060");

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;

            gameNameLbl.Location = new Point(this.Width / 2 - gameNameLbl.Width/2, 0);

            loadScores();
            gameTableLayout.ResumeLayout();
        }
        private void generateRandomCell()
        {
            bool isFreeSpot = false;
            for (int i = 0; i < xCells; i++)
                for (int j = 0; j < yCells; j++)
                    if (cell[i, j].value == 0) isFreeSpot = true;
            int x = 0;
            int y = 0;
            bool isSet = false;

            while (isFreeSpot && !isSet)
            {
                x = randomNumber.Next(xCells);
                y = randomNumber.Next(yCells);
                if (cell[x, y].value == 0)
                {
                    cell[x, y].value = cell[0, 0].cellStartingValue;
                    isSet = true;
                }
            }
            cell[x, y].colorFill();
            cell[x, y].cellLabel.Text = cell[x, y].value.ToString();
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        moveUp();
                        break;
                    case Keys.Down:
                        moveDown();
                        break;
                    case Keys.Left:
                        moveLeft();
                        break;
                    case Keys.Right:
                        moveRight();
                        break;
                }
            }
        }
        private void clearCellsMerge()
        {
            for (int x = 0; x < xCells; x++)
                for (int y = 0; y < yCells; y++)
                    cell[x, y].merged = false;
        }

        private bool isGameDone()
        {
            for (int x = 0; x < xCells; x++)
                for (int y = 0; y < yCells; y++)
                {
                    if (cell[x, y].value == 0) return false;
                    if (y > 0)
                    {
                        if (cell[x, y - 1].value == cell[x, y].value) return false;
                    }
                    if (x > 0)
                    {
                        if (cell[x - 1, y].value == cell[x, y].value) return false;
                    }
                }
            return true;
        }
        private void gameOver()
        {
            gameOverTableLayout.Visible = true;
            saveScore();
        }
        private void restartGame()
        {
            for (int x = 0; x < xCells; x++)
                for (int y = 0; y < yCells; y++)
                {
                    cell[x, y].defaultSet();
                }
            scoreNumber.Text = "0";
            currentPlayer.score = 0;
            gameOverTableLayout.Visible = false;
            generateRandomCell();
            generateRandomCell();
        }
        private void GoToMenu_Click(object sender, EventArgs e)
        {
            clickSound.Play();
            this.Hide();
            menu.BackColor = this.BackColor;
            menu.Show();
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void GameOverRestartLbl_Click(object sender, EventArgs e)
        {
            clickSound.Play();
            restartGame();
        }
        private void addPlayerToLeaderboard()
        {
            foreach (var item in players)
            {
                if (item.name == currentPlayer.name)
                {
                    if (item.score < currentPlayer.score)
                        item.score = currentPlayer.score;
                    return;
                }
            }
            players.Add(currentPlayer);
        }
        private void saveScore()
        {
            if (xCells == 4 && yCells == 4)
            {
                addPlayerToLeaderboard();
                if (players.Count >= 0)
                {
                    using (StreamWriter scoreboardSave = new StreamWriter("leaderboard.xml"))
                    {
                        XmlSerializer xs = new XmlSerializer(typeof(List<Player>));
                        xs.Serialize(scoreboardSave, players);
                    }
                }
            }
        }
        private void loadScores()
        {
            if (File.Exists("leaderboard.xml"))
            {
                using (StreamReader scoreboardRead = new StreamReader("leaderboard.xml"))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(List<Player>));
                    players = (List<Player>)xs.Deserialize(scoreboardRead);
                }
            }
        }

        private void acceptButtonLbl_Click(object sender, EventArgs e)
        {
            if (enterPlayerNameTextbox.Text != "")
            {
                clickSound.Play();
                enterPlayerPanel.Visible = false;
                enterPlayerNameTextbox.Enabled = false;
                currentPlayer.name = enterPlayerNameTextbox.Text;
            }
        }

        private void Label2_MouseDown(object sender, MouseEventArgs e)
        {
            for(int i = 0; i < 20; i++)
            {
                moveRight();
                moveLeft();
                moveUp();
            }
        }
    }
}