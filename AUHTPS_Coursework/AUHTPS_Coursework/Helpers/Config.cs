using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AUHTPS_Coursework
{
    public class Config
    {
        public int TimeSpanMillisec;

        public Config()
        {
            TimeSpanMillisec = Convert.ToInt32(ConfigurationManager.AppSettings["timeSpanMillisec"]);
        }
    }
}
