namespace YildizGroundStation.userconrols
{
    partial class uc_pidtunning
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_pidtunning));
            this.dataRateTimer = new System.Windows.Forms.Timer(this.components);
            this.chartUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.winChartViewer1 = new ChartDirector.WinChartViewer();
            this.trackLine2Enable = new System.Windows.Forms.CheckBox();
            this.trackLine1Enable = new System.Windows.Forms.CheckBox();
            this.pointerPB = new System.Windows.Forms.RadioButton();
            this.zoomInPB = new System.Windows.Forms.RadioButton();
            this.zoomOutPB = new System.Windows.Forms.RadioButton();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.btn_sendnewpid = new System.Windows.Forms.Button();
            this.timer_takedata = new System.Windows.Forms.Timer(this.components);
            this.rB_roll = new System.Windows.Forms.RadioButton();
            this.rB_pitch = new System.Windows.Forms.RadioButton();
            this.rB_yaw = new System.Windows.Forms.RadioButton();
            this.rB_height = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_currentP = new System.Windows.Forms.Label();
            this.textBox_newP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_currentI = new System.Windows.Forms.Label();
            this.textBox_newI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_currentD = new System.Windows.Forms.Label();
            this.textBox_newD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox_SetPID = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.winChartViewer1)).BeginInit();
            this.groupBox_SetPID.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataRateTimer
            // 
            this.dataRateTimer.Enabled = true;
            this.dataRateTimer.Interval = 1000;
            this.dataRateTimer.Tick += new System.EventHandler(this.dataRateTimer_Tick);
            // 
            // chartUpdateTimer
            // 
            this.chartUpdateTimer.Enabled = true;
            this.chartUpdateTimer.Interval = 1000;
            this.chartUpdateTimer.Tick += new System.EventHandler(this.chartUpdateTimer_Tick);
            // 
            // winChartViewer1
            // 
            this.winChartViewer1.Location = new System.Drawing.Point(0, 0);
            this.winChartViewer1.Margin = new System.Windows.Forms.Padding(0);
            this.winChartViewer1.Name = "winChartViewer1";
            this.winChartViewer1.Size = new System.Drawing.Size(512, 288);
            this.winChartViewer1.TabIndex = 28;
            this.winChartViewer1.TabStop = false;
            this.winChartViewer1.MouseMovePlotArea += new System.Windows.Forms.MouseEventHandler(this.winChartViewer1_MouseMovePlotArea);
            this.winChartViewer1.ViewPortChanged += new ChartDirector.WinViewPortEventHandler(this.winChartViewer1_ViewPortChanged);
            // 
            // trackLine2Enable
            // 
            this.trackLine2Enable.AutoSize = true;
            this.trackLine2Enable.Checked = true;
            this.trackLine2Enable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trackLine2Enable.Location = new System.Drawing.Point(192, 314);
            this.trackLine2Enable.Margin = new System.Windows.Forms.Padding(0);
            this.trackLine2Enable.Name = "trackLine2Enable";
            this.trackLine2Enable.Size = new System.Drawing.Size(91, 21);
            this.trackLine2Enable.TabIndex = 39;
            this.trackLine2Enable.Text = "Cursor 2";
            this.trackLine2Enable.UseVisualStyleBackColor = true;
            this.trackLine2Enable.CheckedChanged += new System.EventHandler(this.trackLineEnable_CheckedChanged);
            // 
            // trackLine1Enable
            // 
            this.trackLine1Enable.AutoSize = true;
            this.trackLine1Enable.Checked = true;
            this.trackLine1Enable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trackLine1Enable.Location = new System.Drawing.Point(101, 314);
            this.trackLine1Enable.Margin = new System.Windows.Forms.Padding(0);
            this.trackLine1Enable.Name = "trackLine1Enable";
            this.trackLine1Enable.Size = new System.Drawing.Size(91, 21);
            this.trackLine1Enable.TabIndex = 38;
            this.trackLine1Enable.Text = "Cursor 1";
            this.trackLine1Enable.UseVisualStyleBackColor = true;
            this.trackLine1Enable.CheckedChanged += new System.EventHandler(this.trackLineEnable_CheckedChanged);
            // 
            // pointerPB
            // 
            this.pointerPB.Appearance = System.Windows.Forms.Appearance.Button;
            this.pointerPB.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pointerPB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pointerPB.Image = ((System.Drawing.Image)(resources.GetObject("pointerPB.Image")));
            this.pointerPB.Location = new System.Drawing.Point(0, 308);
            this.pointerPB.Margin = new System.Windows.Forms.Padding(0);
            this.pointerPB.Name = "pointerPB";
            this.pointerPB.Size = new System.Drawing.Size(30, 30);
            this.pointerPB.TabIndex = 34;
            this.pointerPB.CheckedChanged += new System.EventHandler(this.pointerPB_CheckedChanged);
            // 
            // zoomInPB
            // 
            this.zoomInPB.Appearance = System.Windows.Forms.Appearance.Button;
            this.zoomInPB.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.zoomInPB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoomInPB.Image = ((System.Drawing.Image)(resources.GetObject("zoomInPB.Image")));
            this.zoomInPB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.zoomInPB.Location = new System.Drawing.Point(29, 308);
            this.zoomInPB.Margin = new System.Windows.Forms.Padding(0);
            this.zoomInPB.Name = "zoomInPB";
            this.zoomInPB.Size = new System.Drawing.Size(30, 30);
            this.zoomInPB.TabIndex = 35;
            this.zoomInPB.CheckedChanged += new System.EventHandler(this.zoomInPB_CheckedChanged);
            // 
            // zoomOutPB
            // 
            this.zoomOutPB.Appearance = System.Windows.Forms.Appearance.Button;
            this.zoomOutPB.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.zoomOutPB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoomOutPB.Image = ((System.Drawing.Image)(resources.GetObject("zoomOutPB.Image")));
            this.zoomOutPB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.zoomOutPB.Location = new System.Drawing.Point(58, 308);
            this.zoomOutPB.Margin = new System.Windows.Forms.Padding(0);
            this.zoomOutPB.Name = "zoomOutPB";
            this.zoomOutPB.Size = new System.Drawing.Size(30, 30);
            this.zoomOutPB.TabIndex = 36;
            this.zoomOutPB.CheckedChanged += new System.EventHandler(this.zoomOutPB_CheckedChanged);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.BackColor = System.Drawing.Color.White;
            this.hScrollBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.hScrollBar1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hScrollBar1.Location = new System.Drawing.Point(0, 288);
            this.hScrollBar1.Maximum = 1000000000;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(512, 20);
            this.hScrollBar1.TabIndex = 37;
            this.hScrollBar1.Visible = false;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // btn_sendnewpid
            // 
            this.btn_sendnewpid.FlatAppearance.BorderSize = 0;
            this.btn_sendnewpid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btn_sendnewpid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sendnewpid.Location = new System.Drawing.Point(6, 200);
            this.btn_sendnewpid.Margin = new System.Windows.Forms.Padding(0);
            this.btn_sendnewpid.Name = "btn_sendnewpid";
            this.btn_sendnewpid.Size = new System.Drawing.Size(163, 34);
            this.btn_sendnewpid.TabIndex = 40;
            this.btn_sendnewpid.Text = "Send";
            this.btn_sendnewpid.UseVisualStyleBackColor = true;
            this.btn_sendnewpid.Click += new System.EventHandler(this.btn_sendnewpid_Click);
            // 
            // timer_takedata
            // 
            this.timer_takedata.Tick += new System.EventHandler(this.timer_takedata_Tick);
            // 
            // rB_roll
            // 
            this.rB_roll.AutoSize = true;
            this.rB_roll.Checked = true;
            this.rB_roll.Location = new System.Drawing.Point(6, 22);
            this.rB_roll.Name = "rB_roll";
            this.rB_roll.Size = new System.Drawing.Size(58, 21);
            this.rB_roll.TabIndex = 41;
            this.rB_roll.TabStop = true;
            this.rB_roll.Text = "Roll";
            this.rB_roll.UseVisualStyleBackColor = true;
            // 
            // rB_pitch
            // 
            this.rB_pitch.AutoSize = true;
            this.rB_pitch.Location = new System.Drawing.Point(92, 22);
            this.rB_pitch.Name = "rB_pitch";
            this.rB_pitch.Size = new System.Drawing.Size(66, 21);
            this.rB_pitch.TabIndex = 41;
            this.rB_pitch.Text = "Pitch";
            this.rB_pitch.UseVisualStyleBackColor = true;
            // 
            // rB_yaw
            // 
            this.rB_yaw.AutoSize = true;
            this.rB_yaw.Location = new System.Drawing.Point(6, 54);
            this.rB_yaw.Name = "rB_yaw";
            this.rB_yaw.Size = new System.Drawing.Size(50, 21);
            this.rB_yaw.TabIndex = 41;
            this.rB_yaw.Text = "Yaw";
            this.rB_yaw.UseVisualStyleBackColor = true;
            // 
            // rB_height
            // 
            this.rB_height.AutoSize = true;
            this.rB_height.Location = new System.Drawing.Point(92, 54);
            this.rB_height.Name = "rB_height";
            this.rB_height.Size = new System.Drawing.Size(74, 21);
            this.rB_height.TabIndex = 41;
            this.rB_height.Text = "Height";
            this.rB_height.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Current";
            // 
            // lbl_currentP
            // 
            this.lbl_currentP.AutoSize = true;
            this.lbl_currentP.Location = new System.Drawing.Point(25, 114);
            this.lbl_currentP.Name = "lbl_currentP";
            this.lbl_currentP.Size = new System.Drawing.Size(56, 17);
            this.lbl_currentP.TabIndex = 42;
            this.lbl_currentP.Text = "__,___";
            this.lbl_currentP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_newP
            // 
            this.textBox_newP.Location = new System.Drawing.Point(92, 108);
            this.textBox_newP.Name = "textBox_newP";
            this.textBox_newP.Size = new System.Drawing.Size(77, 23);
            this.textBox_newP.TabIndex = 43;
            this.textBox_newP.Text = "0,0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "I";
            // 
            // lbl_currentI
            // 
            this.lbl_currentI.AutoSize = true;
            this.lbl_currentI.Location = new System.Drawing.Point(25, 142);
            this.lbl_currentI.Name = "lbl_currentI";
            this.lbl_currentI.Size = new System.Drawing.Size(56, 17);
            this.lbl_currentI.TabIndex = 42;
            this.lbl_currentI.Text = "__,___";
            this.lbl_currentI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_newI
            // 
            this.textBox_newI.Location = new System.Drawing.Point(92, 136);
            this.textBox_newI.Name = "textBox_newI";
            this.textBox_newI.Size = new System.Drawing.Size(77, 23);
            this.textBox_newI.TabIndex = 43;
            this.textBox_newI.Text = "0,0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "D";
            // 
            // lbl_currentD
            // 
            this.lbl_currentD.AutoSize = true;
            this.lbl_currentD.Location = new System.Drawing.Point(25, 170);
            this.lbl_currentD.Name = "lbl_currentD";
            this.lbl_currentD.Size = new System.Drawing.Size(56, 17);
            this.lbl_currentD.TabIndex = 42;
            this.lbl_currentD.Text = "__,___";
            this.lbl_currentD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_newD
            // 
            this.textBox_newD.Location = new System.Drawing.Point(92, 164);
            this.textBox_newD.Name = "textBox_newD";
            this.textBox_newD.Size = new System.Drawing.Size(77, 23);
            this.textBox_newD.TabIndex = 43;
            this.textBox_newD.Text = "0,0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(4, 233);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 10);
            this.label7.TabIndex = 42;
            this.label7.Text = "(Please use \',\' to set precision)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 17);
            this.label8.TabIndex = 42;
            this.label8.Text = "New";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "P";
            // 
            // groupBox_SetPID
            // 
            this.groupBox_SetPID.AutoSize = true;
            this.groupBox_SetPID.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_SetPID.BackColor = System.Drawing.Color.White;
            this.groupBox_SetPID.Controls.Add(this.rB_yaw);
            this.groupBox_SetPID.Controls.Add(this.textBox_newD);
            this.groupBox_SetPID.Controls.Add(this.btn_sendnewpid);
            this.groupBox_SetPID.Controls.Add(this.lbl_currentD);
            this.groupBox_SetPID.Controls.Add(this.rB_roll);
            this.groupBox_SetPID.Controls.Add(this.textBox_newI);
            this.groupBox_SetPID.Controls.Add(this.rB_pitch);
            this.groupBox_SetPID.Controls.Add(this.lbl_currentI);
            this.groupBox_SetPID.Controls.Add(this.rB_height);
            this.groupBox_SetPID.Controls.Add(this.label7);
            this.groupBox_SetPID.Controls.Add(this.label2);
            this.groupBox_SetPID.Controls.Add(this.label5);
            this.groupBox_SetPID.Controls.Add(this.label8);
            this.groupBox_SetPID.Controls.Add(this.textBox_newP);
            this.groupBox_SetPID.Controls.Add(this.lbl_currentP);
            this.groupBox_SetPID.Controls.Add(this.label9);
            this.groupBox_SetPID.Controls.Add(this.label3);
            this.groupBox_SetPID.Location = new System.Drawing.Point(515, 13);
            this.groupBox_SetPID.Name = "groupBox_SetPID";
            this.groupBox_SetPID.Size = new System.Drawing.Size(177, 262);
            this.groupBox_SetPID.TabIndex = 44;
            this.groupBox_SetPID.TabStop = false;
            this.groupBox_SetPID.Text = "Set New PID Values";
            // 
            // uc_pidtunning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.groupBox_SetPID);
            this.Controls.Add(this.winChartViewer1);
            this.Controls.Add(this.trackLine2Enable);
            this.Controls.Add(this.trackLine1Enable);
            this.Controls.Add(this.pointerPB);
            this.Controls.Add(this.zoomInPB);
            this.Controls.Add(this.zoomOutPB);
            this.Controls.Add(this.hScrollBar1);
            this.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "uc_pidtunning";
            this.Size = new System.Drawing.Size(1350, 750);
            this.Load += new System.EventHandler(this.uc_pidtunning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.winChartViewer1)).EndInit();
            this.groupBox_SetPID.ResumeLayout(false);
            this.groupBox_SetPID.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Timer dataRateTimer;
        internal System.Windows.Forms.Timer chartUpdateTimer;
        private ChartDirector.WinChartViewer winChartViewer1;
        private System.Windows.Forms.CheckBox trackLine2Enable;
        private System.Windows.Forms.CheckBox trackLine1Enable;
        private System.Windows.Forms.RadioButton pointerPB;
        private System.Windows.Forms.RadioButton zoomInPB;
        private System.Windows.Forms.RadioButton zoomOutPB;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        public System.Windows.Forms.Button btn_sendnewpid;
        private System.Windows.Forms.Timer timer_takedata;
        private System.Windows.Forms.RadioButton rB_roll;
        private System.Windows.Forms.RadioButton rB_pitch;
        private System.Windows.Forms.RadioButton rB_yaw;
        private System.Windows.Forms.RadioButton rB_height;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_currentP;
        private System.Windows.Forms.TextBox textBox_newP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_currentI;
        private System.Windows.Forms.TextBox textBox_newI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_currentD;
        private System.Windows.Forms.TextBox textBox_newD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox_SetPID;
    }
}
