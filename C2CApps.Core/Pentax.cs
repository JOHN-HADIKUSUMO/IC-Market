using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2CApps.Core
{
    public class Pentax:Camera
    {
        public Pentax():base("Pentax")
        {
            this.zoomLowLimit = -2;
            this.zoomHighLimit = 2;
        }

        public override string Logs
        {
            get
            {
                StringBuilder temp = new StringBuilder();
                temp.Append("=========================== " + base.brand + " ===========================" + Environment.NewLine);
                temp.Append(base.Logs);
                temp.Append(Environment.NewLine + Environment.NewLine);
                return temp.ToString();
            }
        }
    }
}
