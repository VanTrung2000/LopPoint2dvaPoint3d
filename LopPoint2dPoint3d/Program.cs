using System;

namespace LopPoint2dPoint3d
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2d po1 = new Point2d();
            po1.SetXY(3, 2);
            Console.WriteLine(po1.ToString());
            Point3d po2 = new Point3d();
            po2.SetXYZ(4, 3, 2);
            Console.WriteLine(po2.ToString());
            Console.ReadKey();
        }
    }
}
