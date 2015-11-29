using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Problem1_Point3D p1 = new Problem1_Point3D(2.51, 2.18, 85.4);
            Problem1_Point3D p2 = new Problem1_Point3D(8.88, 9.42, 4.20);
            Problem1_Point3D zeroPoint = Problem1_Point3D.StartingPoint;
            
            // Problem 1 TESTS
            Console.WriteLine("--------------This is the result from Problem 1--------------");
            Console.WriteLine(zeroPoint);
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            
            // Problems 2 TESTS
            Console.WriteLine();
            Console.WriteLine("--------------This is the result from Problem 2--------------");
            
            Console.WriteLine(Problem2_DistanceCalc.CalculateDistance(p1, p2));
            
        
            // Problem 3 TESTS
            Console.WriteLine();
            Console.WriteLine("--------------This is the result from Problem 3--------------");

            Problem1_Point3D point1 = new Problem1_Point3D(34, 90, 89);
            Problem1_Point3D point2 = new Problem1_Point3D(1, 7, 23);
            Problem1_Point3D point3 = new Problem1_Point3D(9, 18, 81);


            List<Problem1_Point3D> points1 = new List<Problem1_Point3D>{point1, point2, point3};
            List<Problem1_Point3D> points2 = new List<Problem1_Point3D>{point1, point2};
            List<Problem1_Point3D> points3 = new List<Problem1_Point3D>{point2, point3};

            Problem3_Paths3D path1 = new Problem3_Paths3D(points1);
            Problem3_Paths3D path2 = new Problem3_Paths3D(points2);
            Problem3_Paths3D path3 = new Problem3_Paths3D(points3);

            Problem3_Storage.SavePath("../../path", path1, path2, path3);
            Problem3_Paths3D newPath = Problem3_Storage.LoadPath("../../path");
            Problem3_Storage.SavePath("../../path", newPath);
            Console.WriteLine(newPath);
        }
    }
}
