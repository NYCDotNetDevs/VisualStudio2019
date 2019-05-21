using System;
using Shared;

namespace TheEyrie
{
    public class HelloEyrie : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello from The Eyrie.");
        }
    }
}
