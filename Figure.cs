﻿using System;
using System.Collections.Generic;
namespace snake
{
    public class Figure
    {
            protected List<Point> pList;

            public void Drow()
            {
                foreach (Point p in pList)
                {
                    p.Draw();
                }
            }
    }
}
