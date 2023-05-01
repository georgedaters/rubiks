using System;

namespace Rubiks.UI
{
    /// <summary>
    /// Prints an exploded view of the cube onto the console
    /// </summary>
    public class ExplodedCubePrinter
    {
        /// <summary>
        /// The printed character used to represent a face
        /// </summary>
        public char FaceCharacter { get; set; } = '\u25A0'; // Unicode square

        /// <summary>
        /// Number of spaces to leave between each face character - compensates for default console line spacing
        /// </summary>
        private const int horizontalSpacing = 1;

        /// <summary>
        /// Prints an exploded view of the cube onto the console
        /// </summary>
        /// <param name="cube"></param>
        public void Print(Cube cube)
        {
            var initialConsoleColor = Console.ForegroundColor;

            try
            {
                Console.Clear();
                PrintFront(cube);
                PrintUp(cube);
                PrintLeft(cube);
                PrintRight(cube);
                PrintBack(cube);
                PrintDown(cube);
            }
            catch
            {
                Console.ForegroundColor = initialConsoleColor;
                throw;
            }
            finally
            {
                Console.ForegroundColor = initialConsoleColor;
            }
        }

        private void PrintFront(Cube cube)
        {
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    SetCursorPosition(1, 1, x, y);

                    // Map screen space (x, y) into the cubes 3d space (x, y, z)
                    Console.ForegroundColor = GetConsoleColorFromFaceColour(cube.Cubies[x, 2 - y, 0][Face.Front]);
                    Console.Write(FaceCharacter);
                    for (int space = 0; space < horizontalSpacing; space++)
                    {
                        Console.Write(" ");
                    }
                }
            }
        }

        private void PrintUp(Cube cube)
        {
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    SetCursorPosition(1, 0, x, y);

                    // Map screen space (x, y) into the cubes 3d space (x, y, z)
                    Console.ForegroundColor = GetConsoleColorFromFaceColour(cube.Cubies[x, 2, 2 - y][Face.Up]);
                    Console.Write(FaceCharacter);
                    for (int space = 0; space < horizontalSpacing; space++)
                    {
                        Console.Write(" ");
                    }
                }
            }
        }

        private void PrintLeft(Cube cube)
        {
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    SetCursorPosition(0, 1, x, y);

                    // Map screen space (x, y) into the cubes 3d space (x, y, z)
                    Console.ForegroundColor = GetConsoleColorFromFaceColour(cube.Cubies[0, 2 - y, 2 - x][Face.Left]);
                    Console.Write(FaceCharacter);
                    for (int space = 0; space < horizontalSpacing; space++)
                    {
                        Console.Write(" ");
                    }
                }
            }
        }

        private void PrintBack(Cube cube)
        {
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    SetCursorPosition(3, 1, x, y);

                    // Map screen space (x, y) into the cubes 3d space (x, y, z)
                    Console.ForegroundColor = GetConsoleColorFromFaceColour(cube.Cubies[2 - x, 2 - y, 2][Face.Back]);
                    Console.Write(FaceCharacter);
                    for (int space = 0; space < horizontalSpacing; space++)
                    {
                        Console.Write(" ");
                    }
                }
            }
        }

        private void PrintRight(Cube cube)
        {
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    SetCursorPosition(2, 1, x, y);

                    // Map screen space (x, y) into the cubes 3d space (x, y, z)
                    Console.ForegroundColor = GetConsoleColorFromFaceColour(cube.Cubies[2, 2 - y, x][Face.Right]);
                    Console.Write(FaceCharacter);
                    for (int space = 0; space < horizontalSpacing; space++)
                    {
                        Console.Write(" ");
                    }
                }
            }
        }

        private void PrintDown(Cube cube)
        {
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    SetCursorPosition(1, 2, x, y);

                    // Map screen space (x, y) into the cubes 3d space (x, y, z)
                    Console.ForegroundColor = GetConsoleColorFromFaceColour(cube.Cubies[x, 0, y][Face.Down]);
                    Console.Write(FaceCharacter);
                    for (int space = 0; space < horizontalSpacing; space++)
                    {
                        Console.Write(" ");
                    }
                }
            }
        }

        private void SetCursorPosition(int facePosY, int facePosX, int x, int y)
        {
            Console.SetCursorPosition(facePosY * 3 * (1 + horizontalSpacing) + (x * (horizontalSpacing + 1)), facePosX * 3 + y);
        }

        /// <summary>
        /// Gets the <see cref="ConsoleColor"/> to represent a cube face colour
        /// </summary>
        /// <param name="faceColour"></param>
        /// <returns></returns>
        private ConsoleColor GetConsoleColorFromFaceColour(int faceColour)
        {
            switch (faceColour)
            {
                case FaceColour.Red:
                    return ConsoleColor.Red;
                case FaceColour.Blue:
                    return ConsoleColor.Blue;
                case FaceColour.Yellow:
                    return ConsoleColor.Yellow;
                case FaceColour.White:
                    return ConsoleColor.White;
                case FaceColour.Green:
                    return ConsoleColor.Green;
                case FaceColour.Orange:
                    return ConsoleColor.DarkYellow;
            }

            throw new NotImplementedException();
        }
    }
}
