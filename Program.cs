using System;

namespace snake
{
    class Program
    {
        static void Draw (int x, int y, char sim)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sim);
        }
        static void Main(string[] args)
        {
            int x1=5;
            int y1=3;
            char sim1='*';
            Draw(x1,y1,sim1);
        }
    }
}
