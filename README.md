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
<i> We check if file exist, and if it exists then we take the list of players from leaderboard.xml file and copy it to the "players" list</i>
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


