using Nancy;
using RSP;
using System;
using System.Collections.Generic;

namespace RSP
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Get["/Results"] = _ => {
        string userInput1 = Request.Query["user-input1"];
        string userInput2 = Request.Query["user-input2"];
        RSPGame newRSPGame = new RSPGame();
        string result = newRSPGame.CheckWhoWins(userInput1, userInput2);
        return View["result.cshtml", result];
      };
    }
  }
}
