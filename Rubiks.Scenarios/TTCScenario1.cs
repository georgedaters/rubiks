namespace Rubiks.Scenarios
{
    public static class TTCScenario1
    {
        public static void Run(Cube cube)
        {
            cube.RotateFrontClockwise();
            cube.RotateRightCounterClockwise();
            cube.RotateUpClockwise();
            cube.RotateBackCounterClockwise();
            cube.RotateLeftClockwise();
            cube.RotateDownCounterClockwise();
        }
    }
}
