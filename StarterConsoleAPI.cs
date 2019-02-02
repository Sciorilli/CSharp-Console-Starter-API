using System;
using System.Net;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
namespace CSharp_API
{
	public class StarterConsoleAPI
	{
		//C# Console API - Starter 0.1
		//utils
		public string user = Environment.UserName;

		
		//text
		public static void writeLine(string text)
		{
			Console.WriteLine(text);
		}
		public static void writeLine(string text, string prefix)
		{
			Console.WriteLine(prefix + " " + text);
		}
		public static void writeLine(string text, string prefix, ConsoleColor color)
		{
			Console.ForegroundColor = color;
			Console.WriteLine(prefix + " " + text);
			Console.ForegroundColor = ConsoleColor.White;
		}

		public static void write(string text)
		{
			Console.Write(text);
		}
		public static void write(string text, string prefix)
		{
			Console.Write(prefix + " " + text);
		}
		public static void write(string text, string prefix, ConsoleColor color)
		{
			Console.ForegroundColor = color;
			Console.Write(prefix + " " + text);
			Console.ForegroundColor = ConsoleColor.White;
		}

		public static void clear()
		{
			Console.Clear();
		}

		public static string getLine()
		{
			string line = Console.ReadLine();
			if (line.Length < 1) return "Invalid text";

			return line;
		}


		//downloads
		public static string downloadText(string url)
		{
			string text;
			try
			{
				WebClient wb = new WebClient();
				text = wb.DownloadString(url);
			}
			catch
			{
				text = "Error to download text";
			}
			if(text.Length < 1) text = "Error to download text";

			return text;
		}
		public static void downloadFile(string url, string location, string doneMSG, bool debug)
		{
			try
			{
				WebClient wb = new WebClient();
				wb.DownloadFile(url, location);
				Console.WriteLine(doneMSG);
			}
			catch
			{
				
				string error = debug == true ? "Error to download file, link: " + url + " correct usage: downloadFile(\"http://link.com\", \"C:/User/folder/file.ext\");" : "Error to download file!";
				Console.WriteLine(error);
			}
			
		}

		public static void createFile(string filename, string doneMessage)
		{
			try
			{
				File.Create(filename);
			}
			catch
			{
				Console.WriteLine("Error to create file: " + filename);
			}
			

		}

		public static void wait(int time)
		{
			Thread.Sleep(time);
		}
		
		
	}
}
