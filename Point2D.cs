using System;

namespace OOP_Project
{
    public class Point2D
    {
        // Cartesian coordinates
        private double x;
        private double y;

        // Polar coordinates
        private double r;
        private double theta;

        // Encapsulated properties for safe data access
        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }
        public double R { get { return r; } set { r = value; } }
        public double Theta { get { return theta; } set { theta = value; } }

        public Point2D() // Default constructor: sets to origin (0,0) to avoid null references
        {
            x = 0;
            y = 0;
        }

        public Point2D(double initialX, double initialY) // Overloaded constructor for specific coordinates
        {
            x = initialX;
            y = initialY;
        }

        public Point2D(Random rnd) // Overloaded constructor for random coordinates
        {
            // Range [0,3]
            x = rnd.Next(0, 4);
            y = rnd.Next(0, 4);
        }

        public void printCoordinates() // Simple console output
        {
            Console.WriteLine("X: " + x + ", Y: " + y);
        }

        public void calculatePolarCoordinates() // Converts Cartesian to Polar
        {
            // r = sqrt(x^2 + y^2) - Pythagorean theorem
            r = Math.Sqrt((x * x) + (y * y));

            // Used Atan2 instead of Atan to avoid division by zero error if x is 0
            theta = Math.Atan2(y, x);
        }

        public void calculateCartesianCoordinates() // Converts Polar to Cartesian
        {
            x = r * Math.Cos(theta);

            y = r * Math.Sin(theta);
        }

        public string printPolarCoordinates() // Returns a formatted string for polar coordinates
        {
            return "P(r: " + Math.Round(r, 2) + ", θ: " + Math.Round(theta, 2) + ")";
        }
    }
}