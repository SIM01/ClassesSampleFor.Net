using System;
using System.Reflection;

namespace SampleForReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Type myType = typeof(Figure);
            var myProperty = myType.GetProperties();
            var myMethods = myType.GetMethods(BindingFlags.Default);

            var triangle = new Figure() {Name = "Triangle", SideCount = 3, SideLength = 1};
            var myType2 = triangle.GetType();

            var myType3 = Type.GetType("SampleForReflection.Figure",false,true);
        }
    }
}