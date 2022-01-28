using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rubiks.Tests
{
    [TestClass]
    public class OrientationTests
    {
        [TestMethod]
        public void CanRotateAroundXAxis()
        {
            var orientation = Orientation.Default;
            orientation.RotateAroundXAxis();

            orientation[Face.Up].Should().Be(FaceColour.Green);
            orientation[Face.Down].Should().Be(FaceColour.Blue);
            orientation[Face.Front].Should().Be(FaceColour.Yellow);
            orientation[Face.Back].Should().Be(FaceColour.White);

            orientation[Face.Left].Should().Be(FaceColour.Orange);
            orientation[Face.Right].Should().Be(FaceColour.Red);
        }

        [TestMethod]
        public void CanRotateAroundXAxisInverse()
        {
            var orientation = Orientation.Default;
            orientation.RotateAroundXAxisInverse();

            orientation[Face.Up].Should().Be(FaceColour.Blue);
            orientation[Face.Down].Should().Be(FaceColour.Green);
            orientation[Face.Front].Should().Be(FaceColour.White);
            orientation[Face.Back].Should().Be(FaceColour.Yellow);

            orientation[Face.Left].Should().Be(FaceColour.Orange);
            orientation[Face.Right].Should().Be(FaceColour.Red);
        }

        [TestMethod]
        public void CanRotateAroundYAxis()
        {
            var orientation = Orientation.Default;
            orientation.RotateAroundYAxis();

            orientation[Face.Front].Should().Be(FaceColour.Red);
            orientation[Face.Right].Should().Be(FaceColour.Blue);
            orientation[Face.Back].Should().Be(FaceColour.Orange);
            orientation[Face.Left].Should().Be(FaceColour.Green);

            orientation[Face.Up].Should().Be(FaceColour.White);
            orientation[Face.Down].Should().Be(FaceColour.Yellow);
        }

        [TestMethod]
        public void CanRotateAroundYAxisInverse()
        {
            var orientation = Orientation.Default;
            orientation.RotateAroundYAxisInverse();

            orientation[Face.Front].Should().Be(FaceColour.Orange);
            orientation[Face.Right].Should().Be(FaceColour.Green);
            orientation[Face.Back].Should().Be(FaceColour.Red);
            orientation[Face.Left].Should().Be(FaceColour.Blue);

            orientation[Face.Up].Should().Be(FaceColour.White);
            orientation[Face.Down].Should().Be(FaceColour.Yellow);
        }

        [TestMethod]
        public void CanRotateAroundZAxis()
        {
            var orientation = Orientation.Default;
            orientation.RotateAroundZAxis();

            orientation[Face.Up].Should().Be(FaceColour.Orange);
            orientation[Face.Right].Should().Be(FaceColour.White);
            orientation[Face.Down].Should().Be(FaceColour.Red);
            orientation[Face.Left].Should().Be(FaceColour.Yellow);

            orientation[Face.Front].Should().Be(FaceColour.Green);
            orientation[Face.Back].Should().Be(FaceColour.Blue);
        }

        [TestMethod]
        public void CanRotateAroundZAxisInverse()
        {
            var orientation = Orientation.Default;
            orientation.RotateAroundZAxisInverse();

            orientation[Face.Up].Should().Be(FaceColour.Red);
            orientation[Face.Right].Should().Be(FaceColour.Yellow);
            orientation[Face.Down].Should().Be(FaceColour.Orange);
            orientation[Face.Left].Should().Be(FaceColour.White);

            orientation[Face.Front].Should().Be(FaceColour.Green);
            orientation[Face.Back].Should().Be(FaceColour.Blue);
        }
    }
}
