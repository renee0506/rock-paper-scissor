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
    }
  }
}
