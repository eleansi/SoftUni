namespace CohesionAndCoupling
{
    using System;

    class MainProgram
    {
        static void Main()
        {
            Console.WriteLine(FileNameGetter.GetFileExtension("example"));
            Console.WriteLine(FileNameGetter.GetFileExtension("example.pdf"));
            Console.WriteLine(FileNameGetter.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileNameGetter.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileNameGetter.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileNameGetter.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",PointLocator.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",PointLocator.CalcDistance3D(5, 2, -1, 3, -6, 4));

            DistanceCalculator figure1 = new DistanceCalculator(3, 4, 5);
            Console.WriteLine("Volume = {0:f2}", figure1.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", figure1.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", figure1.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", figure1.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", figure1.CalcDiagonalYZ());
        }
    }
}
