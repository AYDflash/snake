using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 10, 'x');
            Point p2 = new Point(20, 20, 'x');
            Point p3 = new Point(10, 20, 'x');
            Point p4 = new Point(20, 10, 'x');
            
            List<Point> pointList = new List<Point>();
            pointList.Add(p1);
            pointList.Add(p2);
            pointList.Add(p3);
            pointList.Add(p4);

            foreach (Point p in pointList) {
                p.Draw();
            }
            Console.ReadLine();
        }
    }
}
