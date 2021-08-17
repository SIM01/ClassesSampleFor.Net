using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SampleForSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Figure() {Name = "Triangle", SideCount = 3, SideLength = 1};
            List<Figure> figList = new List<Figure>() {triangle, triangle, triangle};
            var serTriangle = JsonConvert.SerializeObject(triangle);
            var serfigList = JsonConvert.SerializeObject(figList);
            var desTriangle = JsonConvert.DeserializeObject<Figure>(serTriangle);
            var desfigList = JsonConvert.DeserializeObject<List<Figure>>(serfigList);
            
        }
    }
}