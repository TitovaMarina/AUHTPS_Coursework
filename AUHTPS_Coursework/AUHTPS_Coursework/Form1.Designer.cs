
namespace AUHTPS_Coursework
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label_Level = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_PumpValve = new System.Windows.Forms.Button();
            this.button_WaterDrainValve = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_SensorsValue = new System.Windows.Forms.Label();
            this.trackBar_Level = new System.Windows.Forms.TrackBar();
            this.progressBar_Tank = new AUHTPS_Coursework.VerticalProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Stop = new System.Windows.Forms.Button();
            this.button_WriteDataToList = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1_ResultValues = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TankColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SensorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Level)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_ResultValues)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Уровень вещества\r\nв резервуаре:";
            // 
            // label_Level
            // 
            this.label_Level.AutoSize = true;
            this.label_Level.BackColor = System.Drawing.Color.LightGreen;
            this.label_Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Level.Location = new System.Drawing.Point(20, 66);
            this.label_Level.Name = "label_Level";
            this.label_Level.Size = new System.Drawing.Size(66, 29);
            this.label_Level.TabIndex = 7;
            this.label_Level.Text = "0 см";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button_PumpValve);
            this.groupBox1.Controls.Add(this.button_WaterDrainValve);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_Level);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label_SensorsValue);
            this.groupBox1.Controls.Add(this.trackBar_Level);
            this.groupBox1.Controls.Add(this.progressBar_Tank);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(381, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(963, 698);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Стенд";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(253, 622);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 50);
            this.label2.TabIndex = 19;
            this.label2.Text = "Вентиль\r\nнасоса";
            // 
            // button_PumpValve
            // 
            this.button_PumpValve.BackColor = System.Drawing.Color.Red;
            this.button_PumpValve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_PumpValve.Location = new System.Drawing.Point(293, 554);
            this.button_PumpValve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_PumpValve.Name = "button_PumpValve";
            this.button_PumpValve.Size = new System.Drawing.Size(51, 44);
            this.button_PumpValve.TabIndex = 14;
            this.button_PumpValve.Text = "Off";
            this.button_PumpValve.UseVisualStyleBackColor = false;
            this.button_PumpValve.Click += new System.EventHandler(this.button_PumpValve_Click);
            // 
            // button_WaterDrainValve
            // 
            this.button_WaterDrainValve.BackColor = System.Drawing.Color.Red;
            this.button_WaterDrainValve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_WaterDrainValve.Location = new System.Drawing.Point(137, 432);
            this.button_WaterDrainValve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_WaterDrainValve.Name = "button_WaterDrainValve";
            this.button_WaterDrainValve.Size = new System.Drawing.Size(49, 42);
            this.button_WaterDrainValve.TabIndex = 14;
            this.button_WaterDrainValve.Text = "Off";
            this.button_WaterDrainValve.UseVisualStyleBackColor = false;
            this.button_WaterDrainValve.Click += new System.EventHandler(this.button_WaterDrainValve_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "0 см";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(79, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "100 см";
            // 
            // label_SensorsValue
            // 
            this.label_SensorsValue.AutoSize = true;
            this.label_SensorsValue.BackColor = System.Drawing.Color.LightGreen;
            this.label_SensorsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_SensorsValue.ForeColor = System.Drawing.Color.Black;
            this.label_SensorsValue.Location = new System.Drawing.Point(645, 145);
            this.label_SensorsValue.Name = "label_SensorsValue";
            this.label_SensorsValue.Size = new System.Drawing.Size(107, 32);
            this.label_SensorsValue.TabIndex = 16;
            this.label_SensorsValue.Text = "0 у.ед.";
            // 
            // trackBar_Level
            // 
            this.trackBar_Level.BackColor = System.Drawing.Color.White;
            this.trackBar_Level.Enabled = false;
            this.trackBar_Level.Location = new System.Drawing.Point(25, 121);
            this.trackBar_Level.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar_Level.Maximum = 100;
            this.trackBar_Level.Name = "trackBar_Level";
            this.trackBar_Level.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_Level.Size = new System.Drawing.Size(56, 225);
            this.trackBar_Level.TabIndex = 15;
            this.trackBar_Level.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // progressBar_Tank
            // 
            this.progressBar_Tank.Location = new System.Drawing.Point(148, 126);
            this.progressBar_Tank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar_Tank.Name = "progressBar_Tank";
            this.progressBar_Tank.Size = new System.Drawing.Size(91, 206);
            this.progressBar_Tank.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 53);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(917, 629);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // button_Stop
            // 
            this.button_Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Stop.Location = new System.Drawing.Point(76, 61);
            this.button_Stop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(212, 44);
            this.button_Stop.TabIndex = 13;
            this.button_Stop.Text = "Остановить стенд";
            this.button_Stop.UseVisualStyleBackColor = false;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // button_WriteDataToList
            // 
            this.button_WriteDataToList.BackColor = System.Drawing.Color.Lime;
            this.button_WriteDataToList.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_WriteDataToList.ForeColor = System.Drawing.Color.Black;
            this.button_WriteDataToList.Location = new System.Drawing.Point(86, 387);
            this.button_WriteDataToList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_WriteDataToList.Name = "button_WriteDataToList";
            this.button_WriteDataToList.Size = new System.Drawing.Size(179, 44);
            this.button_WriteDataToList.TabIndex = 11;
            this.button_WriteDataToList.Text = "Записать данные";
            this.button_WriteDataToList.UseVisualStyleBackColor = false;
            this.button_WriteDataToList.Click += new System.EventHandler(this.button_WriteDataToList_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1032, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(275, 30);
            this.button3.TabIndex = 15;
            this.button3.Text = "Объяснение обозначений схемы";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1313, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.dataGridView1_ResultValues);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button_WriteDataToList);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 164);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(355, 490);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Область данных";
            // 
            // dataGridView1_ResultValues
            // 
            this.dataGridView1_ResultValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_ResultValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TankColumn,
            this.SensorColumn});
            this.dataGridView1_ResultValues.Location = new System.Drawing.Point(6, 96);
            this.dataGridView1_ResultValues.Name = "dataGridView1_ResultValues";
            this.dataGridView1_ResultValues.RowHeadersWidth = 51;
            this.dataGridView1_ResultValues.RowTemplate.Height = 24;
            this.dataGridView1_ResultValues.Size = new System.Drawing.Size(343, 286);
            this.dataGridView1_ResultValues.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(86, 435);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 44);
            this.button2.TabIndex = 20;
            this.button2.Text = "Очистить данные";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(208, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 54);
            this.label6.TabIndex = 19;
            this.label6.Text = "Показания\r\nвторичного\r\nприбора, у.ед.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(46, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 54);
            this.label5.TabIndex = 18;
            this.label5.Text = "Показания H по\r\nизмерительной \r\nлинейке, см";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(164, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Бак 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(16, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 36);
            this.label8.TabIndex = 21;
            this.label8.Text = "Измерительная\r\nлинейка";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(553, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 36);
            this.label9.TabIndex = 22;
            this.label9.Text = "Вторичный цифровой\r\nприбор";
            // 
            // TankColumn
            // 
            this.TankColumn.HeaderText = "Значение по линейке";
            this.TankColumn.MinimumWidth = 6;
            this.TankColumn.Name = "TankColumn";
            this.TankColumn.ReadOnly = true;
            // 
            // SensorColumn
            // 
            this.SensorColumn.HeaderText = "Значение вторичного прибора";
            this.SensorColumn.MinimumWidth = 6;
            this.SensorColumn.Name = "SensorColumn";
            this.SensorColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 754);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Stop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Имитационная система градуировки гидростатического уровнемера";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Level)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_ResultValues)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Level;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_SensorsValue;
        private System.Windows.Forms.TrackBar trackBar_Level;
        private VerticalProgressBar progressBar_Tank;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Button button_WriteDataToList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_PumpValve;
        private System.Windows.Forms.Button button_WaterDrainValve;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1_ResultValues;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn TankColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorColumn;
    }
}

