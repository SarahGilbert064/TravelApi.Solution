namespace TravelApi 
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Body { get; set; }
        public string UserName { get; set; }
        public int LocationId { get; set; }
        // public virtual Location Location { get; set; }
    }
}