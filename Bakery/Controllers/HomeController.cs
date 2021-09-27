using Bakery.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bakery.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Storefront() { return View(); }
  }
}