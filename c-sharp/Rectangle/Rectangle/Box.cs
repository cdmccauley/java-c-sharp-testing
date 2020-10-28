using System;

public class Box
{
	public double Length { get; set; }
	public double Width { get; set; }
	public double Height { get; set; }

	public Box(double length, double width)
	{
		this.Length = length;
		this.Width = width;
		this.Height = 0;
	}

	public Box(double length, double width, double height)
    {
		this.Length = length;
		this.Width = width;
		this.Height = height;
	}

	public double getArea()
    {
		return this.Length * this.Width;
    }

	public double getPerimeter()
    {
		return (this.Length + this.Length) + (this.Width + this.Width);
    }

	public double getVolume()
    {
		return this.Length * this.Height * this.Width;
    }
}
