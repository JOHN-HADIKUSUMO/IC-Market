using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2CApps.Core
{
    public interface IDevice
    {
        string Zoom { get; }
        string DeviceType{ get; }
        string DeviceStatus { get; }
    }
}
