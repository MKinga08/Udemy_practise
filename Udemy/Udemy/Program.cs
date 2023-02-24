using System.Diagnostics.Tracing;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace Udemy
{
    class Program
    {
        private string name = "Robert";
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public static void Main(string[] args)
        {
            LoopExamples();

            Ternary();
        }


        public static void LoopExamples()
        {
            Console.WriteLine("---------For loop---------");
            List<string> collection = new List<string>() { "a", "b", "c" };
            for (int i = 0; i < collection.Count; i++)
            {
                Console.WriteLine(collection[i]);
            }
            Console.WriteLine("---------while loop---------");
            int k = 3;
            while (k > 0)
            {
                Console.WriteLine("Loading");
                k--;
            }

        }
        public static void Ternary()
        {
            Console.WriteLine("---------ternary operators---------");
            int x = 2;
            int value = 0;
            bool isGreater = x > value ? true : false;
            Console.WriteLine(isGreater);
        }
    }
}
