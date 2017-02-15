using Xunit;
using System;
using System.Collections.Generic;

namespace RSP
{
  public class RSPTest
  {
    [Fact]
    public void CheckWhoWins_WhenTheInputMatches_Draw()
    {
      RSPGame testRSPGame = new RSPGame();
      Assert.Equal("Draw", testRSPGame.CheckWhoWins("Rock", "Rock"));
    }

    [Fact]
    public void CheckWhoWins_WhenTheInputIsRockVsScissor_UserIWins()
    {
      RSPGame testRSPGame = new RSPGame();
      Assert.Equal("Player 1 Wins", testRSPGame.CheckWhoWins("Rock", "Scissor"));
    }

    [Fact]
    public void CheckWhoWins_WhenTheInputIsRockVsPaper_User2Wins()
    {
      RSPGame testRSPGame = new RSPGame();
      Assert.Equal("Player 2 Wins", testRSPGame.CheckWhoWins("Rock", "Paper"));
    }

    [Fact]
    public void CheckWhoWins_WhenTheInputIsScissorVsRock_User2Wins()
    {
      RSPGame testRSPGame = new RSPGame();
      Assert.Equal("Player 2 Wins", testRSPGame.CheckWhoWins("Scissor", "Rock"));
    }

    [Fact]
    public void CheckWhoWins_WhenTheInputIsScissorVsPaper_User1Wins()
    {
      RSPGame testRSPGame = new RSPGame();
      Assert.Equal("Player 1 Wins", testRSPGame.CheckWhoWins("Scissor", "Paper"));
    }
    [Fact]
    public void CheckWhoWins_WhenTheInputIsPaperVsRock_User1Wins()
    {
      RSPGame testRSPGame = new RSPGame();
      Assert.Equal("Player 1 Wins", testRSPGame.CheckWhoWins("Paper", "Rock"));
    }
    [Fact]
    public void CheckWhoWins_WhenTheInputIsPaperVsScissor_User2Wins()
    {
      RSPGame testRSPGame = new RSPGame();
      Assert.Equal("Player 2 Wins", testRSPGame.CheckWhoWins("Paper", "Scissor"));
    }
  }
}
