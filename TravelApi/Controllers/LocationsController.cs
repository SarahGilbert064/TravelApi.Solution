using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelApi.Models;

namespace TravelApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class LocationsController : ControllerBase
  {
    private TravelApiContext _db;

    public LocationsController(TravelApiContext db)
    {
      _db = db;
    }

    //Get api/locations
    [HttpGet]
    public ActionResult<IEnumerable<Location>> Get()
    {
      return _db.Locations.ToList();
    }
    // Get specific Location from api
    [HttpGet("{id}")]
    public ActionResult<Location> Get(int id)
    {
        return _db.Locations.FirstOrDefault(entry => entry.LocationId == id);
    }

    [HttpPost]
    public void Post([FromBody] Location location)
    {
      _db.Locations.Add(location);
      _db.SaveChanges();
    }
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Location location)
    {
        location.LocationId = id;
        _db.Entry(location).State = EntityState.Modified;
        _db.SaveChanges();
    }
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        var locationToDelete = _db.Locations.FirstOrDefault(entry => entry.LocationId  == id);
        _db.Locations.Remove(locationToDelete);
        _db.SaveChanges();
    }
  }
}