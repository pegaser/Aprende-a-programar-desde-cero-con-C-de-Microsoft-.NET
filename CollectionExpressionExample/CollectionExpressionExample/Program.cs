using System;
using System.Collections.Generic;

namespace CollectionExpressionExample
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<string> weekDays1 = new List<string>() { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" } ;
			List<string> weekDays2 = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];
			string[] weekDays3 = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];
			foreach (var day in weekDays3) 
			{
				Console.WriteLine(day);
			}

			string[] vowels = ["a", "e", "i", "o", "u"];
			string[] consonants = ["b",
				"c",
				"d",
				"f",
				"g",
				"h",
				"j",
				"k",
				"l",
				"m",
				"n",
				"p",
				"q",
				"r",
				"s",
				"t",
				"v",
				"w",
				"x",
				"z"];
			string[] alphabet = [..vowels, ..consonants, "y"];
			foreach (var letter in alphabet)
			{
				Console.WriteLine(letter);
			}
			Console.ReadKey();
		}
	}
}
