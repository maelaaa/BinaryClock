using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryClock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Use current time, with a format string.
            int h, m, s;
            DateTime time = DateTime.Now;
            string format = "HH:mm:ss";
            Console.WriteLine(time.ToString(format));
            char[] sep = {':'};
            string[] tokens = format.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            h = int.Parse(time.ToString(tokens[0]));
            m = int.Parse(time.ToString(tokens[1]));
            s = int.Parse(time.ToString(tokens[2]));

            Console.Write("h: "); binary(h);
            Console.Write("m: "); binary(m);
            Console.Write("s: "); binary(s);
        }
        private static void binary(int n)
        {
            int pad = 6;
            Stack<int> stack = new Stack<int>();
            while (n > 0)
            {
                stack.Push(n % 2);
                n = n / 2;
            }

            int z = pad - stack.Count;
            while (z > 0)
            {
                stack.Push(0);
                z--;
            }
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
    
}
