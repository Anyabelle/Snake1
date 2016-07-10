﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeS
{
    class HorisontalLine : Figure
    {
        public HorisontalLine(int xl, int xr, int y, char sym)
        {
            for (int i = xl; i <= xr; i++)
            {
                Line.Add(new Point(i, y, sym));
            }
        }
    }
}
