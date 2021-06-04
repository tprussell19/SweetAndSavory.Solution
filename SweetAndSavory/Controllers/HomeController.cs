using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SweetAndSavory.Models;
using System.Collections.Generic;
using System.Linq;

namespace SweetAndSavory.Controllers
{
  public class HomeController : Controller
  {
    private readonly SweetAndSavoryContext _db;

    public HomeController(SweetAndSavoryContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.Treats = _db.Treats.ToList();
      ViewBag.Flavors = _db.Flavors.ToList();
      return View();
    }
  }
}