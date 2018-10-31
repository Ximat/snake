using System;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.sim = '*';
            p1.Draw();

        }
    }
}
