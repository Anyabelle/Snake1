using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeS
{
    class Figure
    {
        protected List<Point> Line = new List<Point>();
        public void Draw()
        {
            foreach (Point p in Line)
            {
                p.Draw();
            }
        }
    }
}
