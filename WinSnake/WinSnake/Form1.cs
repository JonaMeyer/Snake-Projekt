using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSnake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tmStopp_Tick(object sender, EventArgs e)
        {
            tmStopp.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }
    }
}
