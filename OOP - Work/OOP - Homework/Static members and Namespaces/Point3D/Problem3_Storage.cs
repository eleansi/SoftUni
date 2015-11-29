using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public static class Problem3_Storage
    {
        public static void SavePath(string fileName, params Problem3_Paths3D[] paths)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(fileName, FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                using (sw)
                {
                    foreach (Problem3_Paths3D path in paths)
                    {
                        sw.Write(path);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Dispose();
                }
            }
        }

        public static Problem3_Paths3D LoadPath(string fileName)
        {
            List<Problem1_Point3D> points = new List<Problem1_Point3D>();
            Problem3_Paths3D path;
            try
            {
                StreamReader sr = new StreamReader(fileName);
                using (sr)
                {
                    String line = sr.ReadLine();
                    while (line != null)
                    {
                        double[] coordinates = PointExtractor(line);
                        Problem1_Point3D p = new Problem1_Point3D(coordinates[0], coordinates[1], coordinates[2]);
                        points.Add(p);
                        line = sr.ReadLine();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                
            }
            path = new Problem3_Paths3D(points);
            return path;
        }

        public static double[] PointExtractor(string line)
        {
            double[] pointCoordinates = new double[3];
            string[] data = line.Split(',');

            for (int i = 0; i < data.Length; i++)
            {
                pointCoordinates[i] = double.Parse(data[i]);
            }
            return pointCoordinates;
        }
    }
}
