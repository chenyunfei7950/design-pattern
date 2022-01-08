﻿using System;
using Volo.Abp.DependencyInjection;

namespace AbstractFactory
{
    public class HelloWorldService : ITransientDependency
    {
        public void SayHello()
        {
            Console.WriteLine("\tHello World!");
        }
    }
}
