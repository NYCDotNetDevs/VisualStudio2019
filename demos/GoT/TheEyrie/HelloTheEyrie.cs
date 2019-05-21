using System;
using Shared;

namespace TheEyrie
{
    public class HelloTheEyrie : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello from The Eyrie.");
        }
    }
}
