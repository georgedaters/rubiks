using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rubiks.Tests
{
    [TestClass]
    public class CubeTests
    {
        [TestMethod]
        public void CubiesHaveDefaultOrientation()
        {
            var cube = Cube.Default;

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    for (int z = 0; z < 3; z++)
                    {
                        cube.Cubies[x, y, z][Face.Up].Should().Be(FaceColour.White);
                        cube.Cubies[x, y, z][Face.Down].Should().Be(FaceColour.Yellow);
                        cube.Cubies[x, y, z][Face.Front].Should().Be(FaceColour.Green);
                        cube.Cubies[x, y, z][Face.Left].Should().Be(FaceColour.Orange);
                        cube.Cubies[x, y, z][Face.Right].Should().Be(FaceColour.Red);
                        cube.Cubies[x, y, z][Face.Back].Should().Be(FaceColour.Blue);
                    }
                }
            }
        }
        
        // TODO: Rotation tests - omitted for brevity
    }
}
