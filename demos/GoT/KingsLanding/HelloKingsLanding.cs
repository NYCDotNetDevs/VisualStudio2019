using System;
using Shared;

namespace KingsLanding
{
    public class HelloKingsLanding : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello from King's Landing.");
        }
    }
}
