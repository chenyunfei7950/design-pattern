using System;

namespace AbstractFactory;

public class ShapeFactory
{
    public IShape Create(string shapeType)
    {
        if (shapeType.Equals("CIRCLE", StringComparison.OrdinalIgnoreCase)) return new Circle();
        if (shapeType.Equals("RECTANGLE", StringComparison.OrdinalIgnoreCase)) return new Rectangle();
        if (shapeType.Equals("SQUARE", StringComparison.OrdinalIgnoreCase)) return new Square();
        return null;
    }
}