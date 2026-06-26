namespace OOP_Project
{
    public interface IShape
    {
        // Forces any shape to have a method to calculate its edges
        void calculateEdgeCoordinates();

        // Forces any shape to have a rotate function
        void rotatePolygon(bool isCounterClockwise);
    }
}