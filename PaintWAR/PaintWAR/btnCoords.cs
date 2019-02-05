using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintWAR
{
    class btnCoords
    {
        // Create coordinate values
        private int x;
        private int y;

        // Create coordinate object without any data
        public btnCoords() { }

        // Constructor with x and y passed in
        public btnCoords(int inx, int iny)
        {
            x = inx;
            y = iny;
        }

        // Return the x value
        public int getX() { return x; }

        // Return the y value
        public int getY() { return y; }

        // Set the value of x
        public void setX(int inx) { x = inx; }

        // Set the value of y
        public void setY(int iny) { y = iny; }
    }
}
