using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Media;

namespace _2048
{
    public partial class Menu : Form
    {
        SoundPlayer clickSound = new SoundPlayer(Properties.Resources.mouseClick);
        List<Player> players = new List<Player>();
        public Menu()
        {
            InitializeComponent();
        }
        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            clickSound.Play();
            this.Hide();
            Game game = new Game();
            game.xCells = (int)cellsxNumeric.Value;
            game.yCells = (int)cellsyNumeric.Value;
            game.BackColor = this.BackColor;
            game.Show();
        }

        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            clickSound.Play();
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //ButtonPlay_Click(sender,e);
            leaderBoardPanel.Visible = false;
            optionsPanel.Visible = false;
            loadScores();
            cellsxNumeric.Value = 4;
            cellsyNumeric.Value = 4;

            leaderBoardNameListBox.BackColor = BackColor;
            leaderBoardScoreListBox.BackColor = BackColor;

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
        }
        private void refreshLeaderboard()
        {
            leaderBoardNameListBox.Items.Clear();
            leaderBoardScoreListBox.Items.Clear();
            int number = 1;
            leaderBoardNameListBox.Items.Add("Nazwa:");
            leaderBoardScoreListBox.Items.Add("Wynik:");
            foreach (var osoba in players)
            {
                if(number<=10)
                { 
                string fullName = number + "." + osoba.name;
                leaderBoardNameListBox.Items.Add(fullName);
                leaderBoardScoreListBox.Items.Add(osoba.score);
                }
                number++;
            }
        }

        private void ButtonScores_Click(object sender, EventArgs e)
        {
            clickSound.Play();
            players.Sort((x, y) => y.score.CompareTo(x.score));
            refreshLeaderboard();
            leaderBoardPanel.Visible = true;
        }

        private void BackToMenuLbl_Click(object sender, EventArgs e)
        {
            clickSound.Play();
            leaderBoardPanel.Visible = false;
        }

        private void saveScore()
        {
            if (players.Count >= 0)
            {
                using (StreamWriter scoreboardSave = new StreamWriter("leaderboard.xml"))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(List<Player>));
                    xs.Serialize(scoreboardSave, players);
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
        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (leaderBoardNameListBox.SelectedIndex > 0)
            {
                clickSound.Play();
                players.RemoveAt(leaderBoardNameListBox.SelectedIndex - 1);
                saveScore();
                refreshLeaderboard();
            }
        }

        private void LeaderBoardScoreListBox_MouseDown(object sender, MouseEventArgs e)
        {
            leaderBoardNameListBox.SelectedIndex = leaderBoardScoreListBox.SelectedIndex;
        }

        private void LeaderBoardNameListBox_MouseDown(object sender, MouseEventArgs e)
        {
            leaderBoardScoreListBox.SelectedIndex = leaderBoardNameListBox.SelectedIndex;
        }

        private void LeaderBoardPanel_MouseDown(object sender, MouseEventArgs e)
        {
            leaderBoardScoreListBox.SelectedIndex = -1;
            leaderBoardNameListBox.SelectedIndex = -1;
        }

        private void ButtonOptions_Click(object sender, EventArgs e)
        {
            clickSound.Play();
            optionsPanel.Visible = true;
        }

        private void BackFromOptionsMenuLbl_Click(object sender, EventArgs e)
        {
            clickSound.Play();
            optionsPanel.Visible = false;
        }

        private void ThemeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(themeComboBox.SelectedItem.ToString() == "Ciemny")
            {
                this.BackColor = ColorTranslator.FromHtml("#505050");
                leaderBoardNameListBox.BackColor = BackColor;
                leaderBoardScoreListBox.BackColor = BackColor;
            }
            if (themeComboBox.SelectedItem.ToString() == "Klasyczny")
            {
                this.BackColor = System.Drawing.Color.PapayaWhip;
                leaderBoardNameListBox.BackColor = BackColor;
                leaderBoardScoreListBox.BackColor = BackColor;
            }
        }
    }
}
