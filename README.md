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
