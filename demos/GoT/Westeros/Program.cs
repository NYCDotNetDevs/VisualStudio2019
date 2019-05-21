using System;
using Shared;
using Dorne;
using CasterlyRock;
using Dragonstone;
using KingsLanding;
using TheEyrie;
using Winterfell;
using System.Reflection;

namespace Westeros
{
    class Program   
    {
        static void Main(string[] args)
        {
            IHello hello = null;

            string[] cities = { "Dorne", "Winterfell", "TheEyrie", "KingsLanding", "Dragonstone", "CasterlyRock" };

            foreach (string city in cities) {
                var type = Type.GetType(city + ".Hello" + city + "," + city);
                hello = (IHello)Activator.CreateInstance(type);
                hello.SayHello();
            }
        }
    }
}
