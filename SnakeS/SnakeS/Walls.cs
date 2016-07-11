using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeS
{
    class Walls : Figure
    {
        public List<Figure> Frame = new List<Figure>();
        public Walls()
        {
            HorisontalLine Left = new HorisontalLine(2, 67, 1, '_');
            Left.Draw();
            VerticalLine Down = new VerticalLine(1, 2, 19, '|');
            Down.Draw();
            HorisontalLine Left1 = new HorisontalLine(2, 68, 19, '_');
            Left1.Draw();
            VerticalLine Down1 = new VerticalLine(68, 2, 19, '|');
            Down1.Draw();
            Frame.Add(Left);
            Frame.Add(Left1);
            Frame.Add(Down);
            Frame.Add(Down1);
        }

        public void HitWalls(Figure snake)
        {
            foreach (Figure f in Frame)
            {

            }
        }
    }
}
