using System;



namespace RPGGame
{
	internal class Program
	{
		static void Main (string[] args)
		{

			//start program 
			int x = 5; int y = 5;
			Character player = new Character();
			player.CheckCharacter(x,y);



			Console.ReadLine();
		}
	}
}
