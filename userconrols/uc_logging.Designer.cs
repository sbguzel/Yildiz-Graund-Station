namespace YildizGroundStation.userconrols
{
    partial class uc_logging
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_startstoplog = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Check values that you want to log into your computer as a txt file";
            // 
            // btn_startstoplog
            // 
            this.btn_startstoplog.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_startstoplog.FlatAppearance.BorderSize = 0;
            this.btn_startstoplog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_startstoplog.ForeColor = System.Drawing.Color.White;
            this.btn_startstoplog.Location = new System.Drawing.Point(16, 308);
            this.btn_startstoplog.Margin = new System.Windows.Forms.Padding(0);
            this.btn_startstoplog.Name = "btn_startstoplog";
            this.btn_startstoplog.Size = new System.Drawing.Size(297, 31);
            this.btn_startstoplog.TabIndex = 31;
            this.btn_startstoplog.Text = "Start Logging";
            this.btn_startstoplog.UseVisualStyleBackColor = false;
            this.btn_startstoplog.Click += new System.EventHandler(this.btn_startstoplog_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 342);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(297, 25);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "loop_timer",
            "Accel_X_G",
            "Accel_Y_G",
            "Aceel_Z_G",
            "butter_accx",
            "butter_accy",
            "butter_accz",
            "kalman_roll",
            "kalman_pitch",
            "Vibration_test",
            "acc_raw_x_max",
            "acc_raw_x_min",
            "acc_raw_y_max",
            "acc_raw_y_min",
            "acc_raw_z_max",
            "acc_raw_z_min",
            "Gyro_X_Degs",
            "Gyro_Y_Degs",
            "Gyro_Z_Degs",
            "butter_roll_rate",
            "butter_pitch_rate",
            "butter_yaw_rate",
            "gyro_cal_x",
            "gyro_cal_y",
            "gyro_cal_z",
            "P",
            "actual_pressure_fast",
            "actual_pressure_slow",
            "actual_pressure",
            "ground_pressure",
            "xk_barometer",
            "P_altitude",
            "I_altitude",
            "D_altitude",
            "pid_output_altitude",
            "pid_altitude_input",
            "Roll_rate_P",
            "Roll_rate_I",
            "Roll_rate_D",
            "Pitch_rate_P",
            "Pitch_rate_I",
            "Pitch_rate_D",
            "Yaw_rate_P",
            "Yaw_rate_I",
            "Yaw_rate_D",
            "pid_roll_setpoint",
            "pid_output_roll",
            "pid_pitch_setpoint",
            "pid_output_pitch",
            "pif_yaw_setpoint",
            "pid_output_yaw",
            "pid_roll_angle_setpoint",
            "pid_pitch_angle_setpoint",
            "pulsewidth1",
            "pulsewidth2",
            "pulsewidth3",
            "pulsewidth4",
            "pulsewidth5",
            "pulsewidth6",
            "magX",
            "magY",
            "magZ",
            "actual_compass_heading",
            "takeoff_detected",
            "takeoff_throttle",
            "lat_gps_actual",
            "lon_gps_actual",
            "I_lat_waypoint",
            "I_lon_waypoint",
            "gps_lat_total_average",
            "gps_lon_total_average",
            "lidar_distance",
            "battery_voltage",
            "battery_current",
            "throttle",
            "start",
            "enable",
            "flight_mode",
            "heading_lock"});
            this.checkedListBox1.Location = new System.Drawing.Point(16, 31);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(297, 274);
            this.checkedListBox1.TabIndex = 4;
            // 
            // uc_logging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_startstoplog);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "uc_logging";
            this.Size = new System.Drawing.Size(1575, 865);
            this.SizeChanged += new System.EventHandler(this.uc_logging_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_startstoplog;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}
