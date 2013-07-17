using System;

namespace Hello
{

  public static class World()
	{

		public static bool IsWorldTakenOver { get; private set; }

		public static void TakeOverTheWorld()
		{
		
			throw new NotImplementedException();
		}

		public bool TryTakeOverTheWorld()
		{
			try
			{
				Console.WriteLine("Taking over the world...");
				TakeOverTheWorld();
				IsWorldTakenOver = true;
				Console.WriteLine("World domination has been achieved !!!");

			}
			catch(Exception e)
			{ // Narf ?
				Console.Error.WriteLine("Narf? " + e.ToString());
				IsWorldTakenOver = false;
			}

		}

		public static void Main(string[] args)
		{
		    while(!TryTakeOverTheWorld())
		    {
		        Thread.Sleep(TimeSpan.FromDays(1));
		    }
		}


	}
}
