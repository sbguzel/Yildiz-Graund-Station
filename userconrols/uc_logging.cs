using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace YildizGroundStation.userconrols
{
    public partial class uc_logging : UserControl
    {
        bool[] loggingChecks = new bool[30];
        bool islog = true;
        List<CheckBox> myCheckboxlist = new List<CheckBox>();

        public uc_logging()
        {
            InitializeComponent();
            
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            int i = 0;
            richTextBox1.Text = "";
            foreach(CheckBox check in myCheckboxlist)
            {
                loggingChecks[i] = check.Checked;
                richTextBox1.Text += Convert.ToInt16(loggingChecks[i]).ToString();
                i++;
            }
        }

        private void btn_startstoplog_Click(object sender, EventArgs e)
        {
            if (islog)
            {
                btn_startstoplog.Text = "Stop Logging";
                btn_startstoplog.BackColor = Color.DarkRed;
                DateTime dt = DateTime.Now;
                string LogFileName = dt.ToString("ddMMMyy-HH.mm");
                //saveFileDialog1.InitialDirectory = @"C:\";
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.FileName = LogFileName+".txt";
                saveFileDialog1.DefaultExt = "txt";
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                    using (StreamWriter sw = new StreamWriter(s))
                    {
                        sw.Write(richTextBox1.Text);
                    }
                }
                islog = !islog;
            }
            else
            {
                btn_startstoplog.Text = "Start Logging";
                btn_startstoplog.BackColor = Color.DarkGreen;
            }
        }

        private void uc_logging_SizeChanged(object sender, EventArgs e)
        {
            
        }
        
    }
}
