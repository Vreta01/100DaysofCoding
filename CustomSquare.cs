using System;
namespace Polygons;

public class CustomSquare : CustomRectangle, IPolygon
{

	double Length
	{ get; set; }

	public CustomSquare(double length) : base(length)
	{
		Length = length;
		Area = Length * Length;
		Perimeter = Length * Sides;
		Name = "Square";
	}
}
