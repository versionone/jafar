using System;
using System.Collections.Generic;
using System.Text;

namespace Jafar
{
	public class SystemConsole
	{

		public void log(object obj)
		{
			var builder = new StringBuilder();
			log_recursive(builder, 0, obj);
			Console.WriteLine(builder.ToString());
		}

		public void print(string message)
		{
			Console.Write(message);
		}

		#region formatting

		private void log_recursive(StringBuilder builder, int indentLevel, object obj)
		{
			var jsObj = obj as Dictionary<string, object>;
			if (jsObj != null)
			{
				log_dictionary(builder, indentLevel, jsObj);
				return;
			}

			var jsArray = obj as Object[];
			if (jsArray != null)
			{
				log_array(builder, indentLevel, jsArray);
				return;
			}

			builder.Append(obj);
		}

		private void log_array(StringBuilder builder, int indentLevel, object[] jsArray)
		{
			builder.Append("[");
			for (int i = 0; i < jsArray.Length; i++)
			{
				var jsArrayItem = jsArray[i];
				log_recursive(builder, indentLevel + 1, jsArrayItem);

				if (i < jsArray.Length - 1) builder.Append(", ");
			}
			builder.Append("]");
		}

		private void log_dictionary(StringBuilder builder, int indentLevel, Dictionary<string, object> jsObj)
		{
			if (jsObj.Keys.Count == 0)
			{
				builder.Append("function");
				return;
			}
			builder.AppendFormat("{{", Tabs(indentLevel > 0 ? indentLevel - 1 : indentLevel), Environment.NewLine);
			indentLevel += 1;
			foreach (var key in jsObj.Keys)
			{
				builder.AppendFormat("{1}{2}{0}: ", key, Environment.NewLine, Tabs(indentLevel));
				log_recursive(builder, indentLevel + 1, jsObj[key]);
			}
			indentLevel -= 1;
			builder.AppendFormat("{1}{0}}}", Tabs(indentLevel), Environment.NewLine);
		}

		private string Tabs(int indentLevel)
		{
			return "".PadRight(indentLevel, ' ');
		}

		#endregion

		#region params array doesn't work for javascript methods
		public void log(object a, object b, object c, object d, object e, object f, object g, object h, object i, object j)
		{
			log(a, b, c, d, e, f, g, h, i);
			Console.WriteLine();
			log(j);
		}

		public void log(object a, object b, object c, object d, object e, object f, object g, object h, object i)
		{
			log(a, b, c, d, e, f, g, h);
			Console.WriteLine();
			log(i);
		}

		public void log(object a, object b, object c, object d, object e, object f, object g, object h)
		{
			log(a, b, c, d, e, f, g);
			Console.WriteLine();
			log(h);
		}

		public void log(object a, object b, object c, object d, object e, object f, object g)
		{
			log(a, b, c, d, e, f);
			Console.WriteLine();
			log(g);
		}

		public void log(object a, object b, object c, object d, object e, object f)
		{
			log(a, b, c, d, e);
			Console.WriteLine();
			log(f);
		}

		public void log(object a, object b, object c, object d, object e)
		{
			log(a, b, c, d);
			Console.WriteLine();
			log(e);
		}

		public void log(object a, object b, object c, object d)
		{
			log(a, b, c);
			Console.WriteLine();
			log(d);
		}

		public void log(object a, object b, object c)
		{
			log(a, b);
			Console.WriteLine();
			log(c);
		}

		public void log(object a, object b)
		{
			log(a);
			Console.WriteLine();
			log(b);
		}
		#endregion
	}
}