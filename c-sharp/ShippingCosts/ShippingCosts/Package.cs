﻿using System;

namespace ShippingCosts
{
	public class Package
	{
		private double? distance;
		private double? weight;

		public double? Distance
		{
			get
            {
				return distance;
            }
			set
			{
				if (value > 0)
					distance = value;
				else
					distance = null;
			}
		}
		public double? Weight
		{
			get
            {
				return weight;
            }
			set
			{
				if (value > 0.0)
					weight = value;
				else
					weight = null;
			}
		}

		public Package(double distance, double weight)
		{
			this.Distance = distance;
			this.Weight = weight;
		}

		public double getWeightFactor()
        {
			if (Weight < 10.0)
				return 2.5;
			else if (Weight < 25.0)
				return 10.0;
			else
				return 25.0;
        }

		public double getDistanceFactor()
        {
			if (Distance < 100.0)
				return 2.0;
			else if (Distance < 500.0)
				return 5.0;
			else
				return 10.0;
        }

		public bool isValid()
		{
			return !(distance == null) || !(weight == null);
		}

		public double cost()
		{
			if (isValid())
				return getWeightFactor() * getDistanceFactor();
			else
				throw new InvalidPackageException(Distance.ToString(), Weight.ToString());
		}

		public class InvalidPackageException : Exception
        {
			public InvalidPackageException(string distance, string weight) : base(String.Format("Invalid package properties, distance: {0}, weight: {1}.", distance, weight))
            {
				// wat do?
            }
        }
	}
}