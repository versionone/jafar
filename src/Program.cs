using System;
using System.IO;
using Noesis.Javascript;

namespace Jafar
{
	public class Program
	{
		public static string CurrentPath;

		public static int Main(string[] args)
		{
			CurrentPath = Path.GetFullPath(".");

			var context = new JavascriptContext();

			context.SetParameter("file_writer", new FileWriter()); //TODO: should probably namespace these in javascript
			context.SetParameter("system_console", new SystemConsole());
			context.SetParameter("file_loader", new FileLoader(context));
			
			foreach (var file in args)
			{
				var fullPath = Path.GetFullPath(file);
				CurrentPath = fullPath.Substring(0, fullPath.LastIndexOf(Path.DirectorySeparatorChar));
				var script = File.ReadAllText(fullPath);
				if (!string.IsNullOrEmpty(script))
					context.Run(script + ";null;");
			}

			return 0;
		}
	}
}
