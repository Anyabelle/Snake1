using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SnakeS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Draw Frame
            Console.SetWindowSize(70, 20);
            HorisontalLine Left = new HorisontalLine(2, 67, 1, '_');
            Left.Draw();
            VerticalLine Down = new VerticalLine(1, 2, 19, '|');
            Down.Draw();
            HorisontalLine Left1 = new HorisontalLine(2, 68, 19, '_');
            Left1.Draw();
            VerticalLine Down1 = new VerticalLine(68, 2, 19, '|');
            Down1.Draw();
            Point p = new Point(2, 2, '&');
            Snake S = new Snake(p, 4, Direction.Right);
            S.Draw();
            S.Move();
            Thread.Sleep(500);
            S.Move();
            Thread.Sleep(500);
            S.Move();
            Thread.Sleep(500);
            S.Move();
            Thread.Sleep(500);
            S.Move();
            Thread.Sleep(500);
            S.Move();
            Console.ReadLine();
        }
    }
}
