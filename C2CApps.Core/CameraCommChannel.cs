using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2CApps.Core
{
    public class CameraCommChannel : IComm
    {
        public CameraCommChannel()
        {
        }

        public delegate void delegateZoomIn();
        public event delegateZoomIn eventOnZoomIn;
        public delegate void delegateZoomOut();
        public event delegateZoomOut eventOnZoomOut;
        public delegate void delegateSwitchOn();
        public event delegateSwitchOn eventOnSwitchOn;
        public delegate void delegateSwitchOff();
        public event delegateSwitchOff eventOnSwitchOff;
        public void SwitchOff()
        {
            eventOnSwitchOff.Invoke();
        }

        public void SwitchOn()
        {
            eventOnSwitchOn.Invoke();
        }

        public void ZoomIn()
        {
            eventOnZoomIn.Invoke();
        }

        public void ZoomOut()
        {
            eventOnZoomOut.Invoke();
        }
    }
}
