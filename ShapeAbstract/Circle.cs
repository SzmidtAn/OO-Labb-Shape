namespace ShapeAbstract;

public class Circle : Shape
{
    public Circle(int radius)
    {
        Radius = radius;
    }

    private double Radius { get; set; }

    public override double GetArea()
    {
        return 3.14 * Radius * Radius;
    }

    public override double GetPerimeter()
    {
        return 2 * 3.14 * Radius;
    }

    public override string ToString()
    {
        return $"This is a circle with radius {Radius}. The area is {GetArea()} and the perimeter is {GetPerimeter()} ";
    }

}