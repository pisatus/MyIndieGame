	using System;
	using System.Collections.Generic;

	public class Game
	{
	    private Dictionary<string, int> quests = new Dictionary<string, int>()
	    {
	        { "quest1", 50 },	        
	        { "quest2", 50 },	        
	        { "quest3", 50 },	        
	        { "quest4", 50 },	        
	        { "quest5", 100 }
	    };

	    private int points = 0;
	    private HashSet<string> completedQuests = new HashSet<string>();
	    private string failedQuest = null;

	    public void CompleteQuest(string questName)
	    {
	        if (quests.ContainsKey(questName) && failedQuest == null)
	        {
	            points += quests[questName];
	            completedQuests.Add(questName);
	            Console.WriteLine($"Quest '{questName}' completed! You earned {quests[questName]} points.");
	            if (completedQuests.Count == quests.Count)
	            {
	                Console.WriteLine("Congratulations! You have completed all quests!");
	                FinishGame();
	            }
	        }
	        else
	        {
	            Console.WriteLine("Quest completion failed. Either the quest does not exist, is already completed, or the game has finished.");
	        }
	    }

	    public void FailQuest(string questName)
	    {
	        if (quests.ContainsKey(questName) && !completedQuests.Contains(questName) && failedQuest == null)
	        {
	            failedQuest = questName;
	            Console.WriteLine($"Quest '{questName}' failed. Game over!");
	            FinishGame();
	        }
	        else
	        {
	            Console.WriteLine("Quest failure could not be processed. Either the quest does not exist, is already completed, or the game has finished.");
	        }
	    }

	    private void FinishGame()
	    {
	        if (failedQuest != null)
	        {
	            Console.WriteLine("Game over!");
	        }
	        else
	        {
	            Console.WriteLine($"Total points: {points}");
	            // Add logic to update top 10 leaderboard
	        }
	    }
	}

	public class Player
	{
	    private string name;
	    private Game game;

	    public Player(string name)
	    {
	        this.name = name;
	        game = new Game();
	    }

	    public void CompleteQuest(string questName)
	    {
	        game.CompleteQuest(questName);
	    }

	    public void FailQuest(string questName)
	    {
	        game.FailQuest(questName);
	    }
	}
	
