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
            DrawField();
            Console.ReadLine();
        }

        private static void DrawField()
        {
            HorizontalLine lineTop = new HorizontalLine(0, 110, 0, '+');
            lineTop.Draw();
            HorizontalLine lineBottom = new HorizontalLine(0, 110, 25, '+');
            lineBottom.Draw();
            VerticalLine lineLeft = new VerticalLine(0, 25, 0, '+');
            lineLeft.Draw();
            VerticalLine lineRight = new VerticalLine(0, 25, 110, '+');
            lineRight.Draw();
        }
    }
}
