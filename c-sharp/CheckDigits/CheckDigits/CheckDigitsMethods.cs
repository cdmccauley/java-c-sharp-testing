using System;
using System.Collections.Generic;

namespace CheckDigits
{
	public class CheckDigitsMethods
	{
		public CheckDigitsMethods()
		{
			// wat do?
		}

		public double getTotal(List<double> numbers)
		{
			double total = 0.0;
			foreach (double number in numbers)
				total += number;
			return total;
		}

		public double getAverage(List<double> numbers)
		{
			double total = 0.0;
			foreach (double number in numbers)
				total += number;
			return total / Convert.ToDouble(numbers.Count);
		}

		public double getLargest(List<double> numbers)
		{
			double largest = Double.MinValue;
			foreach (double number in numbers)
				if (number > largest)
					largest = number;
			return largest;
		}

		public double getSmallest(List<double> numbers)
		{
			double smallest = Double.MaxValue;
			foreach (double number in numbers)
				if (number < smallest)
					smallest = number;
			return smallest;
		}
	}
}

