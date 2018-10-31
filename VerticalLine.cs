using System;
using System.Collections.Generic;

namespace snake
{
    public class VerticalLine:Figure
    {
        public VerticalLine(int yUp, int yDown, int x, char sim)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sim);
                pList.Add(p);
            }
        }
    }
}
