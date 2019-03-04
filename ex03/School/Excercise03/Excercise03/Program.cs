using Excercise03.SampleLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Excercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Random number: {RNGenerator.GetNext()}");
            OverFlowUnderFlow.DoIt();
            ConversionTest.DoIt();
        }
    }
}
