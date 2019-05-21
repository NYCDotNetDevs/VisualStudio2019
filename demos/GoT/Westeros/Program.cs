using System;
using Shared;
using Dorne;
using CasterlyRock;
using Dragonstone;
using KingsLanding;
using TheEyrie;
using Winterfell;

namespace Westeros
{
    class Program   
    {
        static void Main(string[] args)
        {
            IHello hello = null;

            hello = new HelloDorne();
            hello.SayHello();

            hello = new HelloWinterfell();
            hello.SayHello();

            hello = new HelloEyrie();
            hello.SayHello();

            hello = new HelloKingsLanding();
            hello.SayHello();

            hello = new HelloDragonstone();
            hello.SayHello();

            hello = new HelloCasterlyRock();
            hello.SayHello();
        }
    }
}
