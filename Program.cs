using System;




namespace RPGGame
{

	internal class Program
	{
		
		static void Main ()
		{
			Render render = new Render();

			Character character = new Character();
			string[] player = character.characterFace;

			Map map = new Map();
			string[] lvl = map.LVL1;

			render.Renderer(player);
			render.Renderer(lvl);

			Console.ReadLine();
		}


	}
}
