using Nancy;
using System.Collections.Generic;
using AnagramListChecker.Objects;

namespace AnagramListChecker {

  public class HomeModule : NancyModule {

    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/result"] = _ => {
        string primaryInput = Request.Form["primary-input"];
        List <string> listToTest = new List<string>{};
        listToTest.Add(Request.Form["first-input"]);
        listToTest.Add(Request.Form["second-input"]);
        listToTest.Add(Request.Form["third-input"]);
        listToTest.Add(Request.Form["fourth-input"]);
        listToTest.Add(Request.Form["fifth-input"]);
        listToTest.Add(Request.Form["sixth-input"]);
        Anagram newAnagram = new Anagram();
        List <string> result = newAnagram.AnagramChecker(primaryInput, listToTest);
        return View["result.cshtml", result];
      };
    }
  }
}
