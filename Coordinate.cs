using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
	internal class Coordinate
	{
		private int x { get; set; }   
		private int y { get; set; }

		internal Coordinate(int x, int y)
		{
			this.x = x;
			this.y = y;
			Console.SetCursorPosition(x, y);
		}
		//первое значение первой строки (X) последнее значение первой строки (Y)
		//первое значение последней строки(x) последнее значениеи последней строки (y)
	}
}