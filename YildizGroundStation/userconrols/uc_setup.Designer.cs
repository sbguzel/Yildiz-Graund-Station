namespace YildizGroundStation.userconrols
{
    partial class uc_setup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_setup));
            this.panel_setup_size_control = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_cal = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar_cal_acc = new System.Windows.Forms.ProgressBar();
            this.progressBar_cal_gyro = new System.Windows.Forms.ProgressBar();
            this.progressBar_cal_mag = new System.Windows.Forms.ProgressBar();
            this.btn_calibrate_gyro = new System.Windows.Forms.Button();
            this.btn_calibrate_mag = new System.Windows.Forms.Button();
            this.btn_calibrate_Acc = new System.Windows.Forms.Button();
            this.panel_setup_size_control.SuspendLayout();
            this.tableLayoutPanel_cal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_setup_size_control
            // 
            this.panel_setup_size_control.Controls.Add(this.tableLayoutPanel_cal);
            this.panel_setup_size_control.Location = new System.Drawing.Point(0, 0);
            this.panel_setup_size_control.Margin = new System.Windows.Forms.Padding(0);
            this.panel_setup_size_control.Name = "panel_setup_size_control";
            this.panel_setup_size_control.Size = new System.Drawing.Size(600, 300);
            this.panel_setup_size_control.TabIndex = 0;
            // 
            // tableLayoutPanel_cal
            // 
            this.tableLayoutPanel_cal.ColumnCount = 2;
            this.tableLayoutPanel_cal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel_cal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel_cal.Controls.Add(this.progressBar_cal_acc, 1, 0);
            this.tableLayoutPanel_cal.Controls.Add(this.progressBar_cal_gyro, 1, 1);
            this.tableLayoutPanel_cal.Controls.Add(this.progressBar_cal_mag, 1, 2);
            this.tableLayoutPanel_cal.Controls.Add(this.btn_calibrate_gyro, 0, 1);
            this.tableLayoutPanel_cal.Controls.Add(this.btn_calibrate_mag, 0, 2);
            this.tableLayoutPanel_cal.Controls.Add(this.btn_calibrate_Acc, 0, 0);
            this.tableLayoutPanel_cal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_cal.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_cal.Name = "tableLayoutPanel_cal";
            this.tableLayoutPanel_cal.RowCount = 3;
            this.tableLayoutPanel_cal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_cal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_cal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_cal.Size = new System.Drawing.Size(600, 300);
            this.tableLayoutPanel_cal.TabIndex = 4;
            // 
            // progressBar_cal_acc
            // 
            this.progressBar_cal_acc.BackColor = System.Drawing.Color.White;
            this.progressBar_cal_acc.ForeColor = System.Drawing.Color.White;
            this.progressBar_cal_acc.Location = new System.Drawing.Point(240, 0);
            this.progressBar_cal_acc.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar_cal_acc.Name = "progressBar_cal_acc";
            this.progressBar_cal_acc.Size = new System.Drawing.Size(360, 100);
            this.progressBar_cal_acc.Step = 100;
            this.progressBar_cal_acc.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_cal_acc.TabIndex = 0;
            // 
            // progressBar_cal_gyro
            // 
            this.progressBar_cal_gyro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar_cal_gyro.BackColor = System.Drawing.Color.White;
            this.progressBar_cal_gyro.ForeColor = System.Drawing.Color.White;
            this.progressBar_cal_gyro.Location = new System.Drawing.Point(240, 100);
            this.progressBar_cal_gyro.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar_cal_gyro.Name = "progressBar_cal_gyro";
            this.progressBar_cal_gyro.Size = new System.Drawing.Size(360, 100);
            this.progressBar_cal_gyro.Step = 100;
            this.progressBar_cal_gyro.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_cal_gyro.TabIndex = 0;
            // 
            // progressBar_cal_mag
            // 
            this.progressBar_cal_mag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar_cal_mag.BackColor = System.Drawing.Color.White;
            this.progressBar_cal_mag.ForeColor = System.Drawing.Color.White;
            this.progressBar_cal_mag.Location = new System.Drawing.Point(240, 200);
            this.progressBar_cal_mag.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar_cal_mag.Name = "progressBar_cal_mag";
            this.progressBar_cal_mag.Size = new System.Drawing.Size(360, 100);
            this.progressBar_cal_mag.Step = 100;
            this.progressBar_cal_mag.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_cal_mag.TabIndex = 0;
            // 
            // btn_calibrate_gyro
            // 
            this.btn_calibrate_gyro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_calibrate_gyro.BackColor = System.Drawing.Color.White;
            this.btn_calibrate_gyro.FlatAppearance.BorderSize = 0;
            this.btn_calibrate_gyro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btn_calibrate_gyro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calibrate_gyro.Image = ((System.Drawing.Image)(resources.GetObject("btn_calibrate_gyro.Image")));
            this.btn_calibrate_gyro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_calibrate_gyro.Location = new System.Drawing.Point(0, 100);
            this.btn_calibrate_gyro.Margin = new System.Windows.Forms.Padding(0);
            this.btn_calibrate_gyro.Name = "btn_calibrate_gyro";
            this.btn_calibrate_gyro.Size = new System.Drawing.Size(240, 100);
            this.btn_calibrate_gyro.TabIndex = 1;
            this.btn_calibrate_gyro.Text = "Calibrate Gyroscope";
            this.btn_calibrate_gyro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_calibrate_gyro.UseVisualStyleBackColor = false;
            this.btn_calibrate_gyro.Click += new System.EventHandler(this.btn_calibrate_gyro_Click);
            // 
            // btn_calibrate_mag
            // 
            this.btn_calibrate_mag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_calibrate_mag.BackColor = System.Drawing.Color.White;
            this.btn_calibrate_mag.FlatAppearance.BorderSize = 0;
            this.btn_calibrate_mag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btn_calibrate_mag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calibrate_mag.Image = ((System.Drawing.Image)(resources.GetObject("btn_calibrate_mag.Image")));
            this.btn_calibrate_mag.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_calibrate_mag.Location = new System.Drawing.Point(0, 200);
            this.btn_calibrate_mag.Margin = new System.Windows.Forms.Padding(0);
            this.btn_calibrate_mag.Name = "btn_calibrate_mag";
            this.btn_calibrate_mag.Size = new System.Drawing.Size(240, 100);
            this.btn_calibrate_mag.TabIndex = 1;
            this.btn_calibrate_mag.Text = "Calibrate Magnotemeter";
            this.btn_calibrate_mag.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_calibrate_mag.UseVisualStyleBackColor = false;
            this.btn_calibrate_mag.Click += new System.EventHandler(this.btn_calibrate_mag_Click);
            // 
            // btn_calibrate_Acc
            // 
            this.btn_calibrate_Acc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_calibrate_Acc.BackColor = System.Drawing.Color.White;
            this.btn_calibrate_Acc.FlatAppearance.BorderSize = 0;
            this.btn_calibrate_Acc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btn_calibrate_Acc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calibrate_Acc.Image = ((System.Drawing.Image)(resources.GetObject("btn_calibrate_Acc.Image")));
            this.btn_calibrate_Acc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_calibrate_Acc.Location = new System.Drawing.Point(0, 0);
            this.btn_calibrate_Acc.Margin = new System.Windows.Forms.Padding(0);
            this.btn_calibrate_Acc.Name = "btn_calibrate_Acc";
            this.btn_calibrate_Acc.Size = new System.Drawing.Size(240, 100);
            this.btn_calibrate_Acc.TabIndex = 1;
            this.btn_calibrate_Acc.Text = "Calibrate Accelerometer";
            this.btn_calibrate_Acc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_calibrate_Acc.UseVisualStyleBackColor = false;
            this.btn_calibrate_Acc.Click += new System.EventHandler(this.btn_calibrate_Acc_Click);
            // 
            // uc_setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel_setup_size_control);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "uc_setup";
            this.Size = new System.Drawing.Size(1080, 735);
            this.SizeChanged += new System.EventHandler(this.uc_setup_SizeChanged);
            this.panel_setup_size_control.ResumeLayout(false);
            this.tableLayoutPanel_cal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_setup_size_control;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_cal;
        private System.Windows.Forms.ProgressBar progressBar_cal_acc;
        private System.Windows.Forms.ProgressBar progressBar_cal_gyro;
        private System.Windows.Forms.ProgressBar progressBar_cal_mag;
        private System.Windows.Forms.Button btn_calibrate_gyro;
        private System.Windows.Forms.Button btn_calibrate_mag;
        private System.Windows.Forms.Button btn_calibrate_Acc;
    }
}
