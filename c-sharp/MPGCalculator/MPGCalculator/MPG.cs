using System;

public class MPG
{
	// class declarations
	public static double TotalMiles { get; private set; }
	public static double TotalGallons { get; private set; }
	public static double TotalMPG { get; private set; }
	public static int NumTrips { get; private set; }

	// instance declarations
	public double Miles { get; private set; }
	public double Gallons { get; private set; }
	public double Mpg { get; private set; }

	// constructor
	public MPG(double miles, double gallons)
	{
		Miles = miles;
		Gallons = gallons;
		Mpg = Miles / Gallons;

		TotalMiles += miles;
		TotalGallons += gallons;
		NumTrips++;
		TotalMPG = TotalMiles / TotalGallons;
	}

	// functions
	public void displayCurrentMPG()
	{
		Console.WriteLine($"This trip = {Mpg:n2}");
	}

	public static void displayTotalMPG()
	{
		Console.WriteLine($"\nFor {NumTrips} trips, total MPG = {TotalMPG:n2}");
	}
}
