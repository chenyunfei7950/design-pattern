using System;
using Volo.Abp.DependencyInjection;

namespace Factory
{
    public class HelloWorldService : ITransientDependency
    {
        public void SayHello()
        {
            var shapeFactory = new ShapeFactory();
            var shape= shapeFactory.Create("CIRCLE");
            shape.Draw();
            
            shape= shapeFactory.Create("RECTANGLE");
            shape.Draw();
            
            shape= shapeFactory.Create("SQUARE");
            shape.Draw();
        }
    }
}
