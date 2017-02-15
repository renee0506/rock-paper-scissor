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
        return "draw";
      }
      else if(userInput1 == "Rock" && userInput2 == "Scissor")
      {
        return "User1 Wins";
      }
      else if(userInput1 == "Rock" && userInput2 == "Paper")
      {
        return "User2 Wins";
      }
      else if(userInput1 == "Scissor" && userInput2 == "Rock")
      {
        return "User2 Wins";
      }
      else if(userInput1 == "Scissor" && userInput2 == "Paper")
      {
        return "User1 Wins";
      }
      else if(userInput1 == "Paper" && userInput2 == "Rock")
      {
        return "User1 Wins";
      }
      else if(userInput1 == "Paper" && userInput2 == "Scissor")
      {
        return "User2 Wins";
      }
      else
      {
        return "Please enter a valid input!";
      }
    }
  }
}
