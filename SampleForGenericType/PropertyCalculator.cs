using SampleForGenericType.Models;

namespace SampleForGenericType
{
    public class PropertyCalculator<T> where T : ICost
    {
        public double TotalCost { get; set; }

        //public void Add<T,U>(T property,U myProp) where T : ICost where U : Animal
        public void Add(T property)
        {
            TotalCost = TotalCost + property.Cost;
        }
    }
}