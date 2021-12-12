using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUHTPS_Coursework.BLL
{
    public class MainTankBL
    {
        private static int _tankLevel;

        public MainTankBL()
        {
            _tankLevel = 0;
        }

        public int TankLevel 
        { 
            get { return _tankLevel; }
            set { _tankLevel = value; }
        }

        public int Add(int newValue)
        {
            _tankLevel += newValue;
            return _tankLevel;
        }

        public int WaterDrain(int newValue)
        {
            _tankLevel -= newValue;
            return _tankLevel;
        }
    }
}
