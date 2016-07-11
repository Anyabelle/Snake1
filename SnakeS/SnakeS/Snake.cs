using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeS
{
    class Snake : Figure
    {
        Direction Dir;
        public Snake(Point Tail, int Length, Direction Direct)
        {
            Dir = Direct;
            for (int i = 0; i < Length; i++)
            {
                Point p = new Point(Tail);
                p.Move(i, Direct);
                Line.Add(p);
            }
        }
        public void Move()
        {
            Point Head = new Point();
            Head = Line.Last();
            Point Next = new Point(Head);
            Next.Move(1, Dir);
            Line.Add(Next);
            Draw();
            Point Tail = new Point();
            Tail = Line.First();
            Line.Remove(Tail);
            Tail.Eraze();
        }
    }
}
