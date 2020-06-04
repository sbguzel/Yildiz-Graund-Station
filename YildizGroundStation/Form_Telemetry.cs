using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YildizGroundStation.userconrols;

namespace YildizGroundStation
{
    public partial class Form_Telemetry : Form
    {
        int mov, movX, movY;
        bool iscollapse = false;
        uc_setup ucsetup = new uc_setup();
        uc_mission ucmission = new uc_mission();
        uc_logging uclogging = new uc_logging();
        uc_pidtunning ucpidtunning = new uc_pidtunning();
        uc_aboutus ucaboutus = new uc_aboutus();
        
        byte[] temp = new byte[200];
        byte[] ConvertionBuffer = new byte[4];
        int cmp;

        // Mesajlar
        int TELEMETRY_BYTE = 11;
        public static byte error = 0;
        float float_Roll = 0;
        float float_Pitch = 0;
        int yaw_angle = 0;
        int altitude_msg = 0;
        byte check = 0;

        //int target_difference;
        //int throttle;
        //byte flight_mode;
        //float voltage;
        //byte temperature;
        //byte enable;
        //byte start;
        //byte heading_lock;
        //byte num_of_satellites;
        //byte fix_type;
        //int lat_temp;
        //int lon_temp;


        string key = "";
        public static float current_p = 1.45f, current_I = 0.02f, current_D = 2.65f;
        public static float roll_rate = 0, roll_rate_setpoint = 0, pitch_rate = 10, pitch_rate_setpoint = 10,
            yaw_rate = 20, yaw_rate_setpoint = 20, height = 30, height_setpoint = 30;


        public Form_Telemetry()
        {
            InitializeComponent();
            
        }
        
        private void Form_Telemetry_Load(object sender, EventArgs e)
        {
            timerTime.Start();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            panel_usercontrol.Controls.Add(ucsetup);
            panel_usercontrol.Controls.Add(ucmission);
            panel_usercontrol.Controls.Add(uclogging);
            panel_usercontrol.Controls.Add(ucpidtunning);
            panel_usercontrol.Controls.Add(ucaboutus);
            ucsetup.Dock = DockStyle.Fill;
            ucmission.Dock = DockStyle.Fill;
            uclogging.Dock = DockStyle.Fill;
            ucpidtunning.Dock = DockStyle.Fill;
            ucaboutus.Dock = DockStyle.Fill;
            string[] ports = SerialPort.GetPortNames();
            cBox_ports.Items.AddRange(ports);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            if (iscollapse == false)
            {
                panel_menu.Width = 60;
                iscollapse = true;
            }
            else
            {
                panel_menu.Width = 200;
                iscollapse = false;
            }

        }

        private  void AddControlsToPanel(Control c)
        {
            panel_usercontrol.Controls.SetChildIndex(c, 0);
        }

        private void btn_setup_Click(object sender, EventArgs e)
        {
            AddControlsToPanel(ucsetup);
        }

        private void btn_mission_Click(object sender, EventArgs e)
        {
            AddControlsToPanel(ucmission);
        }

        private void Form_Telemetry_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                e.Cancel = true;
                Thread Exit = new Thread(new ThreadStart(CloseSerialExit)); //close port in new thread to avoid hang
                Exit.Start(); //close port in new thread to avoid hang
            }
        }

        private void CloseSerial()
        {
            try
            {
                serialPort.Close(); //close the serial port
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //catch any serial port closing error messages
            }
            //this.Invoke(new EventHandler(NowClose)); //now close back in the main thread
        }

        private void CloseSerialExit()
        {
            try
            {
                serialPort.Close(); //close the serial port
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //catch any serial port closing error messages
            }
            this.Invoke(new EventHandler(NowClose)); //now close back in the main thread
        }

        private void NowClose(object sender, EventArgs e)
        {
            this.Close(); //now close the form
        }

        private void btn_datalogging_Click(object sender, EventArgs e)
        {
            AddControlsToPanel(uclogging);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbl_Time.Text = dt.ToString("dd MMM HH:mm:ss");
        }

        private void btn_aboutus_Click(object sender, EventArgs e)
        {
            AddControlsToPanel(ucaboutus);
        }

        private void btn_pidtunning_Click(object sender, EventArgs e)
        {
            AddControlsToPanel(ucpidtunning);
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (!(serialPort.IsOpen))
            {
                try
                {
                    serialPort.PortName = cBox_ports.Text;
                    serialPort.BaudRate = Convert.ToInt32(cBox_baudrate.Text);
                    serialPort.DataBits = Convert.ToInt32(8);

                    serialPort.Open();

                    btn_connect.BackColor = Color.LightGreen;
                    btn_connect.Text = "Connected";
                    
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                if (serialPort.IsOpen && btn_connect.Text == "Disconnect")
                {
                    serialPort.Close();
                    btn_connect.BackColor = Color.DarkGreen;
                    btn_connect.Text = "Disconnected";
                }
            }
        }

        private void btn_connect_MouseEnter(object sender, EventArgs e)
        {
            if (btn_connect.Text == "Disconnected" && !(serialPort.IsOpen))
            {
                btn_connect.Text = "Connect";
            }
            if (serialPort.IsOpen && btn_connect.Text == "Connected")
            {
                btn_connect.Text = "Disconnect";
            }
        }

        private void btn_connect_MouseLeave(object sender, EventArgs e)
        {
            if (btn_connect.Text == "Connect" && !(serialPort.IsOpen))
            {
                btn_connect.Text = "Disconnected";
            }

            if (btn_connect.Text == "Disconnect" && serialPort.IsOpen)
            {
                btn_connect.Text = "Connected";
            }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int a = serialPort.BytesToRead;
                while (a > TELEMETRY_BYTE)
                {
                    if (a >= 200 + TELEMETRY_BYTE)
                        serialPort.Read(temp, 0, 200);
                    else if (a > TELEMETRY_BYTE)
                        serialPort.Read(temp, 0, a - TELEMETRY_BYTE);

                    a = serialPort.BytesToRead;
                }

                while (true)
                {
                    cmp = serialPort.ReadByte();
                    if (cmp == 'B')
                    {
                        cmp = serialPort.ReadByte();
                        if (cmp == 'G')

                            break;
                    }
                }

                while (serialPort.BytesToRead <= TELEMETRY_BYTE - 2) ;

                serialPort.Read(temp, 0, TELEMETRY_BYTE - 2);
                // Check Biti Kontrolü
                //visual_studio_check = 0;

                //for (check_counter = 0; check_counter < TELEMETRY_BYTE - 3; check_counter++)
                //{
                //    visual_studio_check = (byte)((int)visual_studio_check ^ (int)temp[check_counter]);
                //}

                //this.Invoke(new EventHandler(ShowData));
                error = temp[0];   //3

                //Float Roll
                ConvertionBuffer[0] = temp[1];  //4
                ConvertionBuffer[1] = temp[2];  //5
                roll_rate = BitConverter.ToInt16(ConvertionBuffer, 0) / 100.0f;

                //Float Pitch
                ConvertionBuffer[0] = temp[3];  //6
                ConvertionBuffer[1] = temp[4];  //7
                float_Pitch = BitConverter.ToInt16(ConvertionBuffer, 0) / 100.0f;

                //Yaw Angle
                ConvertionBuffer[0] = temp[5];  //8
                ConvertionBuffer[1] = temp[6]; //9
                yaw_angle = BitConverter.ToInt16(ConvertionBuffer, 0);

                //Altitude_msg
                ConvertionBuffer[0] = temp[7]; //10
                ConvertionBuffer[1] = temp[8]; //11
                altitude_msg = BitConverter.ToInt16(ConvertionBuffer, 0);

                //Check
                //check = temp[9];   //12
            }

            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //lbl_test.Text = error.ToString() + " " + float_Roll.ToString() + " " + float_Pitch.ToString() + " "
            //    + yaw_angle.ToString() + " " + altitude_msg + " " + check.ToString();

            key = ucpidtunning.getkey();
            
            if (key!="")
            {
                serialPort.Write(key);
                lbl_test.Text += key;
                ucpidtunning.control = false;
            }

        }
        
       
        private void panel_top_MouseMove(object sender, MouseEventArgs e)
        {
            if(mov==1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
            
        }

        private void panel_top_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void panel_top_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        
    }
}
