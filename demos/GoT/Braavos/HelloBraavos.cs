using System;
using Shared;

namespace Braavos
{
    public class HelloBraavos : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello from Braavos.");
        }
    }
}
