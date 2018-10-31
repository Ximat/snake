using System;
using System.Collections.Generic;
namespace snake
{
    public class HorizontalLine
    {
        List<Point> pList;
        public HorizontalLine(int xLeft, int xRight, int y, char sim)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++) 
            {
                Point p = new Point(x, y, sim);
                pList.Add(p);
            }

        }
        public void Drow()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
