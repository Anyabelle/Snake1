using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeS
{
    class Snake : Figure
    {
        public Direction Dir;
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
            Point Next = Head.NextPoint(Dir);
            Line.Add(Next);
            Draw();
            Point Tail = new Point();
            Tail = Line.First();
            Line.Remove(Tail);
            Tail.Eraze();
        }

        public bool Eat(Point food)
        {
            Point Head = new Point();
            Head = Line.Last();
            Point Next = new Point(Head);
            Next.Move(1, Dir);
            if (Next.Eq(food))
            {
                Line.Add(Next);
                return true;
            }
            else
                return false;
        }
        public Point Head()
        {
            return new Point(Line.Last());
        }
        public bool HitSnake()
        {
            Point p = this.Head();
            p = p.NextPoint(Dir);
            if (this.IsinF(p))
            {
                return true;
            }
            return false;
            
        }

    }
}
