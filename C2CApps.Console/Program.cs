using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C2CApps.Core;

namespace C2CApps.Run
{
    class Program
    {
        static void Main(string[] args)
        {
            Pentax device = new Pentax();
            device.Channel.SwitchOn();
            Console.WriteLine(device.DeviceStatus);
            device.Channel.ZoomIn();
            Console.WriteLine(device.Zoom);
            device.Channel.ZoomIn();
            device.Channel.ZoomIn();
            Console.WriteLine(device.Zoom);
            device.Channel.SwitchOff();
            Console.WriteLine(device.DeviceStatus);
            Console.WriteLine(device.Logs);
            Console.ReadLine();
        }
    }
}
