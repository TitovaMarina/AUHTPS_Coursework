using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUHTPS_Coursework.BLL
{
    public class MainTankModel
    {
        private static int _originalTankLevel;
        //private static int _sensorsTankLevel;

        public MainTankModel()
        {
            _originalTankLevel = 0;
        }

        public int OriginalTankLevel 
        { 
            get { return _originalTankLevel; }
            set { _originalTankLevel = value; }
        }

        //public int SensorsTankLevel
        //{
        //    get { return _sensorsTankLevel; }
        //    set { _sensorsTankLevel = value; }
        //}

        public int Add(int newValue)
        {
            _originalTankLevel += newValue;
            return _originalTankLevel;
        }

        public int WaterDrain(int newValue)
        {
            _originalTankLevel -= newValue;
            return _originalTankLevel;
        }
    }
}
