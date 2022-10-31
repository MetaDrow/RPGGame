using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
	internal interface IMove
	{
		 int x { get; set; }
		 int y { get; set; }
		 int  Move (int x, int y);
		 
	}
}
