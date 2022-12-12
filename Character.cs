using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
	internal class Character
	{

		private string[] _characterFace =
		{
			"  @  ",
			"┌─┼─┐",
			" ┌┴┐ ",
			" │ │ ",

		};

		public string[] characterFace { get { return _characterFace; } }

	}
}