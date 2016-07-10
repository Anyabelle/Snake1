using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeS
{
    class Program
    {
        static void Main(string[] args)
        {
            HorisontalLine ll = new HorisontalLine(2, 5, 7, '+');
            ll.Draw();
            Console.ReadLine();
        }
    }
}
