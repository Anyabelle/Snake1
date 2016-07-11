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
            Walls wall = new Walls();
            MakeFood foodm = new MakeFood(70, 20, 'o');
            Point food = foodm.Make();
            food.Draw();
            Point snakest = new Point(2, 2, '*');
            Snake S = new Snake(snakest, 5, Direction.Right);
            S.Draw();
            int cnt = 0;

            while (true)
            {
                Point Head = S.Head();
                if (Head.Eq(food))
                {
                    cnt++;
                    S.Eat(food);
                    food = foodm.Make();
                    while (S.IsinF(food))
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
                Thread.Sleep(130);
                if (Head.Eq(food))
                {
                    cnt++;
                    S.Eat(food);
                    food = foodm.Make();
                    while (S.IsinF(food))
                        food = foodm.Make();
                    food.Draw();
                }
                Head = Head.NextPoint(S.Dir);
                if (wall.HitWalls(Head) || S.HitSnake())
                {
                    Console.SetCursorPosition(30, 10);
                    Console.WriteLine("The End");
                    Console.SetCursorPosition(30, 11);
                    Console.Write("You've eaten ");
                    Console.Write(cnt);
                    break;
                }
                S.Move();
            }
            Console.ReadLine();
        }
    }
}
