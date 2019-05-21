using System;
using Shared;

namespace Riverrun
{
    public class HelloRiverrun : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello from Riverrun.");
        }
    }
}
