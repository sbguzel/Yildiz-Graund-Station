using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YildizGroundStation.userconrols
{
    public partial class uc_setup : UserControl
    {
        public uc_setup()
        {
            InitializeComponent();
        }

        private void uc_setup_SizeChanged(object sender, EventArgs e)
        {
            if (this.Width < 600)
            {
                panel_setup_size_control.Width = this.Width;
            }
            else
            {
                panel_setup_size_control.Width = 600;
            }
            if(this.Width < 500)
            {
                btn_calibrate_Acc.Text = "";
                btn_calibrate_gyro.Text = "";
                btn_calibrate_mag.Text = "";
                btn_calibrate_Acc.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                btn_calibrate_gyro.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                btn_calibrate_mag.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            }
            else
            {
                btn_calibrate_Acc.Text = "Calibrate Accelerometer";
                btn_calibrate_gyro.Text = "Calibrate Gyroscope";
                btn_calibrate_mag.Text = "Calibrate Magnotemeter";
                btn_calibrate_Acc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btn_calibrate_gyro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btn_calibrate_mag.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            }
            if (this.Height < 300)
            {
                panel_setup_size_control.Height = this.Height;
            }
            else
            {
                panel_setup_size_control.Height = 300;
            }
            
        }

        private void btn_calibrate_Acc_Click(object sender, EventArgs e)
        {
            progressBar_cal_acc.Value += 10 ;
        }

        private void btn_calibrate_gyro_Click(object sender, EventArgs e)
        {
            progressBar_cal_gyro.Value += 10;
        }

        private void btn_calibrate_mag_Click(object sender, EventArgs e)
        {
            progressBar_cal_mag.Value += 10;
        }
        
    }
}
