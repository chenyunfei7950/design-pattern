using Serilog;

namespace AbstractFactory;

public class Square : IShape
{
    public void Draw()
    {
        Log.Information($"我来自{nameof(Square)}");
    }
}