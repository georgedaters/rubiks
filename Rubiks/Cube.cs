namespace Rubiks
{
    /// <summary>
    /// Defines a rubiks cube consisting of a 3x3 array of cubies
    /// </summary>
    public class Cube
    {
        public Cubie[,,] Cubies = new Cubie[3, 3, 3];

        /// <summary>
        /// Gets a cube instance with the default orientation (white up, green front)
        /// </summary>
        public static Cube Default
        {
            get
            {
                var cube = new Cube();
                for (int x = 0; x < 3; x++)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        for (int z = 0; z < 3; z++)
                        {
                            cube.Cubies[x, y, z] = Cubie.Default;
                        }
                    }
                }

                return cube;
            }
        }

        /// <summary>
        /// Creates a new cube with the same orientation as this instance
        /// </summary>
        /// <returns></returns>
        private Cube Copy()
        {
            var cube = new Cube();
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    for (int z = 0; z < 3; z++)
                    {
                        cube.Cubies[x, y, z] = this.Cubies[x, y, z].Copy();
                    }
                }
            }

            return cube;
        }

        public void RotateFrontClockwise()
        {
            this.RotateFaceAroundZAxis(0);
        }

        public void RotateFrontCounterClockwise()
        {
            this.RotateFaceAroundZAxisInverse(0);
        }

        public void RotateBackClockwise()
        {
            this.RotateFaceAroundZAxisInverse(2);
        }

        public void RotateBackCounterClockwise()
        {
            this.RotateFaceAroundZAxis(2);
        }

        public void RotateRightClockwise()
        {
            this.RotateFaceAroundXAxis(2);
        }

        public void RotateRightCounterClockwise()
        {
            this.RotateFaceAroundXAxisInverse(2);
        }

        public void RotateLeftClockwise()
        {
            this.RotateFaceAroundXAxisInverse(0);
        }

        public void RotateLeftCounterClockwise()
        {
            this.RotateFaceAroundXAxis(0);
        }

        public void RotateUpClockwise()
        {
            this.RotateFaceAroundYAxis(2);
        }

        public void RotateUpCounterClockwise()
        {
            this.RotateFaceAroundYAxisInverse(2);
        }

        public void RotateDownClockwise()
        {
            this.RotateFaceAroundYAxisInverse(0);
        }

        public void RotateDownCounterClockwise()
        {
            this.RotateFaceAroundYAxis(0);
        }

        /// <summary>
        /// Rotates a face 90 degrees around the x-axis
        /// </summary>
        /// <param name="x">The index of the face to rotate (0 == Left face, 2 == Right face)</param>
        public void RotateFaceAroundXAxis(int x)
        {
            // Rotate cubies
            for (int y = 0; y < 3; y++)
            {
                for (int z = 0; z < 3; z++)
                {
                    this.Cubies[x, y, z].RotateAroundXAxis();
                }
            }

            // Swap cubies
            var copy = this.Copy();
            this.Cubies[x, 0, 0] = copy.Cubies[x, 0, 2];
            this.Cubies[x, 1, 0] = copy.Cubies[x, 0, 1];
            this.Cubies[x, 2, 0] = copy.Cubies[x, 0, 0];
            this.Cubies[x, 2, 1] = copy.Cubies[x, 1, 0];
            this.Cubies[x, 2, 2] = copy.Cubies[x, 2, 0];
            this.Cubies[x, 1, 2] = copy.Cubies[x, 2, 1];
            this.Cubies[x, 0, 2] = copy.Cubies[x, 2, 2];
            this.Cubies[x, 0, 1] = copy.Cubies[x, 1, 2];
        }

        /// <summary>
        /// Rotates a face 90 degrees around the x-axis
        /// </summary>
        /// <param name="x">The index of the face to rotate (0 == Left face, 2 == Right face)</param>
        public void RotateFaceAroundXAxisInverse(int x)
        {
            // Rotate cubies
            for (int y = 0; y < 3; y++)
            {
                for (int z = 0; z < 3; z++)
                {
                    this.Cubies[x, y, z].RotateAroundXAxisInverse();
                }
            }

            // Swap cubies
            var copy = this.Copy();
            this.Cubies[x, 0, 0] = copy.Cubies[x, 2, 0];
            this.Cubies[x, 0, 1] = copy.Cubies[x, 1, 0];
            this.Cubies[x, 0, 2] = copy.Cubies[x, 0, 0];
            this.Cubies[x, 1, 2] = copy.Cubies[x, 0, 1];
            this.Cubies[x, 2, 2] = copy.Cubies[x, 0, 2];
            this.Cubies[x, 2, 1] = copy.Cubies[x, 1, 2];
            this.Cubies[x, 2, 0] = copy.Cubies[x, 2, 2];
            this.Cubies[x, 1, 0] = copy.Cubies[x, 2, 1];
        }

        /// <summary>
        /// Rotates a face 90 degrees around the y-axis
        /// </summary>
        /// <param name="y">The index of the face to rotate (0 == Down face, 2 == Up face)</param>
        public void RotateFaceAroundYAxis(int y)
        {
            // Rotate cubies
            for (int x = 0; x < 3; x++)
            {
                for (int z = 0; z < 3; z++)
                {
                    this.Cubies[x, y, z].RotateAroundYAxis();
                }
            }

            // Swap cubies
            var copy = this.Copy();
            this.Cubies[0, y, 0] = copy.Cubies[2, y, 0];
            this.Cubies[0, y, 1] = copy.Cubies[1, y, 0];
            this.Cubies[0, y, 2] = copy.Cubies[0, y, 0];
            this.Cubies[1, y, 2] = copy.Cubies[0, y, 1];
            this.Cubies[2, y, 2] = copy.Cubies[0, y, 2];
            this.Cubies[2, y, 1] = copy.Cubies[1, y, 2];
            this.Cubies[2, y, 0] = copy.Cubies[2, y, 2];
            this.Cubies[1, y, 0] = copy.Cubies[2, y, 1];
        }

        /// <summary>
        /// Rotates a face -90 degrees around the y-axis
        /// </summary>
        /// <param name="y">The index of the face to rotate (0 == Down face, 2 == Up face)</param>
        public void RotateFaceAroundYAxisInverse(int y)
        {
            // Rotate cubies
            for (int x = 0; x < 3; x++)
            {
                for (int z = 0; z < 3; z++)
                {
                    this.Cubies[x, y, z].RotateAroundYAxisInverse();
                }
            }

            // Swap cubies
            var copy = this.Copy();
            this.Cubies[0, y, 0] = copy.Cubies[0, y, 2];
            this.Cubies[1, y, 0] = copy.Cubies[0, y, 1];
            this.Cubies[2, y, 0] = copy.Cubies[0, y, 0];
            this.Cubies[2, y, 1] = copy.Cubies[1, y, 0];
            this.Cubies[2, y, 2] = copy.Cubies[2, y, 0];
            this.Cubies[1, y, 2] = copy.Cubies[2, y, 1];
            this.Cubies[0, y, 2] = copy.Cubies[2, y, 2];
            this.Cubies[0, y, 1] = copy.Cubies[1, y, 2];
        }

        /// <summary>
        /// Rotates a face 90 degrees around the z-axis
        /// </summary>
        /// <param name="z">The index of the face to rotate (0 == Front face, 2 == Back face)</param>
        public void RotateFaceAroundZAxis(int z)
        {
            // Rotate cubies
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    this.Cubies[x, y, z].RotateAroundZAxis();
                }
            }

            // Swap cubies
            var copy = this.Copy();
            this.Cubies[0, 0, z] = copy.Cubies[2, 0, z];
            this.Cubies[0, 1, z] = copy.Cubies[1, 0, z];
            this.Cubies[0, 2, z] = copy.Cubies[0, 0, z];
            this.Cubies[1, 2, z] = copy.Cubies[0, 1, z];
            this.Cubies[2, 2, z] = copy.Cubies[0, 2, z];
            this.Cubies[2, 1, z] = copy.Cubies[1, 2, z];
            this.Cubies[2, 0, z] = copy.Cubies[2, 2, z];
            this.Cubies[1, 0, z] = copy.Cubies[2, 1, z];
        }

        /// <summary>
        /// Rotates a face -90 degrees around the z-axis
        /// </summary>
        /// <param name="z">The index of the face to rotate (0 == Front face, 2 == Back face)</param>
        public void RotateFaceAroundZAxisInverse(int z)
        {
            // Rotate cubies
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    this.Cubies[x, y, z].RotateAroundZAxisInverse();
                }
            }

            // Swap cubies
            var copy = this.Copy();
            this.Cubies[0, 0, z] = copy.Cubies[0, 2, z];
            this.Cubies[1, 0, z] = copy.Cubies[0, 1, z];
            this.Cubies[2, 0, z] = copy.Cubies[0, 0, z];
            this.Cubies[2, 1, z] = copy.Cubies[1, 0, z];
            this.Cubies[2, 2, z] = copy.Cubies[2, 0, z];
            this.Cubies[1, 2, z] = copy.Cubies[2, 1, z];
            this.Cubies[0, 2, z] = copy.Cubies[2, 2, z];
            this.Cubies[0, 1, z] = copy.Cubies[1, 2, z];
        }
    }
}
