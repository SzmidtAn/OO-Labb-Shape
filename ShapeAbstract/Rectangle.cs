namespace ShapeAbstract;

public class Rectangle : Shape
{
    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public Rectangle(int width)
    {
        Width = width;
        Height = width;
    }

    private int Height { get; set; }

    private int Width { get; set; } 

    public override double GetArea()
    {
        return Width * Height;
    }

    public override double GetPerimeter()
    {
        return Width + Width + Height + Height;

    }

    public override string ToString()
    {
        return $"This is a rectangle with height {Height} and width {Width}. Area is {GetArea()} and perimeter {GetPerimeter()} ";
    }
}