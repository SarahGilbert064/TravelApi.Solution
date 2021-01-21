using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelClient.Models;

namespace TravelClient.Controllers
{
  public class LocationsController : Controller
  {
    public IActionResult Index()
    {
      var allLocations = Location.GetLocations();
      return View(allLocations);
    }
  }
}