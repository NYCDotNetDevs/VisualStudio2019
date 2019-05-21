using System;
using Shared;

namespace Meereen
{
    public class HelloMeereen : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello from Meereen.");
        }
    }
}
