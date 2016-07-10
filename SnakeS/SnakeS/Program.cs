using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeS
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            Point p2 = new Point(4, 3, '*');
            p1.Draw();
            List<Point> ll = new List<Point>();
            ll.Add(p1);
            ll.Add(p2);
            foreach (Point pi in ll)
            {
                Console.WriteLine(pi.x);
            }
            Console.WriteLine("Hello");
            Console.ReadLine();
        }
    }
}
