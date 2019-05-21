using System;
using Shared;

namespace Dragonstone
{
    public class HelloDragonstone : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello from Dragonstone.");
        }
    }
}
