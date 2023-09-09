using System;
namespace Polygons;

public interface IPolygon
{
	public string Name { get; set; }
	public int Sides { get; set; }
	public double Perimeter { get; set; }
	public double Area { get; set; }

}
