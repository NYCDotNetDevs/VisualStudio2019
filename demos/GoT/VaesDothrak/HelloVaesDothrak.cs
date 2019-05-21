using System;
using Shared;

namespace VaesDothrak
{
    public class HelloVaesDothrak : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello from Vaes Dothrak.");
        }
    }
}
