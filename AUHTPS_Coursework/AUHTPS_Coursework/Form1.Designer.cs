
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
            this.button_PumpValve = new System.Windows.Forms.Button();
            this.button_WaterDrainValve = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFinalResult = new System.Windows.Forms.Label();
            this.trackBar_Level = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Stop = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.progressBar_Tank = new AUHTPS_Coursework.VerticalProgressBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Level)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Уровень вещества\r\nв резервуаре:";
            // 
            // label_Level
            // 
            this.label_Level.AutoSize = true;
            this.label_Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Level.Location = new System.Drawing.Point(46, 70);
            this.label_Level.Name = "label_Level";
            this.label_Level.Size = new System.Drawing.Size(19, 20);
            this.label_Level.TabIndex = 7;
            this.label_Level.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.button_PumpValve);
            this.groupBox1.Controls.Add(this.button_WaterDrainValve);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_Level);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelFinalResult);
            this.groupBox1.Controls.Add(this.trackBar_Level);
            this.groupBox1.Controls.Add(this.progressBar_Tank);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(358, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(931, 670);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Стенд";
            // 
            // button_PumpValve
            // 
            this.button_PumpValve.BackColor = System.Drawing.Color.Red;
            this.button_PumpValve.Location = new System.Drawing.Point(290, 528);
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
            this.button_WaterDrainValve.Location = new System.Drawing.Point(138, 404);
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
            this.label4.Location = new System.Drawing.Point(119, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "100";
            // 
            // labelFinalResult
            // 
            this.labelFinalResult.AutoSize = true;
            this.labelFinalResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFinalResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelFinalResult.Location = new System.Drawing.Point(647, 115);
            this.labelFinalResult.Name = "labelFinalResult";
            this.labelFinalResult.Size = new System.Drawing.Size(27, 29);
            this.labelFinalResult.TabIndex = 16;
            this.labelFinalResult.Text = "0";
            // 
            // trackBar_Level
            // 
            this.trackBar_Level.Location = new System.Drawing.Point(38, 91);
            this.trackBar_Level.Maximum = 100;
            this.trackBar_Level.Name = "trackBar_Level";
            this.trackBar_Level.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_Level.Size = new System.Drawing.Size(56, 225);
            this.trackBar_Level.TabIndex = 15;
            this.trackBar_Level.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AUHTPS_Coursework.Properties.Resources.schema;
            this.pictureBox1.Location = new System.Drawing.Point(29, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(893, 643);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // button_Stop
            // 
            this.button_Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Stop.Location = new System.Drawing.Point(143, 43);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(128, 41);
            this.button_Stop.TabIndex = 13;
            this.button_Stop.Text = "Stop and Reset";
            this.button_Stop.UseVisualStyleBackColor = false;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // button_Start
            // 
            this.button_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_Start.Location = new System.Drawing.Point(27, 585);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(84, 40);
            this.button_Start.TabIndex = 11;
            this.button_Start.Text = "Запись?";
            this.button_Start.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1098, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Schema info";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1061, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseClick);
            // 
            // progressBar_Tank
            // 
            this.progressBar_Tank.Location = new System.Drawing.Point(147, 100);
            this.progressBar_Tank.Name = "progressBar_Tank";
            this.progressBar_Tank.Size = new System.Drawing.Size(90, 205);
            this.progressBar_Tank.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 725);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.button_Stop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Level)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Level;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFinalResult;
        private System.Windows.Forms.TrackBar trackBar_Level;
        private VerticalProgressBar progressBar_Tank;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_PumpValve;
        private System.Windows.Forms.Button button_WaterDrainValve;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
    }
}

