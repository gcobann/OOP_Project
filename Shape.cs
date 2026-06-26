namespace OOP_Project
{
    // Abstract base class implementing the IShape interface
    public abstract class Shape : IShape
    {
        // Using 'protected' so child classes (like Polygon) can access them directly
        protected Point2D center;
        protected ColorRGB color;

        // Passing the calculation responsibility to the child classes
        public abstract void calculateEdgeCoordinates();
        public abstract void rotatePolygon(bool isCounterClockwise);
    }
}