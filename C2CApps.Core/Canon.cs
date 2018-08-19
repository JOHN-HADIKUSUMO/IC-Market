using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2CApps.Core
{
    public class Canon:Camera
    {
        public Canon():base("Canon")
        {
            this.zoomLowLimit = -3;
            this.zoomHighLimit = 6;
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
