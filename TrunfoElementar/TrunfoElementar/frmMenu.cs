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
    public partial class frmMenu : Form
    {
        //form SplashScreen
        private Form frmSplash;
        //inicialização do frmMenu
        public frmMenu(Form frmSplash)
        {
            this.frmSplash = frmSplash;
            InitializeComponent();
        }
        private void sairJogo()
        {
            DialogResult resp = MessageBox.Show("Deseja realmente sair do jogo?", "Sair",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                frmSplash.Close();
                frmSplash.Dispose();
                this.Close();
            }
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            frmJogo Jogo = new frmJogo(this, this.frmSplash);
            Jogo.Show();
            this.Hide();
        }
        private void btnRegras_Click(object sender, EventArgs e)
        {

        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja realmente sair do jogo?", "Sair",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                frmSplash.Dispose();
                frmSplash.Close();
                this.Dispose();
                this.Close();
            }
            e.Cancel = true;
        }
    }
}
