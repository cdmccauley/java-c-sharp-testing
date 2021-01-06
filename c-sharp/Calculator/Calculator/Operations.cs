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

	public int Addition(int left, int right)
	{
		return left + right;
	}

	public double Subtraction(double left, double right)
    {
		return left - right;
	}

	public int Subtraction(int left, int right)
	{
		return left - right;
	}

	public double Multiplication(double left, double right)
	{
		return left * right;
	}

	public int Multiplication(int left, int right)
	{
		return left * right;
	}

	public double Division(double left, double right)
	{
		return right != 0 ? left / right : double.NaN;
	}

	public int Division(int left, int right)
	{
		return right != 0 ? left / right : 0;
	}
}
