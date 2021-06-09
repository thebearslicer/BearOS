using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace CosmosOS
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.WriteLine("BearOS booted successfully!");
        }

        protected override void Run()
        {
            my_console.input();         //just runs the input thing, idk if I add anything here later but whatever
        }
        

    }
}
