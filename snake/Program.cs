using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Window size
            //Width = 120
            //Height = 30
            Console.SetBufferSize(120, 30);
            DrawField();

            Point p = new Point(10, 5, '*');
            Snake snake = new Snake(p, 4, Direction.Right);

            while (true) 
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Handl(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
                
            }
        }

        private static void DrawField()
        {
            HorizontalLine lineTop = new HorizontalLine(2, 118, 0, '+');
            lineTop.Draw();
            HorizontalLine lineBottom = new HorizontalLine(2, 118, 29, '+');
            lineBottom.Draw();
            VerticalLine lineLeft = new VerticalLine(0, 29, 2, '+');
            lineLeft.Draw();
            VerticalLine lineRight = new VerticalLine(0, 29, 118, '+');
            lineRight.Draw();
        }
    }
}
