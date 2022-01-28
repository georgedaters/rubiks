using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubiks.Scenarios;

namespace Rubiks.Tests
{
    [TestClass]
    public class ScenarioTests
    {
        [TestMethod]
        public void CustomScenario1()
        {
            var cube = Cube.Default;
            Scenarios.CustomScenario1.Run(cube);

            // Front
            cube.Cubies[0, 0, 0][Face.Front].Should().Be(FaceColour.White);
            cube.Cubies[1, 0, 0][Face.Front].Should().Be(FaceColour.White);
            cube.Cubies[2, 0, 0][Face.Front].Should().Be(FaceColour.White);
            cube.Cubies[0, 1, 0][Face.Front].Should().Be(FaceColour.Orange);
            cube.Cubies[1, 1, 0][Face.Front].Should().Be(FaceColour.Green);
            cube.Cubies[2, 1, 0][Face.Front].Should().Be(FaceColour.White);
            cube.Cubies[0, 2, 0][Face.Front].Should().Be(FaceColour.Orange);
            cube.Cubies[1, 2, 0][Face.Front].Should().Be(FaceColour.Red);
            cube.Cubies[2, 2, 0][Face.Front].Should().Be(FaceColour.Red);

            // Up
            cube.Cubies[0, 2, 0][Face.Up].Should().Be(FaceColour.Blue);
            cube.Cubies[1, 2, 0][Face.Up].Should().Be(FaceColour.Blue);
            cube.Cubies[2, 2, 0][Face.Up].Should().Be(FaceColour.Blue);
            cube.Cubies[0, 2, 1][Face.Up].Should().Be(FaceColour.Blue);
            cube.Cubies[1, 2, 1][Face.Up].Should().Be(FaceColour.White);
            cube.Cubies[2, 2, 1][Face.Up].Should().Be(FaceColour.White);
            cube.Cubies[0, 2, 2][Face.Up].Should().Be(FaceColour.Red);
            cube.Cubies[1, 2, 2][Face.Up].Should().Be(FaceColour.Orange);
            cube.Cubies[2, 2, 2][Face.Up].Should().Be(FaceColour.Green);

            // TODO: Test other sides
        }
    }
}
