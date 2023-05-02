# Rubiks cube coding challenge

## Project outline

- Write an application to simulate a rubiks cube.
- Write code to print out the state of the cube

## Additional instructions

The initial state of the cube should be in the solved state.

Print out the state of the cube after the following rotations:

- Front face CW
- Right face CCW
- Up face CW
- Back face CCW
- Left face CW
- Down face CCW

Use the following site to verify the output of this application:
https://rubiks-cube-solver.com/

## Explanation

### Model

The Rubiks cube has been modelled as a 3 dimensional array of 9 smaller cubes (cubies).

** Cube.cs
```csharp
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
```

The 3 dimensions of the array represent the X,Y,Z axes in a left-handed (y-up) coordinate system.

Therefore index [1, 2, 1] represents the top middle cubie. Index [0, 0, 0] represents the bottom cube at the front left.

A cubie is an array of the 6 coloured sides, each indexed according to the values in 'Face.cs'. The values in the array are one of the 6 face colours 'FaceColour.cs' 

### Manpulating the cube

There are 12 possible movements that can be applied to a rubiks cube. There are 6 sides that can be rotated in one of two directions (clockwise or counter-clockwise).

The 12 possible movements are applied using the public methods of the 'Cube.cs' class.

## Example usage

Create a new rubiks cube, rotate one face and print out the result
```csharp
var cube = Cube.Default;
cube.RotateFrontClockwise();
new ExplodedCubePrinter().Print(cube);
```

## Run instructions: 

With working directory being the folder containing this Readme, run either the following:

dotnet run --project Rubiks.UI 

dotnet test --project Rubiks.Tests
