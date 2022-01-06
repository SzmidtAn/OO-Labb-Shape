namespace ShapeAbstract;

public class Square : Shape
{
    public Square(int sideLength )
    {
        Console.WriteLine("hej");
    }

    public int SideLength { get; set; } = 2;

    public override double GetArea()
    {
        return SideLength * SideLength;
    }

    public override double GetPerimeter()
    {
        return SideLength * 4;
        
    }

    public override string ToString()
    {
        return $"This is a square with side length {SideLength}, area {GetArea()} and perimeter length {GetPerimeter()} ";
    }


}