using System;
namespace Polygons; 

public class CustomRectangle : IPolygon
{
	public string Name
	{ get; set; }
	public int Sides
	{  get; set; }
	public double Length1
	{  get; set; }
	public double Length2
	{ get; set; }
	public double Area
	{  get; set; }
	public double Perimeter
	{ get; set; }

	public CustomRectangle(double length1, double length2 = 0)
	{
		Sides = 4;
		Length1 = length1;
		Length2 = length2;
		Area = Length1 * Length2;
		Perimeter = (Length1 * 2) + (Length2 * 2);
		Name = "Rectangle";
	}

}
