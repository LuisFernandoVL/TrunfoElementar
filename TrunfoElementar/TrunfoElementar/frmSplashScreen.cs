using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrunfoElementar
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            tmrSplashScreen.Enabled = true;
        }

        private void tmrSplashScreen_Tick(object sender, EventArgs e)
        {
            frmMenu Menu = new frmMenu(this);
            Menu.Show();
            this.Hide();
            tmrSplashScreen.Enabled = false;
        }
    }
}
