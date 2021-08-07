namespace SampleForGenericType.Models
{
    public class Automobile:ICost
    {
        public string Model { get; set; }
        public long Miles { get; set; }
        public double Cost { get; set; }

    }
}