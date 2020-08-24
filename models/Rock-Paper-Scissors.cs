using System;

namespace game.Models
{
  public class Game
  {
    public bool playAgain { get; private set; } = true;
    public void GameStart()
    {
      System.Console.WriteLine("Welcome to Rock, Paper, Scissors!");
      GameCases();
    }
    private void GameCases()
    {
      int computerScore = 0;
      int userScore = 0;

      while (playAgain)
      {
        System.Console.WriteLine("Make a selection:");
        System.Console.WriteLine("1 = Rock, 2 = Paper, 3 = Scissors");
        string userSelection = Console.ReadLine();
        Random rand = new Random();
        int computerSelection = rand.Next(1, 4);

        int.TryParse(userSelection, out int userInput);

        switch (computerSelection)
        {
          case 1:
            System.Console.WriteLine("Computer chose Rock");
            if (userInput == 1) { System.Console.WriteLine("Draw"); };
            if (userInput == 2) { System.Console.WriteLine("You Win"); userScore++; };
            if (userInput == 3) { System.Console.WriteLine("You Lose"); computerScore++; };
            System.Console.WriteLine("You: " + userScore + "  Computer: " + computerScore);
            break;
          case 2:
            System.Console.WriteLine("Computer chose Paper");
            if (userInput == 1) { System.Console.WriteLine("You Lose"); computerScore++; };
            if (userInput == 2) { System.Console.WriteLine("Draw"); };
            if (userInput == 3) { System.Console.WriteLine("You Win"); userScore++; };
            System.Console.WriteLine("You: " + userScore + "  Computer: " + computerScore);
            break;
          case 3:
            System.Console.WriteLine("Computer chose Scissors");
            if (userInput == 1) { System.Console.WriteLine("You Win"); userScore++; };
            if (userInput == 2) { System.Console.WriteLine("You Lose"); computerScore++; };
            if (userInput == 3) { System.Console.WriteLine("Draw"); };
            System.Console.WriteLine("You: " + userScore + "  Computer: " + computerScore);
            break;
          default:
            System.Console.WriteLine("Invalid selection.");
            break;
        }
      }
    }

  }



}