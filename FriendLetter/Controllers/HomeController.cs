using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; } //hello() represents a route. creates special path/pattern in app.
    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }
    [Route("/")]
    public string Letter() { return "Our virtual postcard will go here soon!";}
  }
}