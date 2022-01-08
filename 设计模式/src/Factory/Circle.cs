using Serilog;

namespace Factory;

public class Circle  : IShape
{
    public void Draw()
    {
        Log.Information($"我来自{nameof(Circle)}");
    }
}