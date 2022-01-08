using Serilog;

namespace Factory;

public class Square : IShape
{
    public void Draw()
    {
        Log.Information($"我来自{nameof(Square)}");
    }
}