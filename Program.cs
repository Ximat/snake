using System;
using System.Collections.Generic;
using System.Collections;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');
            p1.Draw();

            HorizontalLine line = new HorizontalLine(1, 10, 5, '+');
            line.Drow();
        }
    }
}
