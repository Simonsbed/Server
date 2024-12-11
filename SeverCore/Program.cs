using System;

namespace SeverCore
{
	class Program
	{
		static void MainThread()
		{
			Console.WriteLine("Hello Thread!");
		}
		static void Main(string[] args)
		{
			Thread t = new Thread(MainThread); 
			t.Start();
			Console.WriteLine("Hello World");
		}
	}
}
