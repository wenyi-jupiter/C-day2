
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    class Box
    {
        double length, width, height;
        public double getVolume()
        {
            return length * width* height;
        }
        public void setLength(double len)
        {
            length = len;
        }

        public void setWidth(double bre)
        {
            width = bre;
        }

        public void setHeight(double hei)
        {
            height = hei;
        }

    }
}