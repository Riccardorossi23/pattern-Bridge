using System;

namespace pattern_Bridge
{
    class Program
    {
        public static void Main(String[] args)
        {
            Shape[] shapes = new Shape[]{
                 new CircleShape(1, 2, 3, new DrawingAPI1()),
             new CircleShape(5, 7, 11, new DrawingAPI2())
             };
            foreach (Shape shape in shapes)
            {
                shape.resizeByPercentage(2.5);
                shape.draw();
            }
        }
    }
}










