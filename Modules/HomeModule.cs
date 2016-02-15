using Nancy;
using System.Collections.Generic;

namespace L33tSpeak
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
          return View["index.cshtml"];
      };
      Post["/"] = _ => {
          string newTranslator =  Translator.Translate(Request.Form["userNumber"]);
        return View["index.cshtml", newTranslator];
      };
    }
  }
}
