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
            int x = 2;
            int y = 3;
            char symb = 'X';

            Draw(x, y, symb);

            int x1 = 20;
            int y1 = 20;

            Draw(x1, y1, symb);

            Console.ReadLine();
        }

        static void Draw(int x, int y, char sym) {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
