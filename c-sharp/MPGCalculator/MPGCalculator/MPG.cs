using System;

namespace MPGCalculator
{
	public class MPG
	{
		private static double totalMiles, totalGallons, totalMPG;
		private static int numTrips;
		private double miles, gallons, mpg;

		public MPG(double miles, double gallons)
		{
			this.miles = miles;
			this.gallons = gallons;
			this.mpg = this.miles / this.gallons;

			MPG.totalMiles += miles;
			MPG.totalGallons += gallons;
			MPG.numTrips++;
			MPG.totalMPG = MPG.totalMiles / MPG.totalGallons;
		}

		public void displayCurrentMPG()
		{
			Console.WriteLine($"This trip = {this.mpg:n2}");
		}

		public static void displayTotalMPG()
		{
			Console.WriteLine($"\nFor {MPG.numTrips} trips, total MPG = {MPG.totalMPG:n2}");
		}
	}
}
