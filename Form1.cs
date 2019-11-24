using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Security.Permissions;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace YildizGroundStation
{
    
    public partial class Form1 : Form
    {
        int mov, movX, movY;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void panel_top_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        

        private void panel_top_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel_top_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
        

    }
}
