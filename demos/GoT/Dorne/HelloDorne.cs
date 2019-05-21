using Shared;
using System;

namespace Dorne
{
    public class HelloDorne : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello from Dorne.");
        }
    }
}
