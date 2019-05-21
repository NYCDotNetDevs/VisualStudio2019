using Shared;
using Meereen;
using Braavos;
using VaesDothrak;
using System;
using System.Collections.Generic;
using System.Text;

namespace Essos
{
    class Program
    {
        static void Main(string[] args)
        {
            IHello hello = null;

            hello = new HelloBraavos();
            hello.SayHello();

            hello = new HelloVaesDothrak();
            hello.SayHello();

            hello = new HelloMeereen();
            hello.SayHello();
        }
    }
}
