using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy
{
    public static class Example
    {
        public static bool IsGreater(this int i, int val)
        {
            if (i < val)
            {
                return true;
            }
            return false;
        }
    }
}