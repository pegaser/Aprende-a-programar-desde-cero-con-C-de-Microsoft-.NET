namespace InputParametersLambdaExpressions
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Action line = () => Console.WriteLine();
			Console.WriteLine("Hello");
			line();
			Console.WriteLine("World");
			Console.ReadKey();

			Func<double,double> cube = x => x * x * x;
			line();
			Console.WriteLine(cube(3));
			Console.ReadKey();

			Func<int, int, bool> testForEquality = (x, y) => x == y;
			line();
			Console.WriteLine(testForEquality(1,2));
			Console.ReadKey();

			var isTooLong = (int x, string s) => s.Length > x;
			line();
			Console.WriteLine(isTooLong(3, "ABCDE"));
			Console.ReadKey();

			var IncrementBy = (int source, int increment = 1) => source + increment;
			line();
			Console.WriteLine(IncrementBy(5));
			Console.WriteLine(IncrementBy(5, 2));
			Console.ReadKey();

		}
	}
}
