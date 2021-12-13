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
        public int TimeSpanMillisec { get; }
        public int Max4TankScaleLevel { get; }
        public int Max4Sensor { get; }

        public Config()
        {
            TimeSpanMillisec = Convert.ToInt32(ConfigurationManager.AppSettings["timeSpanMillisec"]);
            Max4TankScaleLevel = Convert.ToInt32(ConfigurationManager.AppSettings["max4TankScaleLevel"]);
            Max4Sensor = Convert.ToInt32(ConfigurationManager.AppSettings["max4Sensor"]);
        }
    }
}
