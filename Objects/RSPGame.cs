using System;
using System.Collections.Generic;

namespace RSP
{
  public class RSPGame
  {
    public string CheckWhoWins(string userInput1, string userInput2)
    {
      if(userInput1 == userInput2)
      {
        return "Draw";
      }
      else if(userInput1 == "Rock" && userInput2 == "Scissor")
      {
        return "Player 1 Wins";
      }
      else if(userInput1 == "Rock" && userInput2 == "Paper")
      {
        return "Player 2 Wins";
      }
      else if(userInput1 == "Scissor" && userInput2 == "Rock")
      {
        return "Player 2 Wins";
      }
      else if(userInput1 == "Scissor" && userInput2 == "Paper")
      {
        return "Player 1 Wins";
      }
      else if(userInput1 == "Paper" && userInput2 == "Rock")
      {
        return "Player 1 Wins";
      }
      else if(userInput1 == "Paper" && userInput2 == "Scissor")
      {
        return "Player 2 Wins";
      }
      else
      {
        return "Please enter a valid input!";
      }
    }

  }
}
