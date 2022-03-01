using Microsoft.AspNetCore.Mvc;

namespace BoardGameCollection.Controllers

{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Form()
    {
      return View();
    }
  }
}