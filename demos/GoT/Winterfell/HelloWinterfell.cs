using System;
using Shared;

namespace Winterfell
{
    public class HelloWinterfell : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello from Winterfell.");
        }
    }
}
