using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkUs
{
    internal class Globals
    {
        private static appData appdb;

        public static appData Appdb
        {
            get
            {
                if(appdb == null)
                    appdb = new appData();
                return appdb;
            }
        }
    }
}
