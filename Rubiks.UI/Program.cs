using Rubiks.Scenarios;
using System;

namespace Rubiks.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cube = Cube.Default;
            TTCScenario1.Run(cube);
            new ExplodedCubePrinter().Print(cube);

            Console.ReadKey(true);
        }
    }
}
