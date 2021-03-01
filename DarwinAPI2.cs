using System;

namespace pattern_Bridge
{
    class DrawingAPI2 : DrawingAPI
    {

        public void drawCircle(double x, double y, double radius)
        {
            Console.WriteLine($"API2.circle at {x}:{y} radius {radius}\n");
        } 
    }
}