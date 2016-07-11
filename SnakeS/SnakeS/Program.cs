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
            MakeFood foodm = new MakeFood(70, 20, '&');
            Point food = foodm.Make();
            food.Draw();
            Point snakest = new Point(2, 2, '*');
            Snake S = new Snake(snakest, 4, Direction.Right);
            S.Draw();

            while (true)
            {
                if (S.Eat(food))
                {
                    food = foodm.Make();
                    food.Draw();
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.LeftArrow)
                        S.Dir = Direction.Left;
                    else if (key.Key == ConsoleKey.RightArrow)
                        S.Dir = Direction.Right;
                    else if (key.Key == ConsoleKey.UpArrow)
                        S.Dir = Direction.Up;
                    else if (key.Key == ConsoleKey.DownArrow)
                        S.Dir = Direction.Down;
                }
                Thread.Sleep(200);
                S.Move();
            }
            Console.ReadLine();
        }
    }
}
