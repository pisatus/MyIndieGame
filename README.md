# MyIndieGame
A sample for a game logic.

This is a simple quest-based game implemented in C#. The game requires players to complete a series of quests to finish the game. Each quest awards the player with a certain number of points. The game finishes if a quest is failed or when all quests are completed. Upon finishing, the total points earned by the player are displayed.

## Features

- Player can complete quests to earn points.
- Player can fail quests, which ends the game.
- Game tracks the completion status of quests and the total points earned.

## How to Play

1. Clone this repository to your local machine.
2. Open the solution file (`Game.sln`) in Visual Studio or your preferred C# IDE.
3. Run the program.
4. Follow the prompts to complete quests or fail them.

## Usage

```csharp
// Create a new player
Player player = new Player("John");

// Complete quests
player.CompleteQuest("quest1");
player.CompleteQuest("quest2");
player.CompleteQuest("quest3");

// Fail a quest
player.FailQuest("quest4");
```

**NOTE: Since there's no validation on which quest are completed, a player can do the same Quest as many times as it pleases, adding more and more points, up to the C# limit of [2147483647](https://learn.microsoft.com/en-us/dotnet/api/system.int32.maxvalue?view=net-8.0)**

## Contributors

- [Pisatus](https://github.com/pisatus) - Initial work

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
```

You can customize this README file as needed, including adding more details about the game, instructions for running it, and information about contributors.
