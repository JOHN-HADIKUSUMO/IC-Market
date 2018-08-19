using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2CApps.Core
{
    public abstract class ACamera: IDevice
    {
        protected List<string> messages;
        protected string brand;
        protected int zoomLowLimit;
        protected int zoomHighLimit;
        protected int zoomlevel;
        protected IComm channel;
        protected TypeOfDeviceStatus status;
        public ACamera()
        {

        }

        protected void Init()
        {
            this.messages = new List<string>();
            this.zoomlevel = 0; /* normal sight */
            this.zoomLowLimit = -5;
            this.zoomHighLimit = 5;
            ((CameraCommChannel)this.channel).eventOnSwitchOff += EventOnSwitchOff;
            ((CameraCommChannel)this.channel).eventOnSwitchOn += EventOnSwitchOn;
            ((CameraCommChannel)this.channel).eventOnZoomIn += EventOnZoomIn;
            ((CameraCommChannel)this.channel).eventOnZoomOut += EventOnZoomOut;
        }

        public ACamera(IComm comm)
        {
            this.channel = comm;
            Init();
        }

        private void EventOnZoomOut()
        {
            string timestamp = string.Format("{0: dd/MM/yyyy hh:mm:ss}", DateTime.Now);

            if (this.zoomlevel > this.zoomLowLimit)
            {
                this.zoomlevel--;
                if(zoomlevel == 0)
                    this.messages.Add(timestamp + @" The camera has been zoomed out to normal scale");
                else
                    this.messages.Add(timestamp + @" The camera has been zoomed out to " + this.zoomlevel.ToString() + " X times");
            }
            else
            {
                this.messages.Add(timestamp + @" The camera is unable to be zoomed out further.");
            }
        }

        private void EventOnZoomIn()
        {
            string timestamp = string.Format("{0: dd/MM/yyyy hh:mm:ss}", DateTime.Now);
            if (this.zoomlevel < this.zoomHighLimit)
            {
                this.zoomlevel++;
                if(zoomlevel == 0)
                    this.messages.Add(timestamp + @" The camera has been zoomed in to normal scale");
                else
                    this.messages.Add(timestamp + @" The camera has been zoomed in to " + this.zoomlevel.ToString() + " X times");
            }
            else
            {
                this.messages.Add(timestamp + @" The camera is unable to be zoomed in further.");
            }
        }

        private void EventOnSwitchOn()
        {
            string timestamp = string.Format("{0: dd/MM/yyyy hh:mm:ss}", DateTime.Now);

            if (this.status == TypeOfDeviceStatus.Off)
            {
                this.status = TypeOfDeviceStatus.On;
                this.messages.Add(timestamp + @" The camera has been switched on");
            }
            else
            {
                this.messages.Add(timestamp + @" The camera has been switched on already.");
            }
        }

        private void EventOnSwitchOff()
        {
            string timestamp = string.Format("{0: dd/MM/yyyy hh:mm:ss}", DateTime.Now);

            if (this.status == TypeOfDeviceStatus.On)
            {
                this.status = TypeOfDeviceStatus.Off;
                this.messages.Add(timestamp + @" The camera has been switched off");
            }
            else
            {
                this.messages.Add(timestamp + @" The camera has been switched off already.");
            }
        }

        public IComm Channel
        {
            get
            {
                return this.channel;
            }
        }

        public string DeviceType
        {
            get {
                return TypeOfDevices.Camera.ToString();
            }
        }

        public string Brand {
            get{
                return this.brand;
            }                
        }

        public string DeviceStatus {
            get
            {
                return this.status.ToString();
            }
        }

        public string Zoom
        {
            get
            {
                string result = string.Empty;

                switch(zoomlevel)
                {
                    case 0:
                        { 
                            result = "normal";
                            break;
                        }
                    case 1:
                        {
                            result = zoomlevel + " X time";
                            break;
                        }
                    default:
                        {
                            result = zoomlevel + " X times";
                            break;
                        }
                }
                return result;
            }
        }

        public void ClearReport()
        {
            this.messages.Clear();
        }

        public abstract string Logs { get; }
    }
}
