using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeS
{
    class MakeFood
    {
        int mapw, maph;
        char sym;
        Random Rand = new Random();
        public MakeFood(int mapw, int maph, char sym)
        {
            this.mapw = mapw;
            this.maph = maph;
            this.sym = sym;
        }
        public Point Make()
        {
            int x = Rand.Next(4, mapw - 4);
            int y = Rand.Next(4, maph - 4);
            return new Point(x, y, sym);
        }
    }
}
