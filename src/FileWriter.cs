using System.IO;

namespace Jafar
{
	public class FileWriter
	{
		public void write(string filename, string contents)
		{
			File.WriteAllText(filename, contents);
		}
	}
}