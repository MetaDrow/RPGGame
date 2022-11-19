using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
	internal class Character
	{

		
		public int x { get; set; }
		public int y { get; set; }

		public void CheckCharacter(int x, int y)
		{
			Console.SetCursorPosition(x, y);
		}


	}
}
