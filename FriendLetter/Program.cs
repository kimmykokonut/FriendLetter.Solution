using Microsoft.AspNetCore.Builder; //namespace. access tools to create/config web app host
using Microsoft.Extensions.DependencyInjection; //namespace. access tools to create services within web app that get added to web app via dependency injection.

namespace FriendLetter
{
  class Program
  {
    static void Main(string[] args)
    {
      WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

      builder.Services.AddControllersWithViews(); //customize builder by enabling MVC framework as a service

      WebApplication app = builder.Build(); //create actual host

      app.UseRouting(); //want host to match website url to routes we create in app

      app.MapControllerRoute( //establish convention for routes to follow
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
      );

      app.Run(); //runs the host
    }
  }
}