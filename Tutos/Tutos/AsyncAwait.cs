using System.Threading.Tasks;
using System;


static class AsyncAwait
{
	public static async void Start ()
	{
		while (true) {
			// Start computation.
			RunTaskAsync ();
			// Handle user input.
			string result = Console.ReadLine ();
			Console.WriteLine ("You typed: " + result);
		}
	}

	static async void RunTaskAsync ()
	{
		// This method runs asynchronously.
		int t = await Task.Run (DoLongComputing);
		Console.WriteLine ("Compute: " + t);
	}

	static int DoLongComputing ()
	{
		int size = 0;
		for (int z = 0; z < 100; z++) {
			for (int i = 0; i < 100000; i++) {
				string value = i.ToString ();
				size += value.Length;
			}
		}
		return size;
	}
}
