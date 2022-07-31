# 2048 Game
## Description
<p align="center">
  <img src="https://user-images.githubusercontent.com/56955430/181585582-52446bb0-e578-48e1-be5b-abb424482796.png" width="270">
</p>

Based on the original 2048 Game. Game was Made in C# using Windows Forms, with some additional content:
* Changing Visual Style
* Saving score to the leaderboard
* Changing the play-size area from 2x2 to 8x8(Bigger area size is achivable by changing the code, but there may be some preformance issues)

# Code
## Player.cs
<i>Class that store name and the score of the player.</i>

## Menu.cs
<i>Class that handles starting the game, reading the leaderboard and changing the game settings.</i>

#### Players serialization
<i>List of players and their scores are saved in a list that stores objects of class "Player"</i>
```cs
List<Player> players = new List<Player>();
```
Saving players score

<i> We check if there is any new player to save, if so we save the list of players to file leaderboard.xml </i>
```cs
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
```
Loading scores

<i> We check if file "leaderboard.xml" exist, and if it exists then we take the list of players from that file and copy its content to the "players" list deserializing it</i>
```cs
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
```

Deleting scores

<i> First we check if selected index of object to delete if greater than 0, becaouse object with index 0 is the first row of the leaderboard and stores the names of the columns. Later we delete the player and use saveScore method to save score</i>


```cs
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
```

Refreshing leaderboard

<i> First we delete the names and the scores of all players, then we reset the number that represent players placement. Then we name the columns, and then we add players and their scores to the list.</i>

```cs
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
```
## Cell.cs

<i> Cell class represent each cell on the gameboard. </i>

Class atributes:
```cs
        public const int cellStartingValueConst = 2;
        public int cellStartingValue = cellStartingValueConst;
        public Label cellLabel = new Label();
        public int value;
        public bool merged = false;
```
<i> Each cell have it's own value and label we show the cell value with. Each cell has to know if it was merged in the current player move, because each cell can only merge one in one move. </i>

<i> Colloring cells is based on the cell value. Cell can only increase its value when merging with a cell with the same value. Values can only increase by multiplication by 2. </i>
```cs
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
```
## Board.cs

<i> Its partial class of class "Game"
It represent the game board. It has methods responsible for drawing the gameboard and filling it with cells. </i>

<i> Drawing table begins with suspending the layout, to add all the necesery elements without user seeing it happening live. We set the basic attributes like coloring, location and the size of layout. Then we begin to add numbers of cells that is defined in the game class. </i>
```cs
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
```
<i> Then we begin to create objects of class "cell" to each layout cell. Then we add labels to the layout cells labels, and then we bring the cell atributes to default settings. </i>
```cs
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
```
## movingControls.cs

Class that handles the player input. Player use arrow-keys to move the cells. There are 4 arrow-keys therefore there are 4 functions for handeling them, one for each. Since they are very similiar i will only explain one of them.

```cs
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
```
<i> Firstly, we suspend layout for visual and preformance value. "somethingMoved" attribute is for handeling if the player did a valid move, meaning that at least one cell has moved. If none of the cell moved we dont want to generate a new cell. </i> 

<i> Then we check cells to determine if the cell is capable of moving, if so, we move it. The cell has to have bigger value then 0 and the cell mergeValue has to be false to ensure that the cell will not merge more than once, and we need to ensure that cell will not go outside the layout boundaries. </i> 
