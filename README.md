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
Class that store name and the score of the player.

## Menu.cs
Class that handles starting the game, reading the leaderboard and changing the game settings.

#### Players serialization
List of players and their scores are stored in a list of class "Player"
```cs
List<Player> players = new List<Player>();
```



