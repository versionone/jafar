using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Noesis.Javascript;

namespace Jafar
{
	public class FileLoader
	{
		private readonly JavascriptContext _context;

		public FileLoader(JavascriptContext context)
		{
			_context = context;
		}

		public string load(string filename)
		{
			filename = Path.Combine(Program.CurrentPath, filename);
			if (!filename.EndsWith(".js")) filename = filename + ".js";
			var fullPath = Path.GetFullPath(filename);
			Program.CurrentPath = fullPath.Substring(0, fullPath.LastIndexOf(Path.DirectorySeparatorChar));
			return File.ReadAllText(fullPath);
		}
	}
}
