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
      Get["/playvscomputer"] = _ => View["vsAI_index.cshtml"];
      Get["/VSAI-results"] = _ =>{
        string userInput = Request.Query["user-input"];
        Random random = new Random();
        int randomNumber = random.Next(1, 4);
        Dictionary<int, string> converter = new Dictionary<int, string>(){{1, "Rock"},{2, "Scissor"}, {3, "Paper"}};
        RSPGame newRSPGame = new RSPGame();
        Dictionary<string, string> model = new Dictionary<string, string>();
        string computerInput = converter[randomNumber];
        model.Add("computerInput", computerInput);
        string result = newRSPGame.CheckWhoWins(userInput, computerInput);
        model.Add("result", result);
        return View["vsAi_result.cshtml", model];
      };
    }
  }
}
