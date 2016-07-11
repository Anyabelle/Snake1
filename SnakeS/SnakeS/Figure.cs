using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeS
{
    class Figure
    {
        public List<Point> Line = new List<Point>();
        public void Draw()
        {
            foreach (Point p in Line)
            {
                p.Draw();
            }
        }
        public bool IsinF(Point p)
        {
            foreach (Point i in Line)
            {
                if (p.Eq(i))
                    return true;
            }
            return false;
        }
    }
}
