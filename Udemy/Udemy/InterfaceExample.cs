using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Udemy.Program;

namespace Udemy
{
    public class InterfaceExample : IExample, SecondInterface
    {
        public void Example()
        {
            Console.WriteLine("Creating Interface");
        }

        public int Example2()
        {
            return 5;
        }

        public string Example3(string string1, string string2)
        {
            return string1 + " " + string2;
        }

        public bool SecondExample()
        {
            return true;
        }
    }
    interface IExample
    {
        void Example();
        int Example2();
        string Example3(string string1, string string2);
    }
    interface SecondInterface
    {
        bool SecondExample();
    }
}
