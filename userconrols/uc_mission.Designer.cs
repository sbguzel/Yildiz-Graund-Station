namespace YildizGroundStation.userconrols
{
    partial class uc_mission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_mission));
            this.splitContainer_mission = new System.Windows.Forms.SplitContainer();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pb_cp = new System.Windows.Forms.PictureBox();
            this.pb_ah = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_txt_empty2 = new System.Windows.Forms.Label();
            this.pb_empty2 = new System.Windows.Forms.PictureBox();
            this.pb_temperature = new System.Windows.Forms.PictureBox();
            this.lbl_temperature = new System.Windows.Forms.Label();
            this.lbl_txt_temperature = new System.Windows.Forms.Label();
            this.lbl_empty2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pb_longitude = new System.Windows.Forms.PictureBox();
            this.pb_latitude = new System.Windows.Forms.PictureBox();
            this.lbl_latitude = new System.Windows.Forms.Label();
            this.lbl_txt_latitude = new System.Windows.Forms.Label();
            this.lbl_txt_longitude = new System.Windows.Forms.Label();
            this.lbl_longitude = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_txt_empty1 = new System.Windows.Forms.Label();
            this.pb_empty1 = new System.Windows.Forms.PictureBox();
            this.pb_height = new System.Windows.Forms.PictureBox();
            this.lbl_height = new System.Windows.Forms.Label();
            this.lbl_txt_height = new System.Windows.Forms.Label();
            this.lbl_empty1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pb_fixtype = new System.Windows.Forms.PictureBox();
            this.pb_numberofsatellities = new System.Windows.Forms.PictureBox();
            this.lbl_txt_numofsatellites = new System.Windows.Forms.Label();
            this.lbl_txt_fixtype = new System.Windows.Forms.Label();
            this.lbl_numberofsatellites = new System.Windows.Forms.Label();
            this.lbl_fixtype = new System.Windows.Forms.Label();
            this.richTextBox_Setpoints = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_deletelastsetpoint = new System.Windows.Forms.Button();
            this.btn_addsetpoint = new System.Windows.Forms.Button();
            this.timer_showdata = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_mission)).BeginInit();
            this.splitContainer_mission.Panel1.SuspendLayout();
            this.splitContainer_mission.Panel2.SuspendLayout();
            this.splitContainer_mission.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ah)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_empty2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_temperature)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_longitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_latitude)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_empty1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_height)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fixtype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_numberofsatellities)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer_mission
            // 
            this.splitContainer_mission.BackColor = System.Drawing.Color.White;
            this.splitContainer_mission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_mission.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_mission.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer_mission.Name = "splitContainer_mission";
            this.splitContainer_mission.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_mission.Panel1
            // 
            this.splitContainer_mission.Panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.splitContainer_mission.Panel1.Controls.Add(this.webBrowser1);
            // 
            // splitContainer_mission.Panel2
            // 
            this.splitContainer_mission.Panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.splitContainer_mission.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer_mission.Panel2MinSize = 100;
            this.splitContainer_mission.Size = new System.Drawing.Size(1350, 730);
            this.splitContainer_mission.SplitterDistance = 530;
            this.splitContainer_mission.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(15, 16);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1350, 530);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser1_ProgressChanged_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pb_cp, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.pb_ah, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox_Setpoints, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1350, 196);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pb_cp
            // 
            this.pb_cp.BackColor = System.Drawing.Color.White;
            this.pb_cp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_cp.Image = ((System.Drawing.Image)(resources.GetObject("pb_cp.Image")));
            this.pb_cp.Location = new System.Drawing.Point(1080, 0);
            this.pb_cp.Margin = new System.Windows.Forms.Padding(0);
            this.pb_cp.Name = "pb_cp";
            this.tableLayoutPanel1.SetRowSpan(this.pb_cp, 2);
            this.pb_cp.Size = new System.Drawing.Size(270, 196);
            this.pb_cp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_cp.TabIndex = 58;
            this.pb_cp.TabStop = false;
            // 
            // pb_ah
            // 
            this.pb_ah.BackColor = System.Drawing.Color.White;
            this.pb_ah.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_ah.Image = ((System.Drawing.Image)(resources.GetObject("pb_ah.Image")));
            this.pb_ah.Location = new System.Drawing.Point(810, 0);
            this.pb_ah.Margin = new System.Windows.Forms.Padding(0);
            this.pb_ah.Name = "pb_ah";
            this.tableLayoutPanel1.SetRowSpan(this.pb_ah, 2);
            this.pb_ah.Size = new System.Drawing.Size(270, 196);
            this.pb_ah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_ah.TabIndex = 56;
            this.pb_ah.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Controls.Add(this.lbl_txt_empty2, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.pb_empty2, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.pb_temperature, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lbl_temperature, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.lbl_txt_temperature, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.lbl_empty2, 2, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(270, 98);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.MinimumSize = new System.Drawing.Size(0, 50);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(270, 98);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // lbl_txt_empty2
            // 
            this.lbl_txt_empty2.AutoSize = true;
            this.lbl_txt_empty2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_txt_empty2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_txt_empty2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_txt_empty2.Location = new System.Drawing.Point(81, 49);
            this.lbl_txt_empty2.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_txt_empty2.Name = "lbl_txt_empty2";
            this.lbl_txt_empty2.Size = new System.Drawing.Size(135, 49);
            this.lbl_txt_empty2.TabIndex = 54;
            this.lbl_txt_empty2.Text = "-";
            this.lbl_txt_empty2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_empty2
            // 
            this.pb_empty2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pb_empty2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_empty2.Location = new System.Drawing.Point(0, 49);
            this.pb_empty2.Margin = new System.Windows.Forms.Padding(0);
            this.pb_empty2.Name = "pb_empty2";
            this.pb_empty2.Size = new System.Drawing.Size(81, 49);
            this.pb_empty2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_empty2.TabIndex = 53;
            this.pb_empty2.TabStop = false;
            // 
            // pb_temperature
            // 
            this.pb_temperature.BackColor = System.Drawing.Color.White;
            this.pb_temperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_temperature.Image = ((System.Drawing.Image)(resources.GetObject("pb_temperature.Image")));
            this.pb_temperature.Location = new System.Drawing.Point(0, 0);
            this.pb_temperature.Margin = new System.Windows.Forms.Padding(0);
            this.pb_temperature.Name = "pb_temperature";
            this.pb_temperature.Size = new System.Drawing.Size(81, 49);
            this.pb_temperature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_temperature.TabIndex = 52;
            this.pb_temperature.TabStop = false;
            // 
            // lbl_temperature
            // 
            this.lbl_temperature.AutoSize = true;
            this.lbl_temperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_temperature.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_temperature.Location = new System.Drawing.Point(216, 0);
            this.lbl_temperature.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_temperature.Name = "lbl_temperature";
            this.lbl_temperature.Size = new System.Drawing.Size(54, 49);
            this.lbl_temperature.TabIndex = 50;
            this.lbl_temperature.Text = "-";
            this.lbl_temperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_txt_temperature
            // 
            this.lbl_txt_temperature.AutoSize = true;
            this.lbl_txt_temperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_txt_temperature.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_txt_temperature.Location = new System.Drawing.Point(81, 0);
            this.lbl_txt_temperature.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_txt_temperature.Name = "lbl_txt_temperature";
            this.lbl_txt_temperature.Size = new System.Drawing.Size(135, 49);
            this.lbl_txt_temperature.TabIndex = 47;
            this.lbl_txt_temperature.Text = "Temperature";
            this.lbl_txt_temperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_empty2
            // 
            this.lbl_empty2.AutoSize = true;
            this.lbl_empty2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_empty2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_empty2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_empty2.Location = new System.Drawing.Point(216, 49);
            this.lbl_empty2.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_empty2.Name = "lbl_empty2";
            this.lbl_empty2.Size = new System.Drawing.Size(54, 49);
            this.lbl_empty2.TabIndex = 51;
            this.lbl_empty2.Text = "-";
            this.lbl_empty2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.Controls.Add(this.pb_longitude, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.pb_latitude, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbl_latitude, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbl_txt_latitude, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbl_txt_longitude, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbl_longitude, 2, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 98);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.MinimumSize = new System.Drawing.Size(0, 50);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(270, 98);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // pb_longitude
            // 
            this.pb_longitude.BackColor = System.Drawing.Color.White;
            this.pb_longitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_longitude.Image = ((System.Drawing.Image)(resources.GetObject("pb_longitude.Image")));
            this.pb_longitude.Location = new System.Drawing.Point(0, 49);
            this.pb_longitude.Margin = new System.Windows.Forms.Padding(0);
            this.pb_longitude.Name = "pb_longitude";
            this.pb_longitude.Size = new System.Drawing.Size(81, 49);
            this.pb_longitude.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_longitude.TabIndex = 49;
            this.pb_longitude.TabStop = false;
            // 
            // pb_latitude
            // 
            this.pb_latitude.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pb_latitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_latitude.Image = ((System.Drawing.Image)(resources.GetObject("pb_latitude.Image")));
            this.pb_latitude.Location = new System.Drawing.Point(0, 0);
            this.pb_latitude.Margin = new System.Windows.Forms.Padding(0);
            this.pb_latitude.Name = "pb_latitude";
            this.pb_latitude.Size = new System.Drawing.Size(81, 49);
            this.pb_latitude.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_latitude.TabIndex = 48;
            this.pb_latitude.TabStop = false;
            // 
            // lbl_latitude
            // 
            this.lbl_latitude.AutoSize = true;
            this.lbl_latitude.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_latitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_latitude.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_latitude.Location = new System.Drawing.Point(162, 0);
            this.lbl_latitude.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_latitude.Name = "lbl_latitude";
            this.lbl_latitude.Size = new System.Drawing.Size(108, 49);
            this.lbl_latitude.TabIndex = 41;
            this.lbl_latitude.Text = "-";
            this.lbl_latitude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_txt_latitude
            // 
            this.lbl_txt_latitude.AutoSize = true;
            this.lbl_txt_latitude.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_txt_latitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_txt_latitude.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_txt_latitude.Location = new System.Drawing.Point(81, 0);
            this.lbl_txt_latitude.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_txt_latitude.Name = "lbl_txt_latitude";
            this.lbl_txt_latitude.Size = new System.Drawing.Size(81, 49);
            this.lbl_txt_latitude.TabIndex = 46;
            this.lbl_txt_latitude.Text = "Latitude";
            this.lbl_txt_latitude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_txt_longitude
            // 
            this.lbl_txt_longitude.AutoSize = true;
            this.lbl_txt_longitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_txt_longitude.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_txt_longitude.Location = new System.Drawing.Point(81, 49);
            this.lbl_txt_longitude.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_txt_longitude.Name = "lbl_txt_longitude";
            this.lbl_txt_longitude.Size = new System.Drawing.Size(81, 49);
            this.lbl_txt_longitude.TabIndex = 45;
            this.lbl_txt_longitude.Text = "Longitude";
            this.lbl_txt_longitude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_longitude
            // 
            this.lbl_longitude.AutoSize = true;
            this.lbl_longitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_longitude.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_longitude.Location = new System.Drawing.Point(162, 49);
            this.lbl_longitude.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_longitude.Name = "lbl_longitude";
            this.lbl_longitude.Size = new System.Drawing.Size(108, 49);
            this.lbl_longitude.TabIndex = 47;
            this.lbl_longitude.Text = "-";
            this.lbl_longitude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_txt_empty1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.pb_empty1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.pb_height, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_height, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_txt_height, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_empty1, 2, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(270, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.MinimumSize = new System.Drawing.Size(0, 50);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(270, 98);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // lbl_txt_empty1
            // 
            this.lbl_txt_empty1.AutoSize = true;
            this.lbl_txt_empty1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_txt_empty1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_txt_empty1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_txt_empty1.Location = new System.Drawing.Point(81, 49);
            this.lbl_txt_empty1.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_txt_empty1.Name = "lbl_txt_empty1";
            this.lbl_txt_empty1.Size = new System.Drawing.Size(135, 49);
            this.lbl_txt_empty1.TabIndex = 57;
            this.lbl_txt_empty1.Text = "-";
            this.lbl_txt_empty1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_empty1
            // 
            this.pb_empty1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pb_empty1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_empty1.Location = new System.Drawing.Point(0, 49);
            this.pb_empty1.Margin = new System.Windows.Forms.Padding(0);
            this.pb_empty1.Name = "pb_empty1";
            this.pb_empty1.Size = new System.Drawing.Size(81, 49);
            this.pb_empty1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_empty1.TabIndex = 56;
            this.pb_empty1.TabStop = false;
            // 
            // pb_height
            // 
            this.pb_height.BackColor = System.Drawing.Color.White;
            this.pb_height.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_height.Image = ((System.Drawing.Image)(resources.GetObject("pb_height.Image")));
            this.pb_height.Location = new System.Drawing.Point(0, 0);
            this.pb_height.Margin = new System.Windows.Forms.Padding(0);
            this.pb_height.Name = "pb_height";
            this.pb_height.Size = new System.Drawing.Size(81, 49);
            this.pb_height.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_height.TabIndex = 55;
            this.pb_height.TabStop = false;
            // 
            // lbl_height
            // 
            this.lbl_height.AutoSize = true;
            this.lbl_height.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_height.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_height.Location = new System.Drawing.Point(216, 0);
            this.lbl_height.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(54, 49);
            this.lbl_height.TabIndex = 48;
            this.lbl_height.Text = "-";
            this.lbl_height.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_txt_height
            // 
            this.lbl_txt_height.AutoSize = true;
            this.lbl_txt_height.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_txt_height.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_txt_height.Location = new System.Drawing.Point(81, 0);
            this.lbl_txt_height.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_txt_height.Name = "lbl_txt_height";
            this.lbl_txt_height.Size = new System.Drawing.Size(135, 49);
            this.lbl_txt_height.TabIndex = 44;
            this.lbl_txt_height.Text = "Height";
            this.lbl_txt_height.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_empty1
            // 
            this.lbl_empty1.AutoSize = true;
            this.lbl_empty1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_empty1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_empty1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_empty1.Location = new System.Drawing.Point(216, 49);
            this.lbl_empty1.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_empty1.Name = "lbl_empty1";
            this.lbl_empty1.Size = new System.Drawing.Size(54, 49);
            this.lbl_empty1.TabIndex = 49;
            this.lbl_empty1.Text = "-";
            this.lbl_empty1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.pb_fixtype, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.pb_numberofsatellities, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_txt_numofsatellites, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_txt_fixtype, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_numberofsatellites, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_fixtype, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.MinimumSize = new System.Drawing.Size(0, 50);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(270, 98);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pb_fixtype
            // 
            this.pb_fixtype.BackColor = System.Drawing.Color.White;
            this.pb_fixtype.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_fixtype.Image = ((System.Drawing.Image)(resources.GetObject("pb_fixtype.Image")));
            this.pb_fixtype.Location = new System.Drawing.Point(0, 49);
            this.pb_fixtype.Margin = new System.Windows.Forms.Padding(0);
            this.pb_fixtype.Name = "pb_fixtype";
            this.pb_fixtype.Size = new System.Drawing.Size(81, 49);
            this.pb_fixtype.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_fixtype.TabIndex = 47;
            this.pb_fixtype.TabStop = false;
            // 
            // pb_numberofsatellities
            // 
            this.pb_numberofsatellities.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pb_numberofsatellities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_numberofsatellities.Image = ((System.Drawing.Image)(resources.GetObject("pb_numberofsatellities.Image")));
            this.pb_numberofsatellities.Location = new System.Drawing.Point(0, 0);
            this.pb_numberofsatellities.Margin = new System.Windows.Forms.Padding(0);
            this.pb_numberofsatellities.Name = "pb_numberofsatellities";
            this.pb_numberofsatellities.Size = new System.Drawing.Size(81, 49);
            this.pb_numberofsatellities.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_numberofsatellities.TabIndex = 46;
            this.pb_numberofsatellities.TabStop = false;
            // 
            // lbl_txt_numofsatellites
            // 
            this.lbl_txt_numofsatellites.AutoSize = true;
            this.lbl_txt_numofsatellites.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_txt_numofsatellites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_txt_numofsatellites.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_txt_numofsatellites.Location = new System.Drawing.Point(81, 0);
            this.lbl_txt_numofsatellites.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_txt_numofsatellites.Name = "lbl_txt_numofsatellites";
            this.lbl_txt_numofsatellites.Size = new System.Drawing.Size(135, 49);
            this.lbl_txt_numofsatellites.TabIndex = 36;
            this.lbl_txt_numofsatellites.Text = "Num of Satellites ";
            this.lbl_txt_numofsatellites.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_txt_fixtype
            // 
            this.lbl_txt_fixtype.AutoSize = true;
            this.lbl_txt_fixtype.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_txt_fixtype.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_txt_fixtype.Location = new System.Drawing.Point(81, 49);
            this.lbl_txt_fixtype.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_txt_fixtype.Name = "lbl_txt_fixtype";
            this.lbl_txt_fixtype.Size = new System.Drawing.Size(135, 49);
            this.lbl_txt_fixtype.TabIndex = 38;
            this.lbl_txt_fixtype.Text = "Fix Type";
            this.lbl_txt_fixtype.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_numberofsatellites
            // 
            this.lbl_numberofsatellites.AutoSize = true;
            this.lbl_numberofsatellites.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_numberofsatellites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_numberofsatellites.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_numberofsatellites.Location = new System.Drawing.Point(216, 0);
            this.lbl_numberofsatellites.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_numberofsatellites.Name = "lbl_numberofsatellites";
            this.lbl_numberofsatellites.Size = new System.Drawing.Size(54, 49);
            this.lbl_numberofsatellites.TabIndex = 39;
            this.lbl_numberofsatellites.Text = "-";
            this.lbl_numberofsatellites.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_fixtype
            // 
            this.lbl_fixtype.AutoSize = true;
            this.lbl_fixtype.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_fixtype.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_fixtype.Location = new System.Drawing.Point(216, 49);
            this.lbl_fixtype.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_fixtype.Name = "lbl_fixtype";
            this.lbl_fixtype.Size = new System.Drawing.Size(54, 49);
            this.lbl_fixtype.TabIndex = 40;
            this.lbl_fixtype.Text = "-";
            this.lbl_fixtype.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox_Setpoints
            // 
            this.richTextBox_Setpoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Setpoints.Location = new System.Drawing.Point(540, 0);
            this.richTextBox_Setpoints.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox_Setpoints.Name = "richTextBox_Setpoints";
            this.richTextBox_Setpoints.ReadOnly = true;
            this.richTextBox_Setpoints.Size = new System.Drawing.Size(270, 98);
            this.richTextBox_Setpoints.TabIndex = 61;
            this.richTextBox_Setpoints.Text = "";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.btn_deletelastsetpoint, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.btn_addsetpoint, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(543, 101);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(264, 92);
            this.tableLayoutPanel6.TabIndex = 62;
            // 
            // btn_deletelastsetpoint
            // 
            this.btn_deletelastsetpoint.BackColor = System.Drawing.Color.White;
            this.btn_deletelastsetpoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_deletelastsetpoint.FlatAppearance.BorderSize = 0;
            this.btn_deletelastsetpoint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_deletelastsetpoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletelastsetpoint.Location = new System.Drawing.Point(0, 46);
            this.btn_deletelastsetpoint.Margin = new System.Windows.Forms.Padding(0);
            this.btn_deletelastsetpoint.Name = "btn_deletelastsetpoint";
            this.btn_deletelastsetpoint.Size = new System.Drawing.Size(264, 46);
            this.btn_deletelastsetpoint.TabIndex = 62;
            this.btn_deletelastsetpoint.Text = "Delete Last Setpoint";
            this.btn_deletelastsetpoint.UseVisualStyleBackColor = false;
            // 
            // btn_addsetpoint
            // 
            this.btn_addsetpoint.BackColor = System.Drawing.Color.White;
            this.btn_addsetpoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_addsetpoint.FlatAppearance.BorderSize = 0;
            this.btn_addsetpoint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_addsetpoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addsetpoint.Location = new System.Drawing.Point(0, 0);
            this.btn_addsetpoint.Margin = new System.Windows.Forms.Padding(0);
            this.btn_addsetpoint.Name = "btn_addsetpoint";
            this.btn_addsetpoint.Size = new System.Drawing.Size(264, 46);
            this.btn_addsetpoint.TabIndex = 61;
            this.btn_addsetpoint.Text = "Add Setpoint";
            this.btn_addsetpoint.UseVisualStyleBackColor = false;
            // 
            // timer_showdata
            // 
            this.timer_showdata.Enabled = true;
            // 
            // uc_mission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.splitContainer_mission);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "uc_mission";
            this.Size = new System.Drawing.Size(1350, 730);
            this.Load += new System.EventHandler(this.uc_mission_Load);
            this.splitContainer_mission.Panel1.ResumeLayout(false);
            this.splitContainer_mission.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_mission)).EndInit();
            this.splitContainer_mission.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_cp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ah)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_empty2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_temperature)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_longitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_latitude)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_empty1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_height)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fixtype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_numberofsatellities)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer_mission;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lbl_txt_empty2;
        private System.Windows.Forms.PictureBox pb_empty2;
        private System.Windows.Forms.PictureBox pb_temperature;
        private System.Windows.Forms.Label lbl_temperature;
        private System.Windows.Forms.Label lbl_txt_temperature;
        private System.Windows.Forms.Label lbl_empty2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.PictureBox pb_longitude;
        private System.Windows.Forms.PictureBox pb_latitude;
        private System.Windows.Forms.Label lbl_latitude;
        private System.Windows.Forms.Label lbl_txt_latitude;
        private System.Windows.Forms.Label lbl_txt_longitude;
        private System.Windows.Forms.Label lbl_longitude;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_txt_empty1;
        private System.Windows.Forms.PictureBox pb_empty1;
        private System.Windows.Forms.PictureBox pb_height;
        private System.Windows.Forms.Label lbl_height;
        private System.Windows.Forms.Label lbl_txt_height;
        private System.Windows.Forms.Label lbl_empty1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pb_fixtype;
        private System.Windows.Forms.PictureBox pb_numberofsatellities;
        private System.Windows.Forms.Label lbl_txt_numofsatellites;
        private System.Windows.Forms.Label lbl_txt_fixtype;
        private System.Windows.Forms.Label lbl_numberofsatellites;
        private System.Windows.Forms.Label lbl_fixtype;
        private System.Windows.Forms.PictureBox pb_ah;
        private System.Windows.Forms.PictureBox pb_cp;
        private System.Windows.Forms.RichTextBox richTextBox_Setpoints;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btn_deletelastsetpoint;
        private System.Windows.Forms.Button btn_addsetpoint;
        private System.Windows.Forms.Timer timer_showdata;
    }
}
