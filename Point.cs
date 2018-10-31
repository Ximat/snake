using System;
namespace snake
{
    public class Point
    {
        public int x;
        public int y;
        public char sim;
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sim);
        }

    }

}
