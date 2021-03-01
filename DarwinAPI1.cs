using System;

namespace pattern_Bridge
{
    class DrawingAPI1 : DrawingAPI {
    
    public void drawCircle(double x, double y, double radius) {
         Console.WriteLine($"API1.circle at {x}:{y} radius {radius}\n");
    }
}
}