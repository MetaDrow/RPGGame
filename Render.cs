using System;


namespace RPGGame
{
	internal class Render
	{
		
		public void Renderer(string[] args)
		{
			for(int i =0;i< args.Length; i++)
			{
				var a = args[i];
				Console.WriteLine(a);
			}
		}
	}
}