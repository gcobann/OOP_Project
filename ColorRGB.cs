using System;

namespace OOP_Project
{
    public class ColorRGB
    {
        // Encapsulated color values
        private int red;
        private int green;
        private int blue;

        // Properties to safely read and write these values from Form1
        public int Red { get { return red; } set { red = value; } }
        public int Green { get { return green; } set { green = value; } }
        public int Blue { get { return blue; } set { blue = value; } }

        public ColorRGB() // Default constructor: Sets to black (0,0,0) to prevent null errors initially
        {
            red = 0;
            green = 0;
            blue = 0;
        }

        public ColorRGB(int R, int G, int B) // Overloaded constructor for manual assignment
        {
            red = R;
            green = G;
            blue = B;
        }

        public ColorRGB(Random rnd) // Overloaded constructor for random colors
        {
            red = rnd.Next(0, 256);
            green = rnd.Next(0, 256);
            blue = rnd.Next(0, 256);
        }
    }
}