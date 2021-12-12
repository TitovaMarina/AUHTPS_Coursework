using AUHTPS_Coursework.BLL;
using System;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace AUHTPS_Coursework
{
    public partial class Form1 : Form
    {
        private static bool _pump_ValveOn;
        private static bool _waterDrain_ValveOn;
        private MainTankBL mainTankModel;
        DispatcherTimer timerAdd, timerWaterDrain;
        Config _config;
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();

            _config = new Config();
            _pump_ValveOn = false;
            _waterDrain_ValveOn = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            mainTankModel = new MainTankBL();
            
            trackBar_Level.Enabled = false;
            progressBar_Tank.Minimum = 0;
            progressBar_Tank.Maximum = 100;

            timerAdd = new DispatcherTimer();
            timerWaterDrain = new DispatcherTimer();
            ResetTheSystem();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if(mainTankModel.TankLevel < 100)
            {
                button_PumpValve.Enabled = true;
            }
            label_Level.Text = trackBar_Level.Value.ToString();
            labelFinalResult.Text = label_Level.Text;
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("1 - диафрагма камерная;");
            sb.Append("2 – преобразователь дифференциального давления;");
            //toolTip1.SetToolTip(pictureBox2, sb.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Info infoWindow = new Info();
            infoWindow.ShowDialog();
        }

        private void button_PumpValve_Click(object sender, EventArgs e)
        {
            //DispatcherTimer timer = new DispatcherTimer();            

            Helpers.Timer4Tank(timerAdd, ref _pump_ValveOn, button_PumpValve);
        }

        
        //for DispatcherTimer
        private void timer_Tick_Add(object sender, EventArgs e)
        {
            if (mainTankModel.TankLevel < 100)
            {
                mainTankModel.Add(1);
                progressBar_Tank.Value = mainTankModel.TankLevel;
                trackBar_Level.Value = mainTankModel.TankLevel;
            }
            else
            {
                timerAdd.Stop();
                MessageBox.Show("Внимание! Уровень вещества в баке достиг своего максимума. Работа насоса будет приостановлена. Пожалуйста воспользуйтесь вентилем слива.");
                Helpers.TurnOffButton(button_PumpValve);
                button_PumpValve.Enabled = false;
            }
        }

        private int GetCurrentMainTankLevel()
        {
            return Convert.ToInt32(progressBar_Tank.Value);
        }

        private void button_WaterDrainValve_Click(object sender, EventArgs e)
        {
            Helpers.Timer4Tank(timerWaterDrain, ref _waterDrain_ValveOn, button_WaterDrainValve);
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            ResetTheSystem();
        }

        private void timer_Tick_WaterDrain(object sender, EventArgs e)
        {
            if (mainTankModel.TankLevel > 0)
            {
                mainTankModel.WaterDrain(1);
                progressBar_Tank.Value = mainTankModel.TankLevel;
                trackBar_Level.Value = mainTankModel.TankLevel;
            }
            else
            {
                timerWaterDrain.Stop();
                MessageBox.Show("Внимание! Бак полностью опустошен.");
                Helpers.TurnOffButton(button_WaterDrainValve);
            }
        }

        

        private void ResetTheSystem()
        {            
            if(timerAdd.IsEnabled || timerWaterDrain.IsEnabled)
            {
                timerAdd.Stop();
                timerWaterDrain.Stop();
            }
            mainTankModel = new MainTankBL();
            progressBar_Tank.Value = mainTankModel.TankLevel;
            trackBar_Level.Value = mainTankModel.TankLevel;
            _pump_ValveOn = false;
            _waterDrain_ValveOn = false;

            timerAdd = new DispatcherTimer();
            timerAdd.Tick += new EventHandler(timer_Tick_Add);
            timerAdd.Interval = TimeSpan.FromMilliseconds(_config.TimeSpanMillisec);

            timerWaterDrain = new DispatcherTimer();
            timerWaterDrain.Tick += new EventHandler(timer_Tick_WaterDrain);
            timerWaterDrain.Interval = TimeSpan.FromMilliseconds(_config.TimeSpanMillisec);

            Helpers.TurnOffButton(button_PumpValve);
            Helpers.TurnOffButton(button_WaterDrainValve);
        }
    }
}
