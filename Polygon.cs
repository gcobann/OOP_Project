using System;

namespace OOP_Project
{
    // Polygon inherits from the abstract Shape class
    public class Polygon : Shape
    {
        private int length; // Distance from center to corners
        private int edgeCount; // How many corners/edges the polygon has
        private Point2D[] corners; // Array to hold the coordinates of each corner
        private double initialAngle; // Random starting angle so the shape doesn't always look the same

        // Encapsulated properties
        public int Length { get { return length; } set { length = value; } }
        public int NumberOfEdges { get { return edgeCount; } set { edgeCount = value; } }
        public Point2D[] Vertices { get { return corners; } }

        // Accessing the 'protected' variables from the base Shape class
        public Point2D Center { get { return center; } set { center = value; } }
        public ColorRGB Color { get { return color; } set { color = value; } }

        // Default constructor
        public Polygon()
        {
            center = new Point2D();
            length = 4;
            edgeCount = 5;
            color = new ColorRGB();

            // Picking a random start angle between 0 and 360
            Random rnd = new Random();
            initialAngle = rnd.Next(0, 360);
        }

        // Overloaded constructor taking center and length
        public Polygon(Point2D baslangicMerkezi, int baslangicUzunlugu)
        {
            center = baslangicMerkezi;
            length = baslangicUzunlugu;
            edgeCount = 5; // Default edge count
            color = new ColorRGB();

            Random rnd = new Random();
            initialAngle = rnd.Next(0, 360);
        }

        // Overriding the abstract method from Shape class
        public override void calculateEdgeCoordinates()
        {
            // Set the array size based on the number of edges
            corners = new Point2D[edgeCount];

            double angleStep = 360.0 / edgeCount;

            // Calculate each corner's coordinates one by one
            for (int ae = 0; ae < edgeCount; ae++)
            {
                double currentAngle = initialAngle + (ae * angleStep);

                double radian = currentAngle * Math.PI / 180.0;

                // Circle formula: x = cx + r*cos(a), y = cy + r*sin(a)
                double x = center.X + (length * Math.Cos(radian));
                double y = center.Y + (length * Math.Sin(radian));

                corners[ae] = new Point2D(x, y);
            }
        }

        // Custom rotate method that takes an angle parameter
        public void rotatePolygon(int angle, bool isCounterClockwise)
        {
            // Update the start angle based on the direction
            if (isCounterClockwise == true)
            {
                initialAngle -= angle;
            }
            else
            {
                initialAngle += angle;
            }

            // Recalculate corners with the new angle
            calculateEdgeCoordinates();
        }

        // Base rotation method inherited from Shape class
        public override void rotatePolygon(bool isCounterClockwise)
        {
            // Left empty. I use the other rotate method for the timer.
        }
    }
}