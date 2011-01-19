using System.IO;
using Noesis.Javascript;

namespace Jafar
{
	class Program
	{

		public static int Main(string[] args)
		{
			var context = new JavascriptContext();

			context.SetParameter("file_writer", new FileWriter());
			context.SetParameter("system_console", new SystemConsole());

			foreach (var file in args)
			{
				var fullPath = Path.GetFullPath(file);
				context.Run(File.ReadAllText(fullPath) + ";null;");
			}

			return 0;
		}
	}
}
