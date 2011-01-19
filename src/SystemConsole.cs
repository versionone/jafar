using System;

namespace Jafar
{
	public class SystemConsole
	{
		public void log(string message)
		{
			Console.WriteLine(message);
		}

		public void print(string message)
		{
			Console.Write(message);
		}
	}
}