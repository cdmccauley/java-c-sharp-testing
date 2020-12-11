using System;

public class Operations
{
	public Operations()
	{
	}

	public double Addition(double left, double right)
    {
		return left + right;
    }

	public double Subtraction(double left, double right)
    {
		return left - right;
	}

	public double Multiplication(double left, double right)
	{
		return left * right;
	}

	public double Division(double left, double right)
	{
		return right != 0 ? left / right : double.NaN;
	}
}
