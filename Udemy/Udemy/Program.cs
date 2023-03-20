using System.Diagnostics.Tracing;
using System.Linq.Expressions;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;

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

            OperatorOverloading();

            StringBuilder();

            BooleanFlagTechnique();

            UserInput();

            WorkingWithFiles();

            Lambda();

            FuncAndExtensionMethod();

            InterfaceImplementing();


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
        public static void OperatorOverloading()
        {
            Console.WriteLine("---------operator overloading---------");
            Box box1 = new(2, 2, 2);
            Box box2 = new(2, 2, 2);
            Box box3 = box1 + box2;
            Console.WriteLine("Length: " + box3.GetLength());
            Console.WriteLine("Width: " + box3.GetWidth());
            Console.WriteLine("Height: " + box3.GetHeight());
        }
        public static void StringBuilder()
        {
            Console.WriteLine("\n---------StringBuilder---------");
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("hello world");
            Console.WriteLine(stringBuilder);
            for (int i = 0; i < 4; i++)
            {
                stringBuilder.Append(" nice to see you");
            }
            Console.WriteLine(stringBuilder);
            string a = stringBuilder.ToString();
            Console.WriteLine(a);
            string s = "The quick brown fox jumps over the lazy dog";
            string[] sArray = s.Split(' ');
            sArray.ToList().ForEach(i => Console.WriteLine(i.ToString()));
        }
        public static void BooleanFlagTechnique()
        {
            Console.WriteLine("\n---------Boolean flag technique---------");
            bool example = false;
            List<int> intList = new List<int>() { 1, 2, 3 };
            foreach (int i in intList)
            {
                if (i == 3)
                {
                    example = true;
                }
            }
            if (example)
            {
                Console.WriteLine("You found 3!");
            }
        } 
        public static void UserInput()
        {
            Console.WriteLine("\n---------Background colour changer---------");
            Console.WriteLine("g = green; r = red; b = blue; w = white; q = quit") ;
            int x = Console.Read();
            char userinput = Convert.ToChar(x);
            while(userinput != 'q')
            {
                switch (userinput)
                {
                    case 'g':
                        Console.BackgroundColor = ConsoleColor.Green; 
                        break;
                    case 'r':
                        Console.BackgroundColor = ConsoleColor.Red;
                        break;
                    case 'b':
                        Console.BackgroundColor = ConsoleColor.Blue;
                        break;
                    case 'w':
                        Console.BackgroundColor = ConsoleColor.White;
                        break;
                    default:
                        break;
                }
                Console.Clear();
                x = Console.Read();
                userinput = Convert.ToChar(x);
            }
        }
        public static void WorkingWithFiles()
        {
            Console.WriteLine("\n---------Working with files---------");
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Example.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            FileStream fs = File.Open(path, FileMode.Append);
            byte[] info = new UTF8Encoding(true).GetBytes("Hello world");
            fs.Write(info, 0, info.Length);
            fs.Close();
            Console.WriteLine("Method is working\n");
        }
        public static void Lambda()
        {
            Console.WriteLine("---------Lambda Expressions---------");
            Action debug = () => Console.WriteLine("hello World");
            debug();

            var a = new Player("Pista", 'X');
            var b = new Player("Kinga", 'P'); 
            var c = new Player("Adam", 'K'); 
            var d = new Player("Lalika", 'X');
            var e = new Player("Kriszti", 'O');

            List<Player> lists = new List<Player> { a, b, c, d, e};

            var ActualPlayer = lists.Where(x => x.name == "Kinga").First();



            Console.WriteLine(ActualPlayer.name);

            var PlayersSymbol = lists.Where(x => x.symbol == 'X').ToList();
            Console.WriteLine(PlayersSymbol[1].symbol);

            Console.WriteLine("---------Custom writeline---------");
            WriteLine(ActualPlayer);
        }
        public static void WriteLine(Player player)
        {
            Console.WriteLine(player.symbol);
            Console.WriteLine(player.name);
        }
        public static void FuncAndExtensionMethod()
        {
            Console.WriteLine("---------FuncAndExtensionMethod---------");
            Func<int, int, int> multiply = (x, y) => { return x * y; };
            Console.WriteLine(multiply(2, 3));

        }
        public static void InterfaceImplementing()
        {
            Console.WriteLine("---------InterfaceImplementing---------");
            InterfaceExample ex1 = new InterfaceExample();
            Console.WriteLine(ex1.Example2());
            Console.WriteLine(ex1.Example3("Kinga", "mégegystring"));
            Console.WriteLine(ex1.SecondExample());
        }
    }

}
