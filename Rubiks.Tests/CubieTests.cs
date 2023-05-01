using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rubiks.Tests
{
    [TestClass]
    public class CubieTests
    {
        [TestMethod]
        public void CanRotateAroundXAxis()
        {
            var cubie = Cubie.Default;
            cubie.RotateAroundXAxis();

            cubie[Face.Up].Should().Be(FaceColour.Green);
            cubie[Face.Down].Should().Be(FaceColour.Blue);
            cubie[Face.Front].Should().Be(FaceColour.Yellow);
            cubie[Face.Back].Should().Be(FaceColour.White);

            cubie[Face.Left].Should().Be(FaceColour.Orange);
            cubie[Face.Right].Should().Be(FaceColour.Red);
        }

        [TestMethod]
        public void CanRotateAroundXAxisInverse()
        {
            var cubie = Cubie.Default;
            cubie.RotateAroundXAxisInverse();

            cubie[Face.Up].Should().Be(FaceColour.Blue);
            cubie[Face.Down].Should().Be(FaceColour.Green);
            cubie[Face.Front].Should().Be(FaceColour.White);
            cubie[Face.Back].Should().Be(FaceColour.Yellow);

            cubie[Face.Left].Should().Be(FaceColour.Orange);
            cubie[Face.Right].Should().Be(FaceColour.Red);
        }

        [TestMethod]
        public void CanRotateAroundYAxis()
        {
            var cubie = Cubie.Default;
            cubie.RotateAroundYAxis();

            cubie[Face.Front].Should().Be(FaceColour.Red);
            cubie[Face.Right].Should().Be(FaceColour.Blue);
            cubie[Face.Back].Should().Be(FaceColour.Orange);
            cubie[Face.Left].Should().Be(FaceColour.Green);

            cubie[Face.Up].Should().Be(FaceColour.White);
            cubie[Face.Down].Should().Be(FaceColour.Yellow);
        }

        [TestMethod]
        public void CanRotateAroundYAxisInverse()
        {
            var cubie = Cubie.Default;
            cubie.RotateAroundYAxisInverse();

            cubie[Face.Front].Should().Be(FaceColour.Orange);
            cubie[Face.Right].Should().Be(FaceColour.Green);
            cubie[Face.Back].Should().Be(FaceColour.Red);
            cubie[Face.Left].Should().Be(FaceColour.Blue);

            cubie[Face.Up].Should().Be(FaceColour.White);
            cubie[Face.Down].Should().Be(FaceColour.Yellow);
        }

        [TestMethod]
        public void CanRotateAroundZAxis()
        {
            var cubie = Cubie.Default;
            cubie.RotateAroundZAxis();

            cubie[Face.Up].Should().Be(FaceColour.Orange);
            cubie[Face.Right].Should().Be(FaceColour.White);
            cubie[Face.Down].Should().Be(FaceColour.Red);
            cubie[Face.Left].Should().Be(FaceColour.Yellow);

            cubie[Face.Front].Should().Be(FaceColour.Green);
            cubie[Face.Back].Should().Be(FaceColour.Blue);
        }

        [TestMethod]
        public void CanRotateAroundZAxisInverse()
        {
            var cubie = Cubie.Default;
            cubie.RotateAroundZAxisInverse();

            cubie[Face.Up].Should().Be(FaceColour.Red);
            cubie[Face.Right].Should().Be(FaceColour.Yellow);
            cubie[Face.Down].Should().Be(FaceColour.Orange);
            cubie[Face.Left].Should().Be(FaceColour.White);

            cubie[Face.Front].Should().Be(FaceColour.Green);
            cubie[Face.Back].Should().Be(FaceColour.Blue);
        }
    }
}
