using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeS
{
    class VerticalLine : Figure
    {
        public VerticalLine(int x, int upy, int downy, char sym)
        {
            for (int yi = upy; yi <= downy; yi++)
            {
                Line.Add(new Point(x, yi, sym));
            }
        }
    }
}
