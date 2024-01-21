using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; } //hello() represents a route. creates special path/pattern in app.
    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }
    [Route("/")] //root path. home page.
    //Actionresult is built in MVC class that handles rendering views. return type. View() is built in method from .mvc namespace
    public ActionResult Letter() 
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Lina";
      myLetterVariable.Sender = "Jasmine";
      return View(myLetterVariable);
    } 
    [Route("/form")]
    public ActionResult Form() { return View(); }
    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender)
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = recipient;
      myLetterVariable.Sender = sender;
      return View(myLetterVariable);
    }
  }
}