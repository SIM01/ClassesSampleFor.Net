using System;
using System.Collections.Generic;

namespace SampleForEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var square1 = new Figure() {SideCount = 4, SideLenght = 1};
            var square2 = new Figure() {SideCount = 4, SideLenght = 1};
            var square3 = square1;

            bool status1 = square1 == square2;
            bool status2 = square1 == square3;

            bool status3 = square1.Equals(square2);
            bool status4 = square1.Equals(square3);

            List<Figure> figures = new List<Figure>();
            figures.Add(square1);
            figures.AddRange(new Figure[] {square2, square3});

            int count = figures.Count;

            bool status = figures.Contains(square3);

            figures.Remove(square3);
            figures.Clear();
            

        }
    }
}