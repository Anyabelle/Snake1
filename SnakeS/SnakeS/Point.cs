using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeS
{
    class Point
    {
        public int x;
        public int y;
        public char sym;
        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
        public Point()
        {}
        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
            this.sym = p.sym;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }
        public void Move(int i, Direction Dir)
        {
            if (Dir == Direction.Left)
                this.x -= i;
            else if (Dir == Direction.Right)
                this.x += i;
            else if (Dir == Direction.Up)
                this.y -= i;
            else if (Dir == Direction.Down)
                this.y += i;
        }
        public void Eraze()
        {
            this.sym = ' ';
            Draw();
        }
        public bool Eq(Point p)
        {
            if ((p.x == this.x) && (p.y == this.y))
                return true;
            else
                return false;
        }
        public Point NextPoint(Direction dir)
        {
            Point Next = new Point(this);
            Next.Move(1, dir);
            return Next;
        }
    }
}
