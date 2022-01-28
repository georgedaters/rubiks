using System.Linq;

namespace Rubiks
{
    /// <summary>
    /// Defines the orientation of a cubie
    /// </summary>
    public class Orientation
    {
        /// <summary>
        /// Defines the colours on each side of the cubie. The colour is a value from <see cref="FaceColour"/> indexed by a value from <see cref="Face"/>
        /// </summary>
        public int[] Sides { get; set; } = new int[6];

        /// <summary>
        /// Gets or sets the face colour of a side of the cube
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public int this[int i]
        {
            get { return this.Sides[i]; }
            set { this.Sides[i] = value; }
        }

        public Orientation Copy()
        {
            var copy = new Orientation();
            for (int i = 0; i < 6; i++)
            {
                copy[i] = this[i];
            }

            return copy;
        }

        /// <summary>
        /// Gets a new instance with the white up and green front 
        /// </summary>
        public static Orientation Default => new Orientation
        {
            Sides = Enumerable.Range(0, 6).ToArray()
        };

        /// <summary>
        /// Rotates 90 degrees around the x-axis
        /// </summary>
        public void RotateAroundXAxis()
        {
            var up = this[Face.Up];
            this[Face.Up] = this[Face.Front];
            this[Face.Front] = this[Face.Down];
            this[Face.Down] = this[Face.Back];
            this[Face.Back] = up;
        }

        /// <summary>
        /// Rotates -90 degrees around the x-axis
        /// </summary>
        public void RotateAroundXAxisInverse()
        {
            var up = this[Face.Up];
            this[Face.Up] = this[Face.Back];
            this[Face.Back] = this[Face.Down];
            this[Face.Down] = this[Face.Front];
            this[Face.Front] = up;
        }

        /// <summary>
        /// Rotates 90 degrees around the y-axis
        /// </summary>
        public void RotateAroundYAxis()
        {
            var front = this[Face.Front];
            this[Face.Front] = this[Face.Right];
            this[Face.Right] = this[Face.Back];
            this[Face.Back] = this[Face.Left];
            this[Face.Left] = front;
        }

        /// <summary>
        /// Rotates -90 degrees around the y-axis
        /// </summary>
        public void RotateAroundYAxisInverse()
        {
            var front = this[Face.Front];
            this[Face.Front] = this[Face.Left];
            this[Face.Left] = this[Face.Back];
            this[Face.Back] = this[Face.Right];
            this[Face.Right] = front;
        }


        /// <summary>
        /// Rotates 90 degrees around the z-axis
        /// </summary>
        public void RotateAroundZAxis()
        {
            var up = this[Face.Up];
            this[Face.Up] = this[Face.Left];
            this[Face.Left] = this[Face.Down];
            this[Face.Down] = this[Face.Right];
            this[Face.Right] = up;
        }

        /// <summary>
        /// Rotates -90 degrees around the z-axis
        /// </summary>
        public void RotateAroundZAxisInverse()
        {
            var up = this[Face.Up];
            this[Face.Up] = this[Face.Right];
            this[Face.Right] = this[Face.Down];
            this[Face.Down] = this[Face.Left];
            this[Face.Left] = up;
        }
    }
}
