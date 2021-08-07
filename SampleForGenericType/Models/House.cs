namespace SampleForGenericType.Models
{
    public class House:ICost
    {
        public string Location { get; set; }
        public int Square { get; set; }
        public double Cost { get; set; } 
    }
}