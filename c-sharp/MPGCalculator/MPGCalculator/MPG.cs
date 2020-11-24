using System;

public class MPG
{
	// class declarations
	private static double TotalMiles { get; set; }
	private static double TotalGallons { get; set; }
	private static double TotalMPG { get; set; }
	private static int NumTrips { get; set; }

	// instance declarations
	private double Miles { get; set; }
	private double Gallons { get; set; }
	private double Mpg { get; set; }

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
