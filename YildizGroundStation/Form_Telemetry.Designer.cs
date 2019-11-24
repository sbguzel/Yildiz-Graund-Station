namespace YildizGroundStation
{
    partial class Form_Telemetry
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Telemetry));
            this.panel_top = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cBox_baudrate = new System.Windows.Forms.ComboBox();
            this.cBox_ports = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.lbl_test = new System.Windows.Forms.Label();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel_statues = new System.Windows.Forms.Panel();
            this.lbl_programinfo = new System.Windows.Forms.Label();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btn_aboutus = new System.Windows.Forms.Button();
            this.btn_pidtunning = new System.Windows.Forms.Button();
            this.btn_datalogging = new System.Windows.Forms.Button();
            this.btn_mission = new System.Windows.Forms.Button();
            this.btn_setup = new System.Windows.Forms.Button();
            this.panel_usercontrol = new System.Windows.Forms.Panel();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.panel_top.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_statues.SuspendLayout();
            this.panel_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.DarkGreen;
            this.panel_top.Controls.Add(this.panel2);
            this.panel_top.Controls.Add(this.btn_connect);
            this.panel_top.Controls.Add(this.panel1);
            this.panel_top.Controls.Add(this.lbl_test);
            this.panel_top.Controls.Add(this.btn_minimize);
            this.panel_top.Controls.Add(this.btn_close);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1280, 45);
            this.panel_top.TabIndex = 0;
            this.panel_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseDown);
            this.panel_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseMove);
            this.panel_top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseUp);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cBox_baudrate);
            this.panel2.Controls.Add(this.cBox_ports);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(576, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 45);
            this.panel2.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "USB Port";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBox_baudrate
            // 
            this.cBox_baudrate.BackColor = System.Drawing.Color.White;
            this.cBox_baudrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBox_baudrate.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBox_baudrate.FormattingEnabled = true;
            this.cBox_baudrate.Items.AddRange(new object[] {
            "57600",
            "115200"});
            this.cBox_baudrate.Location = new System.Drawing.Point(266, 10);
            this.cBox_baudrate.Name = "cBox_baudrate";
            this.cBox_baudrate.Size = new System.Drawing.Size(100, 25);
            this.cBox_baudrate.TabIndex = 20;
            this.cBox_baudrate.Text = "57600";
            // 
            // cBox_ports
            // 
            this.cBox_ports.BackColor = System.Drawing.Color.White;
            this.cBox_ports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBox_ports.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBox_ports.ForeColor = System.Drawing.Color.Black;
            this.cBox_ports.FormattingEnabled = true;
            this.cBox_ports.ItemHeight = 17;
            this.cBox_ports.Location = new System.Drawing.Point(77, 10);
            this.cBox_ports.Margin = new System.Windows.Forms.Padding(0);
            this.cBox_ports.Name = "cBox_ports";
            this.cBox_ports.Size = new System.Drawing.Size(99, 25);
            this.cBox_ports.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(181, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Baud Rate";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_connect
            // 
            this.btn_connect.AutoSize = true;
            this.btn_connect.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_connect.FlatAppearance.BorderSize = 0;
            this.btn_connect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btn_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connect.ForeColor = System.Drawing.Color.White;
            this.btn_connect.Location = new System.Drawing.Point(945, 0);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(0);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(127, 45);
            this.btn_connect.TabIndex = 24;
            this.btn_connect.Text = "Disconnected";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            this.btn_connect.MouseEnter += new System.EventHandler(this.btn_connect_MouseEnter);
            this.btn_connect.MouseLeave += new System.EventHandler(this.btn_connect_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.lbl_Time);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1072, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 45);
            this.panel1.TabIndex = 26;
            // 
            // lbl_Time
            // 
            this.lbl_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Time.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Time.ForeColor = System.Drawing.Color.White;
            this.lbl_Time.Location = new System.Drawing.Point(12, 14);
            this.lbl_Time.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(144, 19);
            this.lbl_Time.TabIndex = 8;
            this.lbl_Time.Text = "DD MMM HH:MM:SS";
            this.lbl_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_test
            // 
            this.lbl_test.AutoSize = true;
            this.lbl_test.ForeColor = System.Drawing.Color.White;
            this.lbl_test.Location = new System.Drawing.Point(100, 17);
            this.lbl_test.Name = "lbl_test";
            this.lbl_test.Size = new System.Drawing.Size(49, 15);
            this.lbl_test.TabIndex = 25;
            this.lbl_test.Text = "label2";
            // 
            // btn_minimize
            // 
            this.btn_minimize.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_minimize.ForeColor = System.Drawing.Color.White;
            this.btn_minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimize.Image")));
            this.btn_minimize.Location = new System.Drawing.Point(0, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(60, 45);
            this.btn_minimize.TabIndex = 4;
            this.btn_minimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_minimize.UseVisualStyleBackColor = true;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(1235, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(45, 45);
            this.btn_close.TabIndex = 7;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel_statues
            // 
            this.panel_statues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel_statues.Controls.Add(this.lbl_programinfo);
            this.panel_statues.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_statues.Location = new System.Drawing.Point(0, 45);
            this.panel_statues.Name = "panel_statues";
            this.panel_statues.Size = new System.Drawing.Size(1280, 20);
            this.panel_statues.TabIndex = 1;
            // 
            // lbl_programinfo
            // 
            this.lbl_programinfo.AutoSize = true;
            this.lbl_programinfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_programinfo.ForeColor = System.Drawing.Color.White;
            this.lbl_programinfo.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbl_programinfo.Location = new System.Drawing.Point(0, 0);
            this.lbl_programinfo.Name = "lbl_programinfo";
            this.lbl_programinfo.Size = new System.Drawing.Size(182, 15);
            this.lbl_programinfo.TabIndex = 0;
            this.lbl_programinfo.Text = "Telemetry ready for setup";
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.DarkGreen;
            this.panel_menu.Controls.Add(this.btn_aboutus);
            this.panel_menu.Controls.Add(this.btn_pidtunning);
            this.panel_menu.Controls.Add(this.btn_datalogging);
            this.panel_menu.Controls.Add(this.btn_mission);
            this.panel_menu.Controls.Add(this.btn_setup);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 65);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(200, 684);
            this.panel_menu.TabIndex = 2;
            // 
            // btn_aboutus
            // 
            this.btn_aboutus.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_aboutus.FlatAppearance.BorderSize = 0;
            this.btn_aboutus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btn_aboutus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aboutus.ForeColor = System.Drawing.Color.White;
            this.btn_aboutus.Image = ((System.Drawing.Image)(resources.GetObject("btn_aboutus.Image")));
            this.btn_aboutus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_aboutus.Location = new System.Drawing.Point(0, 264);
            this.btn_aboutus.Name = "btn_aboutus";
            this.btn_aboutus.Size = new System.Drawing.Size(200, 60);
            this.btn_aboutus.TabIndex = 7;
            this.btn_aboutus.Text = "About Us";
            this.btn_aboutus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_aboutus.UseVisualStyleBackColor = true;
            this.btn_aboutus.Click += new System.EventHandler(this.btn_aboutus_Click);
            // 
            // btn_pidtunning
            // 
            this.btn_pidtunning.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_pidtunning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_pidtunning.FlatAppearance.BorderSize = 0;
            this.btn_pidtunning.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btn_pidtunning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pidtunning.ForeColor = System.Drawing.Color.White;
            this.btn_pidtunning.Image = ((System.Drawing.Image)(resources.GetObject("btn_pidtunning.Image")));
            this.btn_pidtunning.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pidtunning.Location = new System.Drawing.Point(0, 198);
            this.btn_pidtunning.Name = "btn_pidtunning";
            this.btn_pidtunning.Size = new System.Drawing.Size(200, 60);
            this.btn_pidtunning.TabIndex = 6;
            this.btn_pidtunning.Text = "Pid Tunning";
            this.btn_pidtunning.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_pidtunning.UseVisualStyleBackColor = true;
            this.btn_pidtunning.Click += new System.EventHandler(this.btn_pidtunning_Click);
            // 
            // btn_datalogging
            // 
            this.btn_datalogging.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_datalogging.FlatAppearance.BorderSize = 0;
            this.btn_datalogging.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btn_datalogging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_datalogging.ForeColor = System.Drawing.Color.White;
            this.btn_datalogging.Image = ((System.Drawing.Image)(resources.GetObject("btn_datalogging.Image")));
            this.btn_datalogging.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_datalogging.Location = new System.Drawing.Point(0, 132);
            this.btn_datalogging.Name = "btn_datalogging";
            this.btn_datalogging.Size = new System.Drawing.Size(200, 60);
            this.btn_datalogging.TabIndex = 5;
            this.btn_datalogging.Text = "Data Logging";
            this.btn_datalogging.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_datalogging.UseVisualStyleBackColor = true;
            this.btn_datalogging.Click += new System.EventHandler(this.btn_datalogging_Click);
            // 
            // btn_mission
            // 
            this.btn_mission.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_mission.FlatAppearance.BorderSize = 0;
            this.btn_mission.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btn_mission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mission.ForeColor = System.Drawing.Color.White;
            this.btn_mission.Image = ((System.Drawing.Image)(resources.GetObject("btn_mission.Image")));
            this.btn_mission.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mission.Location = new System.Drawing.Point(0, 66);
            this.btn_mission.Name = "btn_mission";
            this.btn_mission.Size = new System.Drawing.Size(200, 60);
            this.btn_mission.TabIndex = 4;
            this.btn_mission.Text = "Mission";
            this.btn_mission.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_mission.UseVisualStyleBackColor = true;
            this.btn_mission.Click += new System.EventHandler(this.btn_mission_Click);
            // 
            // btn_setup
            // 
            this.btn_setup.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_setup.FlatAppearance.BorderSize = 0;
            this.btn_setup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btn_setup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setup.ForeColor = System.Drawing.Color.White;
            this.btn_setup.Image = ((System.Drawing.Image)(resources.GetObject("btn_setup.Image")));
            this.btn_setup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setup.Location = new System.Drawing.Point(0, 0);
            this.btn_setup.Name = "btn_setup";
            this.btn_setup.Size = new System.Drawing.Size(200, 60);
            this.btn_setup.TabIndex = 3;
            this.btn_setup.Text = "Setup";
            this.btn_setup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_setup.UseVisualStyleBackColor = true;
            this.btn_setup.Click += new System.EventHandler(this.btn_setup_Click);
            // 
            // panel_usercontrol
            // 
            this.panel_usercontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_usercontrol.Location = new System.Drawing.Point(200, 65);
            this.panel_usercontrol.Name = "panel_usercontrol";
            this.panel_usercontrol.Size = new System.Drawing.Size(1080, 684);
            this.panel_usercontrol.TabIndex = 3;
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // Form_Telemetry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 749);
            this.Controls.Add(this.panel_usercontrol);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel_statues);
            this.Controls.Add(this.panel_top);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form_Telemetry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Telemetry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Telemetry_FormClosing);
            this.Load += new System.EventHandler(this.Form_Telemetry_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_statues.ResumeLayout(false);
            this.panel_statues.PerformLayout();
            this.panel_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel_statues;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button btn_setup;
        private System.Windows.Forms.Panel panel_usercontrol;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_aboutus;
        private System.Windows.Forms.Button btn_pidtunning;
        private System.Windows.Forms.Button btn_datalogging;
        private System.Windows.Forms.Button btn_mission;
        private System.Windows.Forms.Label lbl_programinfo;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.ComboBox cBox_baudrate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBox_ports;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_connect;
        public System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label lbl_test;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}