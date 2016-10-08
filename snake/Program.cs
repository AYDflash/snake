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
            Point p1 = new Point(10,10,'x');
            p1.Draw();

            Point p2 = new Point(20,20,'x');
            p2.Draw();

            Console.ReadLine();
        }
    }
}
