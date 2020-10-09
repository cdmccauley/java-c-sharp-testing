using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class Box
    {
        private int length, width;

        public Box(int len, int wid)
        {
            length = len;
            width = wid;
        }

        public int calcPerimeter()
        {
            int perim = (2 * length) + (2 * width);
            return perim;
        }

        public int calcArea()
        {
            int area = length * width;
            return area;
        }
    }
}
