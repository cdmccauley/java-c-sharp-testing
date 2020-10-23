using System;

public class Box
{
	public double Length { get; set; }
	public double Width { get; set; }

	public Box(double length, double width)
	{
		this.Length = length;
		this.Width = width;
	}

	public double getArea()
    {
		return this.Length * this.Width;
    }

	public double getPerimeter()
    {
		return (this.Length + this.Length) + (this.Width + this.Width);
    }
}
