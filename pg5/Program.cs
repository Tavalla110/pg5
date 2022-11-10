using System;

namespace pg5
{
    class Program
    {
        public static void Main()
        {
            string str = Console.ReadLine();
            int num = Convert.ToInt32(str);
            Console.WriteLine(Result(num));
        }
        private static int Result(int x)
        {
            int val = (int)Math.Pow(x, 2);
            return val;
        }
    }

}

