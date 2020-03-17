using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JangSwitch
{
    public partial class Function : Form
    {
        public Function(string[] args)
        {
            InitializeComponent();
        }

        private void Button1_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

            bool button_state = true;
        private void Button1_Click(object sender, MouseEventArgs e)
        {

            if (button_state == true)
            {
                button1.Image = Properties.Resources.btn_start;
                button_state = false;
            }
            else
            {
                button1.Image = Properties.Resources.btn_stop;
                button_state = true;
            }
        }
    }
}
