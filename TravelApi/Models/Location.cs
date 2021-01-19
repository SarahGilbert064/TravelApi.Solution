using System.Collections.Generic;

namespace TravelApi 
{
    public class Location
    {
      public Location()
      {
        this.JoinEntries = new HashSet<LocationReview>();
      }
        public int LocationId { get; set; }
        public string Name { get; set; }
        public string Rating { get; set; }
        public string Pros { get; set; }
        public string Cons { get; set; }

        public ICollection<LocationReview> JoinEntries { get; }
    }
}