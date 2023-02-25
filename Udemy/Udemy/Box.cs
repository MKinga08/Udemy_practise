using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy
{
    public class Box
    {
        private int length;
        private int height;
        private int width;

        public Box(int aLength, int aHeight, int aWidth)
        {
            length = aLength;
            height = aHeight;
            width = aWidth;
        }
        public int GetLength()
        {
            return length;
        }
        public int GetHeight()
        {
            return height;
        }
        public int GetWidth()
        {
            return width;
        }
        public static Box operator +(Box box1, Box box2)
        {
            return new Box(box1.GetLength() + box2.GetLength(), 
                            box1.GetHeight() + box2.GetHeight(),
                            box1.GetWidth() + box2.GetWidth());
        }
    }
}
