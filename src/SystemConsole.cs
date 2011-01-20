using System;

namespace Jafar
{
	public class SystemConsole
	{
		
		public void log(object message)
		{
			Console.WriteLine(message);
		}

		public void print(string message)
		{
			Console.Write(message);
		}

		#region params array doesn't work for javascript methods
		public void log(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j)
		{
			log(a, b, c, d, e, f, g, h, i);
			Console.WriteLine(j);
		}

		public void log(string a, string b, string c, string d, string e, string f, string g, string h, string i)
		{
			log(a, b, c, d, e, f, g, h);
			Console.WriteLine(i);
		}

		public void log(string a, string b, string c, string d, string e, string f, string g, string h)
		{
			log(a, b, c, d, e, f, g);
			Console.WriteLine(h);
		}

		public void log(string a, string b, string c, string d, string e, string f, string g)
		{
			log(a, b, c, d, e, f);
			Console.WriteLine(g);
		}

		public void log(string a, string b, string c, string d, string e, string f)
		{
			log(a, b, c, d, e);
			Console.WriteLine(f);
		}

		public void log(string a, string b, string c, string d, string e)
		{
			log(a, b, c, d);
			Console.WriteLine(e);
		}

		public void log(string a, string b, string c, string d)
		{
			log(a, b, c);
			Console.WriteLine(d);
		}

		public void log(string a, string b, string c)
		{
			log(a, b);
			Console.WriteLine(c);
		}

		public void log(string a, string b)
		{
			log(a);
			Console.WriteLine(b);
		}
		#endregion
	}
}