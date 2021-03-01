namespace pattern_Bridge
{
    class CircleShape : Shape
    {

        private double x;

        private double y;

        private double radius;

        public CircleShape(double x, double y, double radius, DrawingAPI drawingAPI) :
                base(drawingAPI)
        {
            this.drawingAPI=drawingAPI;
            this.x=x;
            this.y = y;
            this.radius = radius;
        }

        //  low-level i.e. Implementation specific
        public override void draw()
        {
            drawingAPI.drawCircle(this.x, this.y, this.radius);
        }

        //  high-level i.e. Abstraction specific
        public override void resizeByPercentage(double pct)
        {
            this.radius = (this.radius * pct);
        }
    }

}