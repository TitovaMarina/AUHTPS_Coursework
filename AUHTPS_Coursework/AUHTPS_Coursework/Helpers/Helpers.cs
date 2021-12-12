using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace AUHTPS_Coursework
{
    public static class Helpers
    {
        public static void Timer4Tank(DispatcherTimer timer, ref bool valveIsOn, Button button)
        {
            if (!valveIsOn)
            {
                valveIsOn = true;
                TurnOnButton(button);
                timer.Start();
            }
            else
            {
                valveIsOn = false;
                TurnOffButton(button);
                timer.Stop();
            }
        }


        public static void TurnOffButton(Button button)
        {
            button.BackColor = Color.Red;
            button.Text = "Off";            
        }

        public static void TurnOnButton(Button button)
        {
            button.BackColor = Color.Green;
            button.Text = "On";
            
        }
    }
}
