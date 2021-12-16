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
        private MainTankModel mainTankModel;
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
            mainTankModel = new MainTankModel();
            
            trackBar_Level.Enabled = false;
            progressBar_Tank.Minimum = 0;
            progressBar_Tank.Maximum = _config.Max4TankScaleLevel;

            timerAdd = new DispatcherTimer();
            timerWaterDrain = new DispatcherTimer();
            ResetTheSystem();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if(mainTankModel.OriginalTankLevel < _config.Max4TankScaleLevel)
            {
                button_PumpValve.Enabled = true;
            }
            label_Level.Text = trackBar_Level.Value.ToString() + " см";
            //labelFinalResult.Text = label_Level.Text;
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
            if (mainTankModel.OriginalTankLevel < _config.Max4TankScaleLevel)
            {
                mainTankModel.Add(1);
                CalculateTheValues(mainTankModel);
            }
            else
            {
                timerAdd.Stop();
                MessageBox.Show("Уровень вещества в баке достиг своего максимума. Работа насоса будет приостановлена. Пожалуйста воспользуйтесь вентилем слива.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Helpers.TurnOffButton(button_PumpValve);
                button_PumpValve.Enabled = false;
                _pump_ValveOn = false;
            }
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
            if (mainTankModel.OriginalTankLevel > 0)
            {
                mainTankModel.WaterDrain(1);
                CalculateTheValues(mainTankModel);
            }
            else
            {
                timerWaterDrain.Stop();
                MessageBox.Show("Бак полностью опустошен.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _waterDrain_ValveOn = false;
                Helpers.TurnOffButton(button_WaterDrainValve);
            }
        }

        private void button_WriteDataToList_Click(object sender, EventArgs e)
        {
            dataGridView1_ResultValues.AllowUserToAddRows = false;
            dataGridView1_ResultValues.Rows.Add(progressBar_Tank.Value.ToString().Split(' ')[0],
                label_SensorsValue.Text.Split(' ')[0]);
            //Split() is needed to remove "см/у.ед." from label values
            //this.dataGridView1_ResultValues.Rows[index].Cells[1].Value = progressBar_Tank.Value.ToString().Split(' ')[0];
            //this.dataGridView1_ResultValues.Rows[index].Cells[2].Value = label_SensorsValue.Text.Split(' ')[0];

        }

        private void CalculateTheValues(MainTankModel mainTankModel)
        {
            progressBar_Tank.Value = mainTankModel.OriginalTankLevel;
            trackBar_Level.Value = mainTankModel.OriginalTankLevel;
            if (_pump_ValveOn)
            {
                label_SensorsValue.Text = SensorHelper.GetIncreaseSensorsValue(_config.Max4TankScaleLevel, _config.Max4Sensor, mainTankModel.OriginalTankLevel).ToString();
            }
            else if(_waterDrain_ValveOn)
            {
                label_SensorsValue.Text = SensorHelper.GetDecreaseSensorsValue(_config.Max4TankScaleLevel, _config.Max4Sensor, mainTankModel.OriginalTankLevel).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearTableWithResults();
        }

        private void ClearTableWithResults()
        {
            dataGridView1_ResultValues.Rows.Clear();
            dataGridView1_ResultValues.Refresh();
        }

        private void ResetTheSystem()
        {            
            if(timerAdd.IsEnabled || timerWaterDrain.IsEnabled)
            {
                timerAdd.Stop();
                timerWaterDrain.Stop();
            }
            mainTankModel = new MainTankModel();
            progressBar_Tank.Value = mainTankModel.OriginalTankLevel;
            trackBar_Level.Value = mainTankModel.OriginalTankLevel;
            label_SensorsValue.Text = "0 у.ед.";
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

            //ClearTableWithResults();
        }
    }
}
