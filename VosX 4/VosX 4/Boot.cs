using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOSX
{
    static class Boot
    {
        public static void Start()
        {


            //All booting code above this line.
            Drivers.Interface.WriteLine("BootLoad loaded correctly", "green");
            Drivers.Interface.WriteLine("VosX booted successfully", "green");
        }
    }
}
