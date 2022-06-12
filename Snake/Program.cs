using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

			// Отрисовка рамочки
			HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
			HorizontalLine downLine = new HorizontalLine(0, 78, 23, '+');
			VerticalLine leftLine = new VerticalLine(0, 23, 0, '+');
			VerticalLine rightLine = new VerticalLine(0, 23, 78, '+');
			upLine.Drow();
			downLine.Drow();
			leftLine.Drow();
            rightLine.Drow();


			// Отрисовка точек			
			Point p = new Point(4, 5, '*');
			Snake snake = new Snake(p, 4, Direction.RIGHT);
			snake.Drow();

			while(true)
            {
				if(Console.KeyAvailable)
                {
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey(key.Key);
				}
				Thread.Sleep(100);
				snake.Move();
            }
		}
    }
}
