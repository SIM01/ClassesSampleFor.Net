using System;
using SampleForGenericType.Models;

namespace SampleForGenericType
{
    class Program
    {
        static void Main(string[] args)
        {
            var clientCat = new Animals() {Cost = 1};
            var clientAutomobile = new Automobile() {Cost = 1000};
            var clientHouse = new House() {Cost = 100000};

            var propCalc = new PropertyCalculator<ICost>();
            propCalc.Add(clientCat);
            propCalc.Add(clientAutomobile);
            propCalc.Add(clientHouse);
        }
    }
}