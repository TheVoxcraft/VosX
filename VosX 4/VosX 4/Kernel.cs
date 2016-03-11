using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace VOSX


{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Boot.Start(); //Loads up all resources needed for the kernel to function.

            Drivers.Interface.Clear();
            Drivers.Interface.WriteLine("Welcome to VosX!\n");
        }

        protected override void Run()
        {

        }
    }
}