using System;

namespace Krystek_Lab_2_4
{
	class Program
	{
		static void Main(string[] args)
		{
			// Name:	Keith Krystek
			// Date:	07.22.2020
			// Class: SD1104-A - Full Stack C# Development - Sona Patel - 7 / 11 / 2020
			//
			// Assignment: Lab 2_4
			// =========================================================================

			//Console.WriteLine("Hello World!");

			// Multiply Two Numbers
			int myFirstNumber = 16;
			int mySecondNumber = 244;
			Console.WriteLine(myFirstNumber + " x " + mySecondNumber + " = " + (myFirstNumber * mySecondNumber));

			// Concatenate Text and Number
			string myText = "Some Text";
			Console.WriteLine(myText + " and " + mySecondNumber);

			// Concatenate Two Text Strings
			string moreText = "Goes Here";
			Console.WriteLine(myText + " " + moreText);

			// Display String and Boolean Variables
			string color1 = "Yellow";
			string color2 = "Green";
			bool isYellow = true;
			bool isGreen = false;
			Console.WriteLine(color1 + " " + isYellow + " " + color2 + " " + isGreen);

			// Display a Double Number
			double numbers;
			numbers = mySecondNumber/myFirstNumber;
			Console.WriteLine(numbers);

			// Cast a Double Number and Display
			//double myFirstNumber2 = 16;
			//numbers = mySecondNumber / myFirstNumber2;
			numbers = mySecondNumber / (double)myFirstNumber;
			Console.WriteLine(numbers);

			// Work With a BreakPoint
			Console.WriteLine("BreakPoint Here");

			// Parse Text to a Numeric, Multiply and Display
			string textToNumber = "80473";
			int results = 99 * int.Parse(textToNumber);
			Console.WriteLine(results);

			// Display Today's Date
			DateTime rightNow = DateTime.Now;
			Console.WriteLine(rightNow);

			// End
		}
	}
}
