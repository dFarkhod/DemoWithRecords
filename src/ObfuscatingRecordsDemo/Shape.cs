public abstract record Shape
{
    public abstract double CalculateArea();
}

public record Circle(double Radius) : Shape
{
    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

public record Rectangle(double Length, double Width) : Shape
{
    public override double CalculateArea()
    {
        return Length * Width;
    }
}

public record Triangle(double BaseLength, double Height) : Shape
{
    public override double CalculateArea()
    {
        return 0.5 * BaseLength * Height;
    }
}