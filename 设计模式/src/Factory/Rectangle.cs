using Serilog;

namespace Factory;

public class Rectangle : IShape
{
    public void Draw()
    {
        Log.Information($"我来自{nameof(Rectangle)}");
    }
}