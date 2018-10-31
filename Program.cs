using System;
using System.Collections.Generic;
using System.Collections;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            HorizontalLine upline = new HorizontalLine(0, 75, 0, '+');
            upline.Drow();
            HorizontalLine downline = new HorizontalLine(0, 75, 20, '+');
            downline.Drow();
            VerticalLine leftline = new VerticalLine(0, 20, 0, '+');
            leftline.Drow();
            VerticalLine rightline = new VerticalLine(0, 20, 75, '+');
            rightline.Drow();
        }
    }
}
