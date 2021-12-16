using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUHTPS_Coursework.BLL
{
    public static class SensorHelper
    {
        public static string GetIncreaseSensorsValue(int max4TankScaleLevel, int max4Sensor, int currentTankLevel)
        {
            var value = CalculateSensorsValue(max4TankScaleLevel, max4Sensor, currentTankLevel);
            return String.Format("{0} у.ед", value);
        }

        public static string GetDecreaseSensorsValue(int max4TankScaleLevel, int max4Sensor, int currentTankLevel)
        {
            var value = CalculateSensorsValue(max4TankScaleLevel, max4Sensor, currentTankLevel);
            var errorValue = value + value * 0.02;
            return String.Format("{0} у.ед", Math.Round(errorValue));
        }

        public static int CalculateSensorsValue(int max4TankScaleLevel, int max4Sensor, int currentTankLevel)
        {
            return (max4Sensor * currentTankLevel) / max4TankScaleLevel;
        }

    }
}
