using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2CApps.Core
{
    public class Camera:ACamera
    {
        public Camera(string brand) : base()
        {
            this.brand = brand;
            this.channel = new CameraCommChannel();
            this.Init();
        }

        public Camera(IComm comm):base(comm)
        {

        }

        public override string Logs
        {
            get
            {
                StringBuilder temp = new StringBuilder();
                for (int i = 0; i < this.messages.Count; i++)
                {
                    temp.Append(this.messages[i] + Environment.NewLine);
                }

                return temp.ToString();
            }
        }
    }
}
