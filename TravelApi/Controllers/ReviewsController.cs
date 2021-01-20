using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelApi.Models;

namespace TravelApi.Controllers
{
  [ApiVersion("1.0")]
  [Route("api/[controller]")]
  [ApiController]
  public class ReviewsController : ControllerBase
  {
    private TravelApiContext _db;

    public ReviewsController(TravelApiContext db)
    {
      _db = db;
    }

    //Get api/reviews
    [HttpGet]
    public ActionResult<IEnumerable<Review>> Get(string body, string userName)
    {
      var query = _db.Reviews.AsQueryable();

      if (body != null)
      {
        query = query.Where(entry => entry.Body == body);
      }

      if (userName != null)
      {
        query = query.Where(entry => entry.UserName == userName);
      }

      return query.ToList();
    }

    // Get specific Location from api
    [HttpGet("{id}")]
    public ActionResult<Review> Get(int id)
    {
      return _db.Reviews.FirstOrDefault(entry => entry.ReviewId == id);
    }

    [HttpPost]
    public void Post([FromBody] Review review)
    {
      _db.Reviews.Add(review);
      _db.SaveChanges();
    }

    [HttpPut("{id}")]
    // [Authorize("{userName}")]
    public void Put(int id, [FromBody] Review review)
    {      
        Console.WriteLine(review.UserName);
        review.ReviewId = id;
        _db.Entry(review).State = EntityState.Modified;
        _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        var reviewToDelete = _db.Reviews.FirstOrDefault(entry => entry.ReviewId  == id);
        _db.Reviews.Remove(reviewToDelete);
        _db.SaveChanges();
    }
  }
}